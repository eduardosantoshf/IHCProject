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
            UploadedData.ColumnCount = 5;
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

        int count = 1;
        int heartcount = 1;
        int downloadcount = 1;
        int addcount = 1;
        private Panel lastpanel;
        private void InitListView(int option)
        {
            count = 1;
            heartcount = 1;
            downloadcount = 1;
            addcount = 1;
            List<Music> list = null;
            if (option == 1)
                list = user.upMusic;
            currentUploaded = option;
            foreach (Music music in list)
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

                    MyUploadsPanel.Controls.Add(lastpanel);
                    lastpanel.Show();
                    UploadedData.SendToBack();
                    MyUploadsPanel.Refresh();
                    panels.Add(lastpanel);
                    ChangePanelColor(0);
                }
                else
                {
                    if (panels.Count < 4)
                    {
                        Panel panel = ControlExtensions.Clone(lastpanel);
                        panel.Visible = true;
                        panel.Location = new Point(panel.Location.X, panel.Location.Y + 50);
                        panel.BackColor = Color.White;
                        panel.Name = "IconPanel_" + count;
                        IconPictureBox icon1 = new IconPictureBox();
                        InitHeartIcon(icon1, music);
                        icon1.MouseClick += new MouseEventHandler(Remove);
                        IconPictureBox icon2 = new IconPictureBox();
                        InitDownloadIcon(icon2);
                        IconPictureBox icon3 = new IconPictureBox();
                        InitPlusIcon(icon3);
                        icon3.MouseClick += new MouseEventHandler(AddTo);

                        panel.Controls.Add(icon1);
                        panel.Controls.Add(icon2);
                        panel.Controls.Add(icon3);

                        MyUploadsPanel.Controls.Add(panel);
                        panel.Show();
                        UploadedData.SendToBack();
                        MyUploadsPanel.Refresh();
                        lastpanel = panel;
                        panels.Add(panel);
                    }
                }
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

        private void Remove(object o, EventArgs e)
        {
            IconPictureBox ib = (IconPictureBox)o;
            if (ib.Name.StartsWith("heart_"))
            {
                int index = int.Parse(ib.Name.Split(new char[] { '_' })[1]) - 1;
                UploadedData.Rows[index].Selected = true;
                List<Music> list = null;
                if (currentUploaded == 1)
                    list = user.upMusic;
                foreach (Music music in list)
                {
                    string name = UploadedData.Rows[index].Cells[1].Value.ToString();
                    if (music.Name.Equals(name))
                    {
                        if (ib.ForeColor == Color.Silver)
                        {
                            app.User.Favorite.Musics.Add(music);
                            ChangePanelColor(index);
                            ib.ForeColor = Color.Black;
                            MessageBox.Show("Music added!");
                        }
                        else
                        {
                            app.User.Favorite.Musics.Remove(music);
                            ChangePanelColor(index);
                            ib.ForeColor = Color.Silver;
                            MessageBox.Show("Music removed from Favorite!");
                        }
                        break;

                      /* app.User.Favorite.Musics.Remove(music);
                        MessageBox.Show("Music removed from Favorite!");
                        ClearUploaded();
                        UploadedData.Rows.Clear();
                        InitListView(currentUploaded);
                        break;*/
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
            if (user.Favorite.Musics.Contains(music))
                iconPicture.IconColor = Color.Black;
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
            foreach (Control cont in controls)
            {
                MyUploadsPanel.Controls.Remove(cont);
            }
            MyUploadsPanel.Refresh();
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

        private void UploadedData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string musicname = UploadedData.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (currentUploaded == 1)
                app.Musics = user.upMusic;
            app.Play(musicname);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string musicname = UploadedData.SelectedRows[0].Cells[1].Value.ToString();
            if (currentUploaded == 1)
                app.Musics = user.upMusic;
            app.Play(musicname);
        }
    }
}
