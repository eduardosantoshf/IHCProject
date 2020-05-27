using System;
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
        public PlayListForm(App app)
        {
            this.app = app;
            InitializeComponent();
            NewPlaylistPanel.BringToFront();
            toolTip1.InitialDelay = 100;
            InitPlayLists();
        }

        private PictureBox lastBox=null;
        private void InitPlayLists()
        {
            List<PlayList> playLists = app.User.myPlaylist;
            
            for (int i = 0; i < playLists.Count; i++)
            {

                if (lastBox == null)
                {
                    lastBox = ControlExtensions.Clone(PictureBoxExemplo);
                    lastBox.Name = playLists[i].PlaylistName;
                    lastBox.Cursor = Cursors.Hand;
                    lastBox.Image = playLists[i].Image;
                    lastBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    lastBox.Visible = true;
                    lastBox.Size = new Size(125, 111);
                    lastBox.MouseHover += new EventHandler(this.PlayListToolTip);
                    lastBox.MouseClick += new MouseEventHandler(PlayList_Music);
                    PlayListPanel.Controls.Add(lastBox);
                    PlayListPanel.Refresh();
                }
                else
                {
                    lastBox = ControlExtensions.Clone(lastBox);
                    lastBox.Image = playLists[i].Image;
                    lastBox.Name = playLists[i].PlaylistName;
                    if (lastBox.Location.X > 498)
                    {
                        lastBox.Location = new Point(46, lastBox.Location.Y + 134);
                    }
                    else
                    {
                        lastBox.Location = new Point(lastBox.Location.X + 210, lastBox.Location.Y);
                    }
                    lastBox.Visible = true;
                    lastBox.MouseHover += new EventHandler(this.PlayListToolTip);
                    lastBox.MouseClick += new MouseEventHandler(PlayList_Music);
                    PlayListPanel.Controls.Add(lastBox);
                    PlayListPanel.Refresh();
                }

            }

            IconPictureBox iconPictureBox = new IconPictureBox();
            iconPictureBox.IconChar = IconChar.PlusCircle;
            if (lastBox != null)
            {
                if (lastBox.Location.X > 498)
                {
                    iconPictureBox.Location = new Point(46, lastBox.Location.Y + 134);
                }
                else
                {

                    iconPictureBox.Location = new Point(lastBox.Location.X + 210, lastBox.Location.Y);
                }
                iconPictureBox.Size = lastBox.Size;
            }
            else
            {
                iconPictureBox.Location = PictureBoxExemplo.Location;
                iconPictureBox.Size = PictureBoxExemplo.Size;
            }

            iconPictureBox.Cursor = Cursors.Hand;
            iconPictureBox.Visible = true;
            iconPictureBox.MouseHover += new EventHandler(AddToolTip);
            iconPictureBox.MouseClick += new MouseEventHandler(AddNewPlayList);
            PlayListPanel.Controls.Add(iconPictureBox);
            PlayListPanel.Refresh();

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
            IconPictureBox pb = (IconPictureBox)sender;
            toolTip1.Show("Add new Playlist", pb);
        }

        private void CreateNewPlayList_Click(object sender, EventArgs e)
        {
            if (PlayListNameBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Playlist name cant be empty!");
                return;
            }
            PlayList playList = new PlayList(PlayListNameBox.Text);
            
            playList.Image = Properties.Resources.Playlist;
            app.User.myPlaylist.Add(playList);
            PlayListNameBox.Text = "";
            NewPlaylistPanel.Visible = false;
            lastBox = null;
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
    }
}
