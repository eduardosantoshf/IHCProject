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
    public partial class FriendsForm : Form, MyChildForm
    {
        private App app;
        private int commentCounter = 0;
        private User friend1;
        private List<User> allUsers = new List<User>();

        public FriendsForm(App app)
        {
            this.app = app;
            
            InitializeComponent();
            InitUserInfo();
        }
        private void loadFriends()
        {
            
            foreach(User user in User.users.Values)
            {
                if (user.email != app.User.email)
                    allUsers.Add(user);
            }

            int userCount = User.users.Count - 1;
            int index = 0;
            for (int i = 1; i < 5; i++)
            {
                
                if (i > userCount)
                    break;
                Panel a = (Panel)Controls.Find("FriendPanel" + i, true)[0];
                Label name = (Label)Controls.Find("FriendName" + i, true)[0];
                Label bio = (Label)Controls.Find("FriendBio" + i, true)[0];
                PictureBox pic = (PictureBox)Controls.Find("FriendPic" + i, true)[0];
                
                a.Visible = true;
                name.Text = "";
                
                String FriendEmail;
                if (allUsers[index].Name == "")
                {
                    name.Text = allUsers[index].email;
                    FriendEmail = allUsers[index].email;
                }
                else
                {
                    name.Text = allUsers[index].Name;
                    FriendEmail = allUsers[index].email;
                    
                }
                    
                name.Click += delegate (object sender, EventArgs e)
                {   
                    Click(sender, e, FriendEmail);
                };
                bio.Text = allUsers[index].Bio;
                pic.Image = allUsers[index].Picture;
                pic.Click+=delegate(object sender, EventArgs e)
                {
                    Click(sender, e, FriendEmail);
                };
                
                index++;

            }
                
        }



        public void InitUserInfo()
        {
            if (commentCounter == 0)
            {
                NoActivity.Visible = true;
            }
            loadFriends();
            if (app.User.email.Equals("LocalData"))
            {
                PublishBtn.Enabled = false;
                ActivityPanel.Visible = false;
                LoginPanel.Visible = true;
            }
            else
            {
                PublishBtn.Enabled = true;
                ActivityPanel.Visible = true;
                
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
            OpenChildForm(new ProfileFriend(friend1.email, app));
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

        private List<Panel> activities = new List<Panel>();
        private Panel lastActivity;
        int count;
        private void PublishBtn_Click(object sender, EventArgs e)
        {
            if (lastActivity == null)
            {
                lastActivity = ControlExtensions.Clone(PanelPublication);
                lastActivity.Visible = true;

                
                lastActivity.Name = "New Publication";
                PictureBox pb = ControlExtensions.Clone(Friend1Picture);
                pb.Image = app.User.Picture;
                pb.Visible = true;
                pb.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                pb.Cursor = Cursors.Hand;
                Label name = ControlExtensions.Clone(Friend1);
                name.Text = app.User.email;
                name.Visible = true;
                name.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                name.Cursor = Cursors.Hand;

                Label data = ControlExtensions.Clone(Date);
                data.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                data.Visible = true;
                data.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                data.Cursor = Cursors.Hand;

                TextBox text = ControlExtensions.Clone(PubText);
                text.Text = ActivityTextBox.Text;
                text.Visible = true;
                ActivityTextBox.Text = "";
                Panel newPanel6 = ControlExtensions.Clone(panel6);
                newPanel6.Visible = true;
                newPanel6.Name = app.User.email;
                newPanel6.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                newPanel6.Cursor = Cursors.Hand;

                Label likes = ControlExtensions.Clone(LikeBox);
                likes.Text = "0";
                likes.Visible = true;
                Label redirect = ControlExtensions.Clone(RedirectBox);
                redirect.Text = "0";
                redirect.Visible = true;
                Label replay = ControlExtensions.Clone(LikeBox);
                replay.Text = "0";
                replay.Visible = true;
                IconPictureBox icon1 = new IconPictureBox();
                InitLikeIcon(icon1);
                IconPictureBox icon2 = new IconPictureBox();
                InitRedirectIcon(icon2);


                newPanel6.Controls.Add(pb);
                newPanel6.Controls.Add(name);
                lastActivity.Controls.Add(text);
                lastActivity.Controls.Add(icon1);
                lastActivity.Controls.Add(icon2);
                newPanel6.Controls.Add(data);
                lastActivity.Controls.Add(likes);
                lastActivity.Controls.Add(redirect);
                lastActivity.Controls.Add(replay);

                lastActivity.Controls.Add(newPanel6);
                lastActivity.Show();
                activities.Add(lastActivity);
                ActivityPanel.Controls.Add(lastActivity);
                ActivityPanel.Refresh();
            }
            else
            {
                Panel newPanel6 = ControlExtensions.Clone(panel6);
                newPanel6.Visible = true;
                newPanel6.Name = app.User.email;
                newPanel6.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                newPanel6.Cursor = Cursors.Hand;
                Panel newPub = ControlExtensions.Clone(PanelPublication);
                newPub.Visible = true;
                newPub.Name = "New Publication";
                newPub.Location = new Point(lastActivity.Location.X, lastActivity.Location.Y + 160);
                PictureBox pb = ControlExtensions.Clone(Friend1Picture);
                pb.Image = app.User.Picture;
                pb.Visible = true;
                pb.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                pb.Cursor = Cursors.Hand;

                Label name = ControlExtensions.Clone(Friend1);
                name.Text = app.User.email;
                name.Visible = true;
                name.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                name.Cursor = Cursors.Hand;
                Label data = ControlExtensions.Clone(Date);
                data.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                data.Visible = true;
                data.Click += delegate (object sender2, EventArgs e2)
                {
                    Click(sender2, e2, app.User.email);
                };
                data.Cursor = Cursors.Hand;

                TextBox text = ControlExtensions.Clone(PubText);
                text.Text = ActivityTextBox.Text;
                text.Visible = true;
                ActivityTextBox.Text = "";
                Label likes = ControlExtensions.Clone(LikeBox);
                likes.Text = "0";
                likes.Visible = true;
                Label redirect = ControlExtensions.Clone(LikeBox);
                redirect.Text = "0";
                redirect.Visible = true;
                Label replay = ControlExtensions.Clone(LikeBox);
                replay.Text = "0";
                replay.Visible = true;
                IconPictureBox icon1 = new IconPictureBox();
                InitLikeIcon(icon1);
                IconPictureBox icon2 = new IconPictureBox();
                InitRedirectIcon(icon2);



                newPanel6.Controls.Add(pb);
                newPanel6.Controls.Add(name);
                newPub.Controls.Add(text);
                newPub.Controls.Add(icon1);
                newPub.Controls.Add(icon2);
                newPanel6.Controls.Add(data);
                newPub.Controls.Add(likes);
                newPub.Controls.Add(redirect);
                newPub.Controls.Add(replay);
                newPub.Controls.Add(newPanel6);
                newPub.Show();
                ActivityPanel.Controls.Add(newPub);
                ActivityPanel.Refresh();
                lastActivity = newPub;
            }
           
            NoActivity.Visible = false;
            ActivityTextBox.Text = "";
        }

        private void Click(object sender, EventArgs e, String email)
        {
            OpenChildForm(new ProfileFriend(email, app));
        }
        



        private void InitLikeIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor = Color.Transparent;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.ThumbsUp;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = LikeIcon.Location;
            iconPicture.Name = "icon" + count;
            iconPicture.Size = LikeIcon.Size;
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;

        }

        

        private void InitRedirectIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor = Color.Transparent;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Reply;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = RedirectIcon.Location;
            iconPicture.Name = "icon" + count;
            iconPicture.Size = RedirectIcon.Size;
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;

        }

        private void FriendPic1_Click(object sender, EventArgs e)
        {

        }

        private void FriendName1_Click(object sender, EventArgs e)
        {

        }
    }
}