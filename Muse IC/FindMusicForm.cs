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
        private User user;
        public FindMusicForm(App app)
        {
            this.app = app;
            this.user = app.User;
            panels = new List<Panel>();
            InitializeComponent();
            MusicFound.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MusicFound.RowTemplate.Height = 40;
            for (int i=0; i < MusicFound.ColumnCount; i++)
            {
                MusicFound.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
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


            DataGridViewImageColumn imgFav = new DataGridViewImageColumn();
            Image imageFav = getFav(Color.Silver);
            imgFav.ImageLayout = DataGridViewImageCellLayout.Zoom;

            imgFav.Name = "img";
            imgFav.Width = 35;
            imgFav.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MusicFound.Columns.Add(imgFav);

            DataGridViewImageColumn imgAdd = new DataGridViewImageColumn();
            Image imageAdd = Image.FromFile(@"..\\..\\Resources\\Add.png");
            imgAdd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
            imgAdd.Name = "img";
            imgAdd.Width = 35;
            imgAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MusicFound.Columns.Add(imgAdd);

            DataGridViewImageColumn imgDown = new DataGridViewImageColumn();
            Image imageDown = Image.FromFile(@"..\\..\\Resources\\Down.png");
            imgDown.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgDown.Name = "img";
            imgDown.Width = 35;
            imgDown.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MusicFound.Columns.Add(imgDown);
            DataGridViewImageColumn imgGo = new DataGridViewImageColumn();
            Image goCheck = Image.FromFile(@"..\\..\\Resources\\GoCheck.png");
            imgGo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgGo.Width = 35;
            imgGo.HeaderText = "";
            imgGo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgGo.Name = "img";
            MusicFound.Columns.Add(imgGo);


            foreach (Music music in Music.musicsList)
            {
                if (app.User.Favorite.Musics.Contains(music))
                {
                    imageFav = getFav(Color.Red);
                }
                else
                {
                    imageFav = getFav(Color.Silver);
                }

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
            string musicname = MusicFound.SelectedRows[0].Cells[0].Value.ToString();
            app.Musics = Music.musicsList;
            app.Play(musicname);
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
            Music music = new Music();
            foreach (Music m in app.Musics)
            {
                if (MusicFound.CurrentRow.Cells[0].Value.ToString() == m.Name)
                {
                    music = m;
                    currentMusic = music;
                    break;
                }
            }

            if (MusicFound.CurrentCell.ColumnIndex == 7)
            {
                app.OpenChildForm(new MusicForm(app, music));
            }
            else if (MusicFound.CurrentCell.ColumnIndex == 4)
            {
                if (user.Favorite.Musics.Contains(music))
                {
                    user.Favorite.Musics.Remove(music);
                    MusicFound.CurrentCell.Value = getFav(Color.Silver);
                }


                else
                {
                    user.Favorite.Musics.Add(music);
                    MusicFound.CurrentCell.Value = getFav(Color.Red);
                }

            }
            else if (MusicFound.CurrentCell.ColumnIndex == 5)
            {
                MessageBox.Show("Downloaded");
            }
            else if (MusicFound.CurrentCell.ColumnIndex == 6)
            {
                AddPanel.Visible = true;
            }
            else
            {
                if (e.RowIndex > 0)
                {
                    string musicname = MusicFound.Rows[e.RowIndex].Cells[0].Value.ToString();
                    app.Musics = musicFoundPlay;
                    app.Play(musicname);
                }
            }
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPlaylistPanel.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewPlaylistPanel.BringToFront();
            NewPlaylistPanel.Visible = true;
        }
    }
}
