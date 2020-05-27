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
    public partial class FindMusicForm : Form
    {
        private App app;
        public FindMusicForm(App app)
        {
            this.app = app;
            panels = new List<Panel>();
            InitializeComponent();
            MusicFound.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MusicFound.RowTemplate.Height = 40;
            InitListView();
        }

        private Music currentMusic;
        private Panel lastpanel = null;
        private List<Panel> panels;
        private List<Music> musicFoundPlay = new List<Music>();
        int count;
        int heartcount;
        int downloadcount;
        int addcount;
        private void InitListView()
        {
            count = 1;
            heartcount = 1;
            downloadcount = 1;
            addcount = 1;
            MusicFound.CellBorderStyle = DataGridViewCellBorderStyle.None;

            foreach (Music music in Music.musicsList)
            {
                object[] row =
                {
                    "   ",
                    music.Name,
                    music.Singer,
                    music.Album,
                    music.Duration
                };
                if (lastpanel == null)
                {
                    lastpanel = ControlExtensions.Clone(OperationPanel);
                    lastpanel.Visible = true;
                    lastpanel.Name = "IconPanel_" + count;
                    IconPictureBox icon1 = new IconPictureBox();
                    InitHeartIcon(icon1, music);
                    icon1.MouseClick += new MouseEventHandler(Remove);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitDownloadIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    InitPlusIcon(icon3);

                    lastpanel.Controls.Add(icon1);
                    lastpanel.Controls.Add(icon2);
                    lastpanel.Controls.Add(icon3);
                    icon3.MouseClick += new MouseEventHandler(AddTo);

                    FindMusicPanel.Controls.Add(lastpanel);
                    lastpanel.Show();
                    MusicFound.SendToBack();
                    FindMusicPanel.Refresh();
                    panels.Add(lastpanel);
                }
                else
                {
                    Panel panel = ControlExtensions.Clone(lastpanel);
                    panel.Visible = true;
                    panel.Location = new Point(panel.Location.X, panel.Location.Y + 40);
                    panel.BackColor = Color.White;
                    panel.Name = "IconPanel_" + count;
                    IconPictureBox icon1 = new IconPictureBox();
                    InitHeartIcon(icon1,music);
                    icon1.MouseClick += new MouseEventHandler(Remove);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitDownloadIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    InitPlusIcon(icon3);
                    icon3.MouseClick += new MouseEventHandler(AddTo);

                    panel.Controls.Add(icon1);
                    panel.Controls.Add(icon2);
                    panel.Controls.Add(icon3);

                    FindMusicPanel.Controls.Add(panel);
                    panel.Show();
                    MusicFound.SendToBack();
                    FindMusicPanel.Refresh();
                    lastpanel = panel;
                    panels.Add(panel);
                }
                MusicFound.Rows.Add(row);
                musicFoundPlay.Add(music);
            }
            ListBox.Items.Clear();
            foreach (PlayList playList in app.User.myPlaylist)
            {
                ListBox.Items.Add(playList.PlaylistName);
            }
            if (ListBox.Items.Count == 0)
            {
                AddBtn.Enabled = false;
                NoInfoLabel.Visible = true;
            }
            else
            {
                AddBtn.Enabled = true;
                NoInfoLabel.Visible = false;
            }
        }
        private void AddTo(object o, EventArgs e)
        {
            IconPictureBox ib = (IconPictureBox)o;
            if (ib.Name.StartsWith("add_"))
            {
                int index = int.Parse(ib.Name.Split(new char[] { '_' })[1]) - 1;
                MusicFound.Rows[index].Selected = true;
                foreach (Music music in app.User.Favorite.Musics)
                {
                    
                    string name = MusicFound.Rows[index].Cells[1].Value.ToString();
                    if (music.Name.Equals(name))
                    {
                        currentMusic = music;
                        break;
                    }
                }
                AddPanel.Visible = true;
                ChangePanelColor(index);
            }
        }

        private void Remove(object o, EventArgs e)
        {
            IconPictureBox ib = (IconPictureBox)o;
            if (ib.Name.StartsWith("heart_"))
            {
                int index = int.Parse(ib.Name.Split(new char[] { '_' })[1]) - 1;
                MusicFound.Rows[index].Selected = true;
                foreach (Music music in Music.musicsList)
                {
                    string name = MusicFound.Rows[index].Cells[1].Value.ToString();
                    if (music.Name.Equals(name))
                    {
                        if (ib.ForeColor == Color.Silver)
                        {
                            app.User.Favorite.Musics.Add(music);
                            ib.ForeColor = Color.Red;
                            MessageBox.Show("Music added!");
                        }
                        else
                        {
                            app.User.Favorite.Musics.Remove(music);
                            ib.ForeColor = Color.Silver;
                            MessageBox.Show("Music removed from Favorite!");
                        }
                        break;
                    }
                }
            }
        }
        private void InitHeartIcon(IconPictureBox iconPicture,Music music)
        {
            iconPicture.BackColor = SystemColors.ButtonHighlight;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Heart;
            if (app.User.Favorite.Musics.Contains(music))
                iconPicture.IconColor = Color.Red;
            else
                iconPicture.IconColor = Color.Silver;
            iconPicture.IconSize = 30;
            iconPicture.Location = new Point(15, 2);
            iconPicture.Name = "heart_" + heartcount;
            iconPicture.Size = new Size(27, 27);
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 49;
            iconPicture.TabStop = false;
            heartcount++;
        }

        private void InitDownloadIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor = SystemColors.ButtonHighlight;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Download;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = new Point(57, 2);
            iconPicture.Name = "download_" + downloadcount;
            iconPicture.Size = new Size(27, 27);
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;
            downloadcount++;
        }
        private void InitPlusIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor = SystemColors.ButtonHighlight;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Plus;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = new Point(100, 2);
            iconPicture.Name = "add_" + addcount;
            iconPicture.Size = new Size(27, 27);
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 47;
            iconPicture.TabStop = false;
            addcount++;
        }
        private void ChangePanelColor(int index)
        {
            for (int i = 0; i < panels.Count; i++)
            {
                if (i == index)
                {
                    panels[i].BackColor = Color.FromArgb(0, 120, 215);
                }
                else
                {
                    panels[i].BackColor = Color.White;
                }
            }
        }

        private void MusicFound_SelectionChanged(object sender, EventArgs e)
        {
            int index = MusicFound.CurrentRow.Index;
            ChangePanelColor(index);
        }

        private void MusicFound_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    MusicFound.Rows[e.RowIndex].Selected = true;
                    ChangePanelColor(e.RowIndex);
                    FindMusicContextMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void PlayThisMusic_Click(object sender, EventArgs e)
        {
            string musicname = MusicFound.SelectedRows[0].Cells[1].Value.ToString();
            app.Musics = Music.musicsList;
            app.Play(musicname);
        }

        private void MusicFound_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string musicname = MusicFound.Rows[e.RowIndex].Cells[1].Value.ToString();
                app.Musics = Music.musicsList;
                app.Play(musicname);
            }
            else
            {
                int index = MusicFound.CurrentRow.Index;
                ChangePanelColor(index);
            }
        }

        private void ClearFavoriteMusic()
        {
            List<Control> controls = new List<Control>();
            panels = new List<Panel>();
            foreach (Control control in FindMusicPanel.Controls)
            {
                if (control.Name.StartsWith("IconPanel"))
                {
                    controls.Add(control);
                }
            }
            foreach (Control cont in controls)
            {
                FindMusicPanel.Controls.Remove(cont);
            }
            FindMusicPanel.Refresh();
            lastpanel = null;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
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
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItems.Count == 0)
                AddBtn.Enabled = false;
            else if (ListBox.SelectedItems.Count == 1)
                AddBtn.Enabled = true;
        }

        private void MusicFound_Sorted(object sender, EventArgs e)
        {
            int index = MusicFound.CurrentRow.Index;
            ChangePanelColor(index);
        }

        private void MusicFound_MouseContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                string musicname = MusicFound.Rows[e.RowIndex].Cells[1].Value.ToString();
                app.Musics = musicFoundPlay;
                app.Play(musicname);
            }
            
        }
    }
}
