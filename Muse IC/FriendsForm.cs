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
    public partial class FriendsForm : Form
    {
        private App app;
        private User friend1;
        public FriendsForm(App app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void FriendsForm_Load(object sender, EventArgs e)
        {
            friend1 = User.users["wei@gmail.com"];
            Friend1.Text = friend1.Username;
            Friend1Picture.Image = friend1.Picture;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
