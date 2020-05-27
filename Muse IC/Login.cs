using System;
using System.Collections;
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
    public partial class Login : Form
    {
        private bool flag;
        private User user;
        public Login(bool flag)
        {
            this.flag = flag;
            InitializeComponent();
        }

        private void Skip_MouseEnter(object sender, EventArgs e)
        {
            Skip.ForeColor = Color.Blue;
        }

        private void Skip_MouseLeave(object sender, EventArgs e)
        {
            Skip.ForeColor = Color.Black;
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            Hide();
            if (flag)
            {
                Dispose();
                DialogResult = DialogResult.Cancel;
                return;
            }
            App app = new App();
            app.StartPosition = FormStartPosition.CenterParent;
            app.Owner = this;
            app.ShowDialog();
            Application.ExitThread();
            Dispose();
            DialogResult = DialogResult.Cancel;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.StartPosition = FormStartPosition.CenterParent;
            DialogResult rc = register.ShowDialog();
            if (rc == DialogResult.OK)
            {
                UserNameBox.Text = register.EmailBox.Text;
            }
            register.Dispose();
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
        
            if (flag)
            {
                string email = UserNameBox.Text;
                string pwd = PasswordBox.Text;
                User log = new User(email, pwd);
                if (User.users.ContainsKey(email))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Account does not exist!");
                }
            }
            else
            {
                string email = UserNameBox.Text;
                string pwd = PasswordBox.Text;
                User log = new User(email, pwd);
                if (User.users.ContainsKey(email))
                {
                    Hide();
                    App app = new App(UserNameBox.Text);
                    app.ShowDialog();
                    Application.ExitThread();
                    Dispose();
                    DialogResult = DialogResult.Cancel;
                }
                else
                {
                    MessageBox.Show("Account does not exist!");
                }
            }
            
        }
    }
}
