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
    public partial class MusicForm : Form,MyChildForm
    {
        private App app;
        private Music currentMusic;

        public MusicForm(App app,Music music)
        {
            this.app = app;
            currentMusic = music;
            InitializeComponent();
            InitUserInfo();
        }

        public void InitUserInfo()
        {
            MusicNameLabel.Text = currentMusic.Name;
            SingerLabel.Text = currentMusic.Singer;
            MusicAlbumLabel.Text = currentMusic.Album;
            ShareNumber.Text = "0";
            DownloadNumber.Text = "0";
            LikedNumber.Text = "0";

            ListBox.Items.Clear();
            ListBox.Items.Add("Favorite");

            foreach (PlayList playList in app.User.myPlaylist)
            {
                ListBox.Items.Add(playList.PlaylistName);
            }
        }

        private void AddTo_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (app.User.email.Equals("LocalData"))
            {
                if (ListBox.SelectedIndex == 0)
                {
                    Favourite.favourite.Musics.Add(currentMusic);
                    MessageBox.Show("Music added!");
                }
                else
                {
                    foreach(PlayList playList in PlayList.playLists)
                    {
                        if (playList.PlaylistName.Equals(ListBox.SelectedItem.ToString()))
                        {
                            playList.Musics.Add(currentMusic);
                            MessageBox.Show("Music added!");
                            return;
                        }
                    }
                }
            }
            else {
                if (ListBox.SelectedIndex == 0)
                {
                    app.User.Favorite.Musics.Add(currentMusic);
                    MessageBox.Show("Music added!");
                }
                else
                {
                    foreach (PlayList playList in app.User.myPlaylist)
                    {
                        if (playList.PlaylistName.Equals(ListBox.SelectedItem.ToString()))
                        {
                            playList.Musics.Add(currentMusic);
                            MessageBox.Show("Music added!");
                            return;
                        }
                    }
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItems.Count == 0)
                AddBtn.Enabled = false;
            else if(ListBox.SelectedItems.Count == 1) 
                AddBtn.Enabled = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }
    }

}
