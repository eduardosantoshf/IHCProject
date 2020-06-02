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
using FontAwesome.Sharp;
namespace Muse_IC
{
    public partial class MusicForm : Form, MyChildForm
    {
        private App app;
        private User user;
        private Music currentMusic;
        private List<Panel> comments = new List<Panel>();

        public MusicForm(App app, Music music)
        {
            this.app = app;
            this.user = app.User;
            currentMusic = music;
            String tags = "";
            foreach (String str in currentMusic.Tags)
            {
                tags += str + ", ";
            }
            

            InitializeComponent();
            TagBox.Text = tags;
            DescBox.Text = currentMusic.Description;
            InitUserInfo();
            InitComments();
        }

        public void InitUserInfo()
        {
            if (app.User.email.Equals("LocalData"))
            {
                CommentsLoginPanel.Visible = true;
                PublishPanel.Visible = false;
            }
            else
            {
                CommentsLoginPanel.Visible = false;
                PublishPanel.Visible = true;
            }

            MusicNameLabel.Text = currentMusic.Name;
            SingerLabel.Text = currentMusic.Singer;
            MusicAlbumLabel.Text = currentMusic.Album;
            ShareNumber.Text = currentMusic.Shares+"";
            DownloadNumber.Text =currentMusic.Downlod+"";
            LikedNumber.Text = currentMusic.Like+"";
            NoComPan.Visible = true;
            ListBox.Items.Clear();
            ListBox.Items.Add("Favorite");

            foreach (PlayList playList in app.User.myPlaylist)
            {
                ListBox.Items.Add(playList.PlaylistName);
            }

            if (app.User.Favorite.Musics.Exists(x => x.Name.Equals(currentMusic.Name)))
            {
                currentMusic.Like++;
                LikedNumber.Text = currentMusic.Like + "";
                LikedIcon.IconColor = Color.Red;
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
                    foreach (PlayList playList in PlayList.playLists)
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
            else
            {
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
            else if (ListBox.SelectedItems.Count == 1)
                AddBtn.Enabled = true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
        }

        private void Publish_Click(object sender, EventArgs e)
        {
            if (CommentContentBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("Comment can not be empty!");
                return;
            }
            Comment comment = new Comment();
            comment.Content = CommentContentBox.Text;
            comment.Author = app.User;
            comment.Date = DateTime.Now.ToLongDateString().ToString();
            currentMusic.Comments.Add(comment);
            CommentContentBox.Text = "";
            ClearCommentsPanel();
            InitComments();
        }


        private Panel lastComment;
        int count;
        private void InitComments()
        {
            count = 1;
            foreach (Panel innerPanel in comments)
            {
                innerPanel.Dispose();
                lastComment = null;
            }
            foreach (Comment comment in currentMusic.Comments)
            {
                NoComPan.Visible = false;
                if (lastComment == null)
                {
                    lastComment = ControlExtensions.Clone(CommentExemple);
                    lastComment.Visible = true;
                    lastComment.Name = "CommentPanel" + count;
                    PictureBox pb = new PictureBox();
                    InitUserPictureBox(pb, comment.Author);
                    IconPictureBox icon2 = new IconPictureBox();
                    icon2.BackColor = Color.Transparent;
                    InitLikeIcon(icon2);
                    IconPictureBox icon3 = new IconPictureBox();
                    icon3.BackColor = Color.Transparent;
                    InitReplyIcon(icon3);

                    Label commentername = ControlExtensions.Clone(CommenterName);
                    commentername.Text = comment.Author.Username + ":";
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

                    lastComment.Controls.Add(pb);
                    lastComment.Controls.Add(icon2);
                    lastComment.Controls.Add(icon3);
                    lastComment.Controls.Add(date);
                    lastComment.Controls.Add(likes);
                    lastComment.Controls.Add(content);
                    lastComment.Controls.Add(commentername);
                    CommentsPanel.Controls.Add(lastComment);
                    comments.Add(lastComment);
                    lastComment.Show();
                    CommentsPanel.Refresh();
                }
                else
                {
                    Panel panel = ControlExtensions.Clone(lastComment);
                    panel.Name = "CommentPanel" + count;
                    panel.Visible = true;
                    panel.Location = new Point(panel.Location.X, panel.Location.Y + 70);
                    panel.BackColor = Color.FromArgb(69, 89, 100);
                    PictureBox pb = new PictureBox();
                    InitUserPictureBox(pb, comment.Author);
                    IconPictureBox icon2 = new IconPictureBox();
                    InitLikeIcon(icon2);
                    icon2.BackColor = Color.Transparent;
                    IconPictureBox icon3 = new IconPictureBox();
                    InitReplyIcon(icon3);
                    icon3.BackColor = Color.Transparent;

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
                    comments.Add(lastComment);
                    lastComment = panel;
                }
                count++;
            }

        }
        private void InitUserPictureBox(PictureBox Picture, User author)
        {

            Picture.Image = author.Picture;

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
            iconPicture.Cursor = Cursors.Hand;
            iconPicture.ForeColor = SystemColors.ControlText;
            iconPicture.IconChar = IconChar.ThumbsUp;
            iconPicture.IconColor = SystemColors.ControlText;
            iconPicture.IconSize = 30;
            iconPicture.Location = LikeIcon.Location;
            iconPicture.Name = "icon" + count;
            iconPicture.Size = LikeIcon.Size;
            iconPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPicture.TabIndex = 48;
            iconPicture.TabStop = false;

        }

        private void InitReplyIcon(IconPictureBox iconPicture)
        {
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.user = new User();
            Login login = new Login(true);
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                this.user = User.users[login.UserNameBox.Text];
                this.app.User = this.user;
                app.InitUserInfo();
            }
            InitUserInfo();

        }

        private void LikedIcon_Click(object sender, EventArgs e)
        {
            if(LikedIcon.IconColor != Color.Red)
            {
                LikedIcon.IconColor = Color.Red;
                app.User.Favorite.Musics.Add(currentMusic);
                currentMusic.Like++;
                LikedNumber.Text = currentMusic.Like + "";
                MessageBox.Show("Music added to Favourite");
            }
            else
            {
                LikedIcon.IconColor = Color.Black;
                app.User.Favorite.Musics.Remove(currentMusic);
                currentMusic.Like--;
                LikedNumber.Text = currentMusic.Like + "";
                MessageBox.Show("Music removed From Favourite");
            }
        }

        private void ShareIcon_Click(object sender, EventArgs e)
        {
            currentMusic.Shares++;
            ShareNumber.Text = currentMusic.Shares + "";
        }

        private void DownLoadIcon_Click(object sender, EventArgs e)
        {
            currentMusic.Downlod++;
            DownloadNumber.Text = currentMusic.Downlod + "";
        }

      
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            string musicname = currentMusic.Name;
            List<Music> newList = new List<Music>();
            newList.Add(currentMusic);
            app.Musics = newList;
            app.Play(musicname);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MoreInfo.Visible = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MoreInfo.Visible = false;
        }
    }

}
