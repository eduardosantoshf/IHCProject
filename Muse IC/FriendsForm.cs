using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse_IC
{
    public partial class FriendsForm : Form,MyChildForm
    {
        private App app;
        private User friend1;
        public FriendsForm(App app)
        {
            this.app = app;
            InitializeComponent();
            InitUserInfo();
        }

        public void InitUserInfo()
        {
            if (app.User.email.Equals("LocalData"))
            {
                PublishBtn.Enabled = false;
                ActivityPanel.Visible = false;
                LoginPanel.Location = ActivityPanel.Location;
                LoginPanel.Visible = true;
            }
            else
            {
                PublishBtn.Enabled = true;
                ActivityPanel.Visible = true;
                LoginPanel.Location = ActivityPanel.Location;
                LoginPanel.Visible = false;
                Follower.Text = app.User.Followers.ToString();
                Following.Text = app.User.Following.ToString();
                myUsername.Text = app.User.Username;
                myBio.Text = app.User.Bio;
                myPic.Image = app.User.Picture;

                foreach (string email in User.users.Keys)
                {
                    
                        friend1 = User.users[email];
                        Friend1.Text = friend1.email;
                        Friend1Picture.Image = friend1.Picture;
                    
                }
            }
        }
        private void GoLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(true);
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                app.User = User.users[login.UserNameBox.Text];
                app.InitUserInfo();
            }
            InitUserInfo();
        }
        private void Friend1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileFriend(friend1.email,app));
        }
        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            app.ChildFormPanel.Controls.Add(childForm);
            app.ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PublishBtn_Click(object sender, EventArgs e)
        {
            Panel newPub = ControlExtensions.Clone(PanelPublication);
            newPub.Visible = true;
            newPub.Name = "New Publication";
            PictureBox pb = ControlExtensions.Clone(Friend1Picture);
            pb.Image = app.User.Picture;
            pb.Visible = true;

            Label name = ControlExtensions.Clone(Friend1);
            name.Text = app.User.email;
            name.Visible = true;

            Label data = ControlExtensions.Clone(Date);
            data.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            data.Visible = true;

            RichTextBox text = ControlExtensions.Clone(PubText);
            text.Text = ActivityTextBox.Text;
            text.Visible = true;
            text.Text = "";

            Label likes = ControlExtensions.Clone(LikeBox);
            likes.Text = "0";
            likes.Visible = true;
            Label redirect = ControlExtensions.Clone(LikeBox);
            redirect.Text = "0";
            redirect.Visible = true;
            Label replay = ControlExtensions.Clone(LikeBox);
            replay.Text = "0";
            replay.Visible = true;
            IconPictureBox icon1 = ControlExtensions.Clone(LikeIcon);
            IconPictureBox icon2 = ControlExtensions.Clone(ReplayIcon);
            IconPictureBox icon3 = ControlExtensions.Clone(RedirectIcon);

            newPub.Controls.Add(pb);
            newPub.Controls.Add(name);
            newPub.Controls.Add(text);
            newPub.Controls.Add(icon1);
            newPub.Controls.Add(icon2);
            newPub.Controls.Add(icon3);
            newPub.Controls.Add(data);
            newPub.Controls.Add(likes);
            newPub.Controls.Add(redirect);
            newPub.Controls.Add(replay);
            ActivityPanel.Controls.Add(newPub);
            ActivityPanel.Show();
            ActivityPanel.Refresh();
        }

        private void Friend1Picture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileFriend(friend1.email, app));
        }
    
    }
}
