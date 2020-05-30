using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Muse_IC
{
    public partial class FavouriteForm : Form, MyChildForm
    {
        private App app;
        private User user;
        private List<Panel> panels;
        private Music currentMusic;

        public FavouriteForm(App app)
        {
            this.app = app;
            panels = new List<Panel>();
            InitializeComponent();
            FavouritesMusic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < FavouritesMusic.ColumnCount; i++)
            {
                FavouritesMusic.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                FavouritesMusic.Columns[i].Width = 200;
            }
            DataGridViewImageColumn imgFav = new DataGridViewImageColumn();
            

            imgFav.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgFav.Width = 35;
            imgFav.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgFav.Name = "img";
            FavouritesMusic.Columns.Add(imgFav);

            DataGridViewImageColumn imgAdd = new DataGridViewImageColumn();
            imgAdd.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgAdd.Width = 35;
            imgAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgAdd.Name = "img";
            FavouritesMusic.Columns.Add(imgAdd);

            DataGridViewImageColumn imgDown = new DataGridViewImageColumn();
            
            imgDown.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgDown.Width = 35;
            imgDown.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imgDown.Name = "img";
            FavouritesMusic.Columns.Add(imgDown);
            InitUserInfo();
        }

        private void InitPlist()
        {
            if (user.email != "LocalData")
            {
                if (user.Favorite.IsPrivate == false)
                {
                    Private.IconChar = IconChar.ToggleOff;

                }
                else
                {
                    Private.IconChar = IconChar.ToggleOn;
                    ViewsNumber.Text = user.Favorite.Views.ToString();
                    LikesNumber.Text = user.Favorite.Likes.ToString();
                    SharesNumber.Text = user.Favorite.Shares.ToString();
                    MusicNumber.Text = user.Favorite.Musics.Count.ToString();
                }
                    
            }
        }

        public void InitUserInfo()
        {
            user = app.User;
            FavouritesMusic.Rows.Clear();
            FavouritesMusic.RowTemplate.Height = 50;
            ClearMusicFound();
            if (user.email.Equals("LocalData"))
            {
                UserPanel.Visible = false;
                LoginPanel.Visible = true;
                LoginPanel.Location = UserPanel.Location;
            }
            else
            {
                UserPanel.Visible = true;
                LoginPanel.Visible = false;
                AuthorName.Text = user.Username;
                StringBuilder sb = new StringBuilder();
                if (user.Tags.Count > 0)
                {
                    foreach (string str in user.Tags)
                    {
                        sb.Append("#").Append(str).Append(" ");
                    }
                    Tag.Text = sb.ToString();
                }else
                    Tag.Text = "";
                UserPicture.Image = user.Picture;
                
            }

            InitPlist();
            InitListView();
        }

        private void Private_Click(object sender, EventArgs e)
        {
            if (Private.IconChar == IconChar.ToggleOn)
            {
                Private.IconChar = IconChar.ToggleOff;
                user.Favorite.IsPrivate = false;
            }

            else
            {
                Private.IconChar = IconChar.ToggleOn;
                user.Favorite.IsPrivate = true;
            }
                
        }

        private Panel lastpanel = null;
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
            FavouritesMusic.CellBorderStyle = DataGridViewCellBorderStyle.None;
            MusicNumber.Text = user.Favorite.Musics.Count.ToString();
            List<Music> favorites;
            if (user.email.Equals("LocalData"))
                favorites = Favourite.favourite.Musics;
            else
                favorites = user.Favorite.Musics;


            Image imageFav = getFav(Color.Red);
            Image imageAdd = Image.FromFile(@"..\\..\\Resources\\Add.png");
            Image imageDown = Image.FromFile(@"..\\..\\Resources\\Down.png");

            foreach (Music music in favorites)
            {
                object[] row =
                {
                    music.Name,
                    music.Singer,
                    music.Album,
                    music.Duration,
                    imageFav,
                    imageDown,
                    imageAdd
                };
                FavouritesMusic.Rows.Add(row);
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
        private void AddTo(object o,EventArgs e)
        {
            IconPictureBox ib = (IconPictureBox) o;
            if (ib.Name.StartsWith("add_"))
            {
                int index = int.Parse(ib.Name.Split(new char[] { '_'})[1])-1;
                FavouritesMusic.Rows[index].Selected = true;
                foreach(Music music in app.User.Favorite.Musics)
                {
                    string name = FavouritesMusic.Rows[index].Cells[1].Value.ToString();
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

        private void InitHeartIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor =SystemColors.ButtonHighlight;
            iconPicture.Cursor =Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Heart;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.IconColor = Color.Red;
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

        private void GoLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(true);
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                user = User.users[login.UserNameBox.Text];
                app.User = user;
                FavouritesMusic.Rows.Clear();
                ClearMusicFound();
                InitUserInfo();
                app.InitUserInfo();
                InitListView();
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
        private void FavouritesMusic_SelectionChanged(object sender, EventArgs e)
        {
            int index = FavouritesMusic.CurrentRow.Index;
            ChangePanelColor(index);
        }

        private void FavouritesMusic_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    FavouritesMusic.Rows[e.RowIndex].Selected = true;
                    ChangePanelColor(e.RowIndex);
                    FavouritesContexMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void PlayThisMusic_Click(object sender, EventArgs e)
        {
            string musicname = FavouritesMusic.SelectedRows[0].Cells[1].Value.ToString();
            if (app.User.email.Equals("LocalData"))
                app.Musics = Favourite.favourite.Musics;
            else
                app.Musics = app.User.Favorite.Musics;
            app.Play(musicname);
        }

        private void FavouritesMusic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Music music = new Music();
            foreach (Music m in app.Musics)
            {
                if (FavouritesMusic.CurrentRow.Cells[0].Value.ToString() == m.Name)
                {
                    music = m;
                    break;
                }
            }


            if (FavouritesMusic.CurrentCell.ColumnIndex == 4)
            {
                if (user.Favorite.Musics.Contains(music))
                {
                    user.Favorite.Musics.Remove(music);
                    FavouritesMusic.CurrentCell.Value = getFav(Color.Silver);
                }


                else
                {
                    user.Favorite.Musics.Add(music);
                    FavouritesMusic.CurrentCell.Value = getFav(Color.Red);
                }
                ClearMusicFound();
                FavouritesMusic.Rows.Clear();
                InitListView();

            }
            else if (FavouritesMusic.CurrentCell.ColumnIndex == 5)
            {
                MessageBox.Show("Downloaded");
            }
            else if (FavouritesMusic.CurrentCell.ColumnIndex == 6)
            {
                MessageBox.Show("Adding");
                ListBox.Visible = true;
                ListBox.Enabled = true;
                ListBox.Show();
            }
            else
            {
                string musicname = FavouritesMusic.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (app.User.email.Equals("LocalData"))
                    app.Musics = Favourite.favourite.Musics;
                else
                    app.Musics = app.User.Favorite.Musics;
                app.Play(musicname);
            }
            FavouritesMusic.Refresh();
            
        }

        private void ClearMusicFound()
        {
            List<Control> controls = new List<Control>();
            panels = new List<Panel>();
            foreach (Control control in MyFavoritePanel.Controls)
            {
                if (control.Name.StartsWith("IconPanel"))
                {
                    controls.Add(control);
                }
            }
            foreach (Control cont in controls)
            {
                MyFavoritePanel.Controls.Remove(cont);
            }
            MyFavoritePanel.Refresh();
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

        private void FavouritesMusic_Sorted(object sender, EventArgs e)
        {
            int index = FavouritesMusic.CurrentRow.Index;
            ChangePanelColor(index);
        }
    }

    public static class ControlExtensions
    {
        public static T Clone<T>(this T controlToClone)
            where T : Control
        {
            PropertyInfo[] controlProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            T instance = Activator.CreateInstance<T>();

            foreach (PropertyInfo propInfo in controlProperties)
            {
                if (propInfo.CanWrite)
                {
                    if (propInfo.Name != "WindowTarget")
                        propInfo.SetValue(instance, propInfo.GetValue(controlToClone, null), null);
                }
            }

            return instance;
        }

    }
   
}
