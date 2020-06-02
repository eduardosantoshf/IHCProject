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
using FontAwesome.Sharp;

namespace Muse_IC
{
    public partial class PlayListForm : Form,MyChildForm
    {
        private App app;
        private List<PictureBox> listOfPictures = new List<PictureBox>();
        public PlayListForm(App app)
        {
            this.app = app;
            InitializeComponent();
            for (int i = 1; i < 8; i++)
            {
                listOfPictures.Add((PictureBox)Controls.Find("Playlist" + i, true)[0]);
            }

            
            NewPlaylistPanel.BringToFront();
            toolTip1.InitialDelay = 100;
            PlaylistAdd.MouseHover += new EventHandler(AddToolTip);
            InitPlayLists();
            
        }

        private void InitPlayLists()
        {
            PlaylistAdd.Visible = false;
            List<PlayList> playLists = app.User.myPlaylist;
            for(int i=0; i < 7; i++)
            {
                if (playLists.Count - 1 < i)
                    break;
                listOfPictures[i].SizeMode = PictureBoxSizeMode.Zoom;
                listOfPictures[i].Image = playLists[i].Image;
                listOfPictures[i].Cursor = Cursors.Hand;
                listOfPictures[i].Visible = true;
                listOfPictures[i].Name = playLists[i].PlaylistName;
                listOfPictures[i].MouseHover += new EventHandler(PlayListToolTip);
                listOfPictures[i].MouseClick += new MouseEventHandler(PlayList_Music);
                PlayListPanel.Controls.Add(listOfPictures[i]);
                PlayListPanel.Refresh();
            }
            if (playLists.Count >= 7)
            {
                
                PlaylistAdd.Visible = true;
                MessageBox.Show("Can't Add More");
            }
            else
            {
                listOfPictures[playLists.Count].SizeMode = PictureBoxSizeMode.Zoom;
                listOfPictures[playLists.Count].Image = Image.FromFile("..\\..\\Resources\\Add.png");
                listOfPictures[playLists.Count].Cursor = Cursors.Hand;
                listOfPictures[playLists.Count].Visible = true;
                listOfPictures[playLists.Count].MouseHover += new EventHandler(AddToolTip);
                listOfPictures[playLists.Count].MouseClick += new MouseEventHandler(AddNewPlayList);
                PlayListPanel.Controls.Add(listOfPictures[playLists.Count]);
                PlayListPanel.Refresh();
                
            }
                
            



        }

        private void PlayList_Music(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            app.OpenChildForm(new PlayList_Music(pb.Name,app));
        }
        private void PlayListToolTip(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            toolTip1.Show(pb.Name, pb) ;
        }

        private void AddNewPlayList(object sender, EventArgs e)
        {
            NewPlaylistPanel.Visible = true;
        }

        private void AddToolTip(object sender, EventArgs e)
        {
            toolTip1.Show("Add new Playlist", PlaylistAdd);
        }

        private void CreateNewPlayList_Click(object sender, EventArgs e)
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
            ClearPlayListPanel();
            InitPlayLists();
        }

        private void ClearPlayListPanel()
        {
            List<Control> controls = new List<Control>();
            foreach(Control control in PlayListPanel.Controls)
            {
                if (control.Name.Equals("PlayList")|| control.Name.Equals("NewPlaylistPanel")|| control.Name.Equals("PictureBoxExemplo"))
                {

                }
                else
                {
                    controls.Add(control);
                }
            }
            foreach(Control cont in controls)
            {
                PlayListPanel.Controls.Remove(cont);
            }
            PlayListPanel.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            PlayListNameBox.Text = "";
            NewPlaylistPanel.Visible = false;
        }

        public void InitUserInfo()
        {
        }

        private void Playlist6_Click(object sender, EventArgs e)
        {

        }

        private void Playlist8_Click(object sender, EventArgs e)
        {

        }

        private void NewPlaylistPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
