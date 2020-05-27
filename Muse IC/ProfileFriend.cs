using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse_IC
{
    public partial class ProfileFriend : Form
    {
        private User user;
        private App app;
        public ProfileFriend(string username, App app)
        {
            this.user = User.users[username];
            this.app = app;
            InitializeComponent();
            InitListView();
            InitUserInfo();
        }

        private void InitListView()
        {

            MusicListView.View = View.Details;
            MusicListView.FullRowSelect = true;
            MusicListView.Columns.Add("Nome");
            MusicListView.Columns.Add("Album");
            MusicListView.Columns.Add("Duration");
            MusicListView.Columns.Add("Date");

            int i = 1;
            List<Album> albums = user.Albums;
            foreach (Album album in albums)
            {
                foreach (Music music in album.Musics)
                {
                    ListViewItem item = new ListViewItem(music.Name);
                    item.SubItems.Add(album.Name);
                    item.SubItems.Add(music.Duration);
                    item.SubItems.Add("2020/5/17");
                    MusicListView.Items.Add(item);
                }
                   
            }

            MusicListView.Columns[0].Width = -1;
            MusicListView.Columns[1].Width = 140;
            MusicListView.Columns[2].Width = 140;
            MusicListView.Columns[3].Width = 140;
        }

        private void InitUserInfo()
        {
            Username.Text = user.Username;
            Birthday.Text = user.Birthday.ToString("d");
            Bio.Text = user.Bio;
            StringBuilder sb = new StringBuilder();
            foreach(string str in user.Tags)
            {
                sb.Append("#").Append(str).Append(" ");
            }
            Tag.Text = sb.ToString();
            Friend1Picture.Image = user.Picture;
        }

        private void EnvelopeIcon_Click(object sender, EventArgs e)
        {
            MessagePanel.Visible = true;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            Message message = new Message();
            message.Topic = Topic.Text;
            message.message = Message.Text;
            user.Messages.Enqueue(message);
            Topic.Text = "";
            Message.Text = "";
            MessagePanel.Visible = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Topic.Text = "";
            Message.Text = "";
            MessagePanel.Visible = false;
        }
    }
}
