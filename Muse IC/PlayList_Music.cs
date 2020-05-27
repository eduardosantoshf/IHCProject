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
    public partial class PlayList_Music : Form,MyChildForm
    {
        private List<Panel> panels;
        private User user;
        private App app;
        private PlayList playList;
        private string playlistname;
        private Music currentMusic;
        public PlayList_Music(string playlistname, App app)
        {
            this.app = app;
            this.playlistname = playlistname;
            panels = new List<Panel>();
            InitializeComponent();
            MusicPanel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MusicPanel.RowTemplate.Height = 30;
            InitUserInfo();
        }
        public void InitUserInfo()
        {
            user = app.User;
            MusicPanel.Rows.Clear();
            if (user.email.Equals("LocalData"))
            {
                UserPanel.Visible = false;
                LoginPanel.Visible = true;
                LoginPanel.Location = UserPanel.Location;
                Private.Visible = false;
                PrivateLabel.Visible = false;
                PublishPanel.Visible = false;
                foreach (PlayList playList in PlayList.playLists)
                {
                    if (playList.PlaylistName.Equals(playlistname))
                    {
                        this.playList = playList;
                        break;
                    }
                }
            }
            else
            {
                foreach (PlayList playList in user.myPlaylist)
                {
                    if (playList.PlaylistName.Equals(playlistname))
                    {
                        this.playList = playList;
                        break;
                    }
                }
                UserPanel.Visible = true;
                LoginPanel.Visible = false;
                Private.Visible = true;
                PrivateLabel.Visible = true;
                PublishPanel.Visible = true;
                AuthorName.Text = user.Username;
                StringBuilder sb = new StringBuilder();
                foreach (string str in user.Tags)
                {
                    sb.Append("#").Append(str).Append(" ");
                }
                Tag.Text = sb.ToString();
                UserPicture.Image = user.Picture;
                CommentsLoginPanel.Visible = false;
            }

            InitPlayListInfo();
            InitListView();
        }

        private void InitPlayListInfo()
        {
            PlayListPicture.Image = playList.Image;
            PlayListName.Text = playList.PlaylistName;
            MusicNumber.Text = playList.Musics.Count+"";
            ViewsNumber.Text = playList.Views + "";
            Private.IconChar = playList.IsPrivate ? IconChar.ToggleOff : IconChar.ToggleOn ;
        }

        private Panel lastpanel = null;

        int count = 1;
        int heartcount = 1;
        int addcount = 1;
        private void InitListView()
        {
            count = 1;
            heartcount = 1;
            addcount = 1;
            MusicPanel.CellBorderStyle = DataGridViewCellBorderStyle.None;
            MusicPanel.RowTemplate.Height = 50;
            ClearPlayListPanel();
            ListBox.Items.Clear();
            foreach (Music music in playList.Musics)
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
                    lastpanel.Name = "lastpanel_" + count;

                    IconPictureBox icon1 = new IconPictureBox();
                    InitHeartIcon(icon1,music);
                    icon1.MouseClick += new MouseEventHandler(Like);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitDownloadIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    InitPlusIcon(icon3);
                    icon3.MouseClick += new MouseEventHandler(AddTo);


                    lastpanel.Controls.Add(icon1);
                    lastpanel.Controls.Add(icon2);
                    lastpanel.Controls.Add(icon3);
                    PlaylistPanel.Controls.Add(lastpanel);
                    lastpanel.Show();
                    MusicPanel.SendToBack();
                    PlaylistPanel.Refresh();
                    panels.Add(lastpanel);
                }
                else
                {
                    Panel panel = ControlExtensions.Clone(lastpanel);
                    panel.Visible = true;
                    panel.Location = new Point(panel.Location.X, panel.Location.Y + 50);
                    panel.BackColor = Color.White;
                    panel.Name = "lastpanel_" + count;

                    IconPictureBox icon1 = new IconPictureBox();
                    InitHeartIcon(icon1,music);
                    icon1.MouseClick += new MouseEventHandler(Like);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitDownloadIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    InitPlusIcon(icon3);
                    icon3.MouseClick += new MouseEventHandler(AddTo);


                    panel.Controls.Add(icon1);
                    panel.Controls.Add(icon2);
                    panel.Controls.Add(icon3);

                    PlaylistPanel.Controls.Add(panel);
                    panel.Show();
                    MusicPanel.SendToBack();
                    PlaylistPanel.Refresh();
                    lastpanel = panel;
                    panels.Add(panel);
                }
                MusicPanel.Rows.Add(row);
            }
            ListBox.Items.Clear();
            foreach (PlayList playList in app.User.myPlaylist)
            {
                if (playList.PlaylistName.Equals(PlayListName.Text))
                    continue;
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
        private void InitHeartIcon(IconPictureBox iconPicture,Music music)
        {
            iconPicture.BackColor = SystemColors.ButtonHighlight;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Heart;
            if(user.Favorite.Musics.Contains(music))
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
            iconPicture.Name = "icon"+count;
            iconPicture.Size = new Size(27, 27);
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;
            count++;
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
        private void InitUserPictureBox(PictureBox Picture,User author)
        {
            
            Picture.Image = author.Picture;
            
            Picture.BackColor = SystemColors.ButtonHighlight;
            Picture.Cursor = Cursors.Hand;
            Picture.ForeColor = SystemColors.ControlText;
            Picture.Location = Friend1Picture.Location;
            Picture.Name = "Picture" + count;
            Picture.Size = Friend1Picture.Size;
            Picture.SizeMode = PictureBoxSizeMode.Zoom;
            Picture.TabIndex = 48;
            Picture.TabStop = false;
            count++;
        }

        private void InitLikeIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor = SystemColors.ButtonHighlight;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.ThumbsUp;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = LikeIcon.Location;
            iconPicture.Name = "icon"+count;
            iconPicture.Size = LikeIcon.Size;
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;
            heartcount++;
        }

        private void InitReplyIcon(IconPictureBox iconPicture)
        {
            iconPicture.BackColor = SystemColors.ButtonHighlight;
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.Reply;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = ReplayIcon.Location;
            iconPicture.Name = "icon" + count;
            iconPicture.Size = ReplayIcon.Size;
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;
            count++;
        }
        private void GoLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(true);
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                app.User = User.users[login.UserNameBox.Text];
                InitUserInfo();
                app.InitUserInfo();
                CommentsLoginPanel.Visible = false;
            }
        }
        private void ClearPlayListPanel()
        {
            List<Control> controls = new List<Control>();
            panels = new List<Panel>();
            foreach (Control control in PlaylistPanel.Controls)
            {
                if (control.Name.Equals("lastpanel_"))
                    controls.Add(control);
            }
            foreach (Control cont in controls)
            {
                PlaylistPanel.Controls.Remove(cont);
            }
            PlaylistPanel.Refresh();
            lastpanel = null;
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
            int index = MusicPanel.CurrentRow.Index;
            ChangePanelColor(index);
        }

        private void FavouritesMusic_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    MusicPanel.Rows[e.RowIndex].Selected = true;
                    ChangePanelColor(e.RowIndex);
                    PlayListContextMenu.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void PlayThisMusic_Click(object sender, EventArgs e)
        {
            string musicname = MusicPanel.SelectedRows[0].Cells[1].Value.ToString();
            app.Musics = playList.Musics;
            app.Play(musicname);
        }

        private void FavouritesMusic_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string musicname = MusicPanel.Rows[e.RowIndex].Cells[1].Value.ToString();
            app.Musics = playList.Musics;
            app.Play(musicname);
        }

        private void MusicBtn_Click(object sender, EventArgs e)
        {
            MusicPanel.Visible = true;
            CommentsPanel.Visible = false;
            CommentsLoginPanel.Visible = false;
        }


        private Panel lastComment;
        private void InitComments()
        {
            foreach(Comment comment in playList.Comments)
            {
                if (lastComment == null)
                {
                    lastComment = ControlExtensions.Clone(CommentExemple);
                    lastComment.Visible = true;
                    lastComment.Name = "CommentPanel" + count;
                    PictureBox pb = new PictureBox();
                    InitUserPictureBox(pb,comment.Author);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitLikeIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    InitReplyIcon(icon3);

                    Label commentername = ControlExtensions.Clone(CommenterName);
                    commentername.Text = comment.Author.Username +":";
                    commentername.Visible = true;

                    Label content = ControlExtensions.Clone(CommentContent);
                    content.Text = comment.Content;
                    content.Visible = true;

                    Label date = ControlExtensions.Clone(CommentDate);
                    date.Text = comment.Date;
                    date.Visible = true;

                    Label likes = ControlExtensions.Clone(CommentLikes);
                    likes.Text = comment.Likes+"";
                    likes.Visible = true;

                    lastComment.Controls.Add(pb);
                    lastComment.Controls.Add(icon2);
                    lastComment.Controls.Add(icon3);
                    lastComment.Controls.Add(date);
                    lastComment.Controls.Add(likes);
                    lastComment.Controls.Add(content);
                    lastComment.Controls.Add(commentername);
                    CommentsPanel.Controls.Add(lastComment);
                    lastComment.Show();
                    CommentsPanel.Refresh();
                }
                else
                {
                    Panel panel = ControlExtensions.Clone(lastComment);
                    panel.Name= "CommentPanel" + count;
                    panel.Visible = true;
                    panel.Location = new Point(panel.Location.X, panel.Location.Y + 65);
                    panel.BackColor = Color.White;
                    PictureBox pb = new PictureBox();
                    InitUserPictureBox(pb,comment.Author);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitLikeIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    InitReplyIcon(icon3);

                    Label commentername = ControlExtensions.Clone(CommenterName);
                    commentername.Text = comment.Author.Name + ":";
                    commentername.Visible = true;

                    Label content = ControlExtensions.Clone(CommentContent);
                    content.Text = comment.Content;
                    content.Visible = true;

                    Label date = ControlExtensions.Clone(CommentDate);
                    date.Text = comment.Date;
                    date.Visible = true;

                    Label likes = ControlExtensions.Clone(CommentLikes);
                    likes.Text = comment.Likes + "";
                    likes.Visible = true;

                    panel.Controls.Add(pb);
                    panel.Controls.Add(icon2);
                    panel.Controls.Add(icon3);
                    panel.Controls.Add(date);
                    panel.Controls.Add(likes);
                    panel.Controls.Add(content);
                    panel.Controls.Add(commentername);
                    CommentsPanel.Controls.Add(lastComment);
                    panel.Show();
                    CommentsPanel.Refresh();
                    lastComment = panel;
                }
                count++;
            }

        }
        private void CommentsBtn_Click(object sender, EventArgs e)
        {
            InitComments();
            MusicPanel.Visible = false;
            CommentsLoginPanel.Visible = true;
            CommentsPanel.Visible = true;
            CommentsPanel.Location = MusicPanel.Location;
            if (user.email.Equals("LocalData"))
            {
                CommentsLoginPanel.Visible = true;
                PublishPanel.Visible = false;
            }
            else
            {
                CommentsLoginPanel.Visible = false;
                PublishPanel.Visible = true;
            }
        }

        private void Publish_Click(object sender, EventArgs e)
        {
            if (CommentContent.Text.Trim().Length < 1)
            {
                MessageBox.Show("Comment can not be empty!");
                return;
            }
            Comment comment = new Comment();
            comment.Content = CommentContentBox.Text;
            comment.Author = app.User;
            comment.Date= DateTime.Now.ToLongDateString().ToString();
            playList.Comments.Add(comment);
            lastComment = null;
            ClearCommentsPanel();
            InitComments();
        }

        private void ClearCommentsPanel()
        {
            List<Control> controls = new List<Control>();
            foreach (Control control in CommentsPanel.Controls)
            {
                if (control.Name.StartsWith("CommentPanel"))
                {
                    controls.Add(control);
                }
            }
            foreach (Control cont in controls)
            {
                CommentsPanel.Controls.Remove(cont);
            }
            CommentsPanel.Refresh();
        }
        private void AddTo(object o, EventArgs e)
        {
            IconPictureBox ib = (IconPictureBox)o;
            if (ib.Name.StartsWith("add_"))
            {
                int index = int.Parse(ib.Name.Split(new char[] { '_' })[1]) - 1;
                MusicPanel.Rows[index].Selected = true;
                foreach (Music music in app.User.Favorite.Musics)
                {
                    string name = MusicPanel.Rows[index].Cells[1].Value.ToString();
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
        private void Like(object o, EventArgs e)
        {
            IconPictureBox ib = (IconPictureBox)o;
            if (ib.Name.StartsWith("heart_"))
            {
                int index = int.Parse(ib.Name.Split(new char[] { '_' })[1])-1;
                MusicPanel.Rows[index].Selected = true;
                foreach (Music music in playList.Musics)
                {
                    string name = MusicPanel.Rows[index].Cells[1].Value.ToString();
                    if (music.Name.Equals(name))
                    {
                        if (ib.ForeColor == Color.Silver)
                        {
                            app.User.Favorite.Musics.Add(music);
                            ib.ForeColor = Color.Black;
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
        private void PrivateIcon_Click(object sender, EventArgs e)
        {
            if (Private.IconChar == IconChar.ToggleOn)
                Private.IconChar = IconChar.ToggleOff;
            else
                Private.IconChar = IconChar.ToggleOn;
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void MusicPanel_Sorted(object sender, EventArgs e)
        {
            int index = MusicPanel.CurrentRow.Index;
            ChangePanelColor(index);
        }
    }
}
