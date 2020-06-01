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
    public partial class myUploads : Form
    {
        App app;
        User user;
        List<Panel> panels;
        Music currentMusic;
        int currentUploaded;
        public myUploads(App _app)
        {
            app = _app;
            user = app.User;
            panels = new List<Panel>();
            InitializeComponent();
            AddPanel.BringToFront();
            UploadedData.CellBorderStyle = DataGridViewCellBorderStyle.None;
            UploadedData.RowTemplate.Height = 50;
            
            UploadedData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InitListView(1);
            InitUserInfo();
        }
        public void InitUserInfo()
        {
            UserPicture.Image = user.Picture;
            UserName.Text = user.Name;
            UserBirthday.Text = user.Birthday.ToShortDateString();
            UserBio.Text = user.Bio;
            StringBuilder sb = new StringBuilder();
            foreach (string str in user.Tags)
            {
                sb.Append("#").Append(str).Append(" ");
            }
            UserTags.Text = sb.ToString();
        }

        
        private void InitListView(int option)
        {
            
            List<Music> list = null;
            if (option == 1)
                list = user.upMusic;
            currentUploaded = option;
            DataGridViewImageColumn imgFav = new DataGridViewImageColumn();
            Image imageFav = getFav(Color.Silver);

            imgFav.ImageLayout = DataGridViewImageCellLayout.Zoom;

            imgFav.Name = "img";
            imgFav.Width = 35;
            imgFav.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            UploadedData.Columns.Add(imgFav);

            DataGridViewImageColumn imgAdd = new DataGridViewImageColumn();
            Image imageAdd = Image.FromFile(@"..\\..\\Resources\\Add.png");
            imgAdd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgAdd.Width = 35;
            imgAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgAdd.Name = "img";
            UploadedData.Columns.Add(imgAdd);

            DataGridViewImageColumn imgDown = new DataGridViewImageColumn();
            Image imageDown = Image.FromFile(@"..\\..\\Resources\\Down.png");
            imgDown.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgDown.Width = 35;
            imgDown.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgDown.Name = "img";
            UploadedData.Columns.Add(imgDown);


            DataGridViewImageColumn imgGo = new DataGridViewImageColumn();
            Image goCheck = Image.FromFile(@"..\\..\\Resources\\GoCheck.png");
            
            imgGo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgGo.Width = 35;
            imgGo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgGo.Name = "img";
            imgGo.HeaderText = "";
            UploadedData.Columns.Add(imgGo);


            foreach (Music music in list)
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
               
                UploadedData.Rows.Add(row);
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
                UploadedData.Rows[index].Selected = true;
                foreach (Music music in Music.musicsList)
                {
                    string name = UploadedData.Rows[index].Cells[1].Value.ToString();
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

        private void ClearUploaded()
        {
            List<Control> controls = new List<Control>();
            panels = new List<Panel>();
            foreach (Control control in MyUploadsPanel.Controls)
            {
                if (control.Name.StartsWith("IconPanel"))
                {
                    controls.Add(control);
                }
            }
            UploadedData.Columns.RemoveAt(7);
            UploadedData.Columns.RemoveAt(6);
            UploadedData.Columns.RemoveAt(5);
            UploadedData.Columns.RemoveAt(4);

            foreach (Control cont in controls)
            {
                MyUploadsPanel.Controls.Remove(cont);
            }
            MyUploadsPanel.Refresh();

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

        private void UploadedMusics_Click(object sender, EventArgs e)
        {
            ClearUploaded();
            UploadedData.Rows.Clear();
            InitListView(1);
        }

        private void UploadedData_SelectionChanged(object sender, EventArgs e)
        {
            int index = UploadedData.CurrentRow.Index;
            ChangePanelColor(index);
        }


        private void UploadedData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    UploadedData.Rows[e.RowIndex].Selected = true;
                    ChangePanelColor(e.RowIndex);
                    UploadedContexMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void UploadedData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Music music = new Music();
            foreach (Music m in app.Musics)
            {
                if (UploadedData.CurrentRow.Cells[0].Value.ToString() == m.Name)
                {
                    music = m;
                    currentMusic = m;
                    break;
                }
            }
            if (UploadedData.CurrentCell.ColumnIndex == 7)
            {
                
                app.OpenChildForm(new MusicForm(app, music));
            }

            else if (UploadedData.CurrentCell.ColumnIndex == 4)
            {
                if (user.Favorite.Musics.Contains(music))
                {
                    user.Favorite.Musics.Remove(music);
                    UploadedData.CurrentCell.Value = getFav(Color.Silver);
                }


                else
                {
                    user.Favorite.Musics.Add(music);
                    UploadedData.CurrentCell.Value = getFav(Color.Red);
                }

            }
            else if (UploadedData.CurrentCell.ColumnIndex == 5)
            {
                MessageBox.Show("Downloaded");
            }
            else if (UploadedData.CurrentCell.ColumnIndex == 6)
            {
                AddPanel.Visible = true;
                AddPanel.Enabled = true;
                AddPanel.Show();
            }
            else
            {

                string musicname = UploadedData.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (currentUploaded == 1)
                    app.Musics = user.upMusic;
                app.Play(musicname);
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string musicname = UploadedData.SelectedRows[0].Cells[0].Value.ToString();
            if (currentUploaded == 1)
                app.Musics = user.upMusic;
            app.Play(musicname);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NewPlaylistPanel.Visible = true;
            NewPlaylistPanel.BringToFront();
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

        private void button3_Click(object sender, EventArgs e)
        {
            NewPlaylistPanel.Visible = false;
        }
    }
}
