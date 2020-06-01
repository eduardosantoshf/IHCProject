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
        private Music currentMusic;
        private App app;
        private List<Music> musicFoundPlay = new List<Music>();
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
            NoInfoLabel.BackColor = Color.Transparent;
            MusicListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MusicListView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MusicListView.CellMouseClick += MusicListView_CellMouseClick;
            for (int i = 0; i < MusicListView.ColumnCount; i++)
            {
                MusicListView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            Image imageFav = getFav(Color.Red);
            Image imageAdd = Image.FromFile(@"..\\..\\Resources\\Add.png");
            Image imageDown = Image.FromFile(@"..\\..\\Resources\\Down.png");
            DataGridViewImageColumn imgFav = new DataGridViewImageColumn();


            imgFav.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgFav.Width = 35;
            imgFav.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            
            MusicListView.Columns.Add(imgFav);

            DataGridViewImageColumn imgAdd = new DataGridViewImageColumn();
            imgAdd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgAdd.Width = 35;
            imgAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            
            MusicListView.Columns.Add(imgAdd);

            DataGridViewImageColumn imgDown = new DataGridViewImageColumn();

            imgDown.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgDown.Width = 35;
            imgDown.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            
            MusicListView.Columns.Add(imgDown);
            button1.BackColor = Color.Green;
            button1.Text = "Follow";


            DataGridViewImageColumn imgGo = new DataGridViewImageColumn();
            Image goCheck = Image.FromFile(@"..\\..\\Resources\\GoCheck.png");

            imgGo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgGo.Width = 35;
            imgGo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgGo.Name = "img";
            imgGo.HeaderText = "";
            MusicListView.Columns.Add(imgGo);


            List<Album> albums = user.Albums;
            int countMusics = 0;
            
            
            foreach (Music music in Music.musicsList)
            {

                object[] row =
            {
                music.Name,
                music.Singer,
                music.Album,
                music.Duration,
                imageFav,
                imageDown,
                imageAdd,
                goCheck
            };
                if(music.Singer == user.Name)
                {
                MusicListView.Rows.Add(row);
                countMusics++;
                }
                   
            }
                   
            
            MusicNumber.Text = countMusics.ToString();
            FollowersNo.Text = user.Followers.ToString();
            FollowingNo.Text = user.Following.ToString();
         
        }
        private Image getFav(Color color)
        {
            if (color == Color.Red)
            {
                Image imageFav = Image.FromFile(@"..\\..\\Resources\\HeartRed.png");
                return imageFav;
            }
            else
            {
                Image imageFav = Image.FromFile(@"..\\..\\Resources\\HeartGrey.png");
                return imageFav;
            }
        }
        private void InitUserInfo()
        {
            Username.Text = user.Username;
            Birthday.Text = user.Birthday.ToString("d");
            Bio.Text = user.Bio;
            NoInfoLabel.BackColor = Color.Transparent;
            foreach (PlayList pl in app.User.myPlaylist)
            {
                ListBox.Items.Add(pl.PlaylistName);
            }
            if (ListBox.Items.Count != 0)
            {
                NoInfoLabel.Visible = false;
            }
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

        private void MusicListView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Music music = new Music();
            foreach (Music m in app.Musics)
            {
                if (MusicListView.CurrentRow.Cells[0].Value.ToString() == m.Name)
                {
                    music = m;
                    break;
                }
            }


            if (MusicListView.CurrentCell.ColumnIndex == 7)
            {
                app.OpenChildForm(new MusicForm(app, currentMusic));
            }

            else if(MusicListView.CurrentCell.ColumnIndex == 4)
            {
                if (user.Favorite.Musics.Contains(currentMusic))
                {
                    user.Favorite.Musics.Remove(currentMusic);
                    MusicListView.CurrentCell.Value = getFav(Color.Silver);
                    MessageBox.Show("Removed from Favorites!");
                }


                else
                {
                    
                    user.Favorite.Musics.Add(currentMusic);
                    MusicListView.CurrentCell.Value = getFav(Color.Red);
                    MessageBox.Show("Added to Favorites!");
                }
                MusicListView.Rows.Clear();
                MusicListView.Columns[7].Dispose();
                MusicListView.Columns[6].Dispose();
                MusicListView.Columns[5].Dispose();
                MusicListView.Columns[4].Dispose();
                InitListView();

            }
            else if (MusicListView.CurrentCell.ColumnIndex == 5)
            {
                MessageBox.Show("Downloaded");
            }
            else if (MusicListView.CurrentCell.ColumnIndex == 6)
            {
                currentMusic = music;
                AddPanel.Visible = true;

            }
            else
            {
                if (e.RowIndex > -1)
                {

                    string musicname = MusicListView.Rows[e.RowIndex].Cells[0].Value.ToString();

                    if (app.User.email.Equals("LocalData"))
                        app.Musics = Favourite.favourite.Musics;
                    else
                        app.Musics = app.User.Favorite.Musics;
                    app.Play(musicname);
                }


            }
            MusicListView.Refresh();

        }
     
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("No music selected!");
                return;
            }

            foreach (PlayList playList in app.User.myPlaylist)
            {
                if (playList.PlaylistName.Equals(ListBox.SelectedItem.ToString()))
                {
                    playList.Musics.Add(currentMusic);
                    MessageBox.Show("Music added!");
                    AddPanel.Visible = false;
                    return;
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.DarkRed)
            {
                button1.BackColor = Color.Green;
                app.User.Following--;
                button1.Text = "Follow";
                user.Followers--;

            }
            else
            {
                button1.BackColor = Color.DarkRed;
                button1.Text = "Unfollow";
                app.User.Following++;
                user.Followers++;
            }
            FollowersNo.Text = user.Followers.ToString();
            FollowingNo.Text = user.Following.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewPlaylistPanel.Visible = true;
            NewPlaylistPanel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPlaylistPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PlayListNameBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Playlist name can't be empty!");
                return;
            }
            PlayList playList = new PlayList(PlayListNameBox.Text);

            playList.Image = Properties.Resources.Playlist;
            app.User.myPlaylist.Add(playList);
            PlayListNameBox.Text = "";
            NewPlaylistPanel.Visible = false;
            ListBox.Items.Add(playList.PlaylistName);
            NoInfoLabel.Text = "Select A Playlist";

        }
    }
}
