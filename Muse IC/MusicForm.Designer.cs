using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Reflection;

namespace Muse_IC
{
    partial class MusicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MusicPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SingerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MusicAlbumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MusicNameLabel = new System.Windows.Forms.Label();
            this.CommentsPanel = new System.Windows.Forms.Panel();
            this.NoComPan = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.CommentsLoginPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommentExemple = new System.Windows.Forms.Panel();
            this.CommentContent = new System.Windows.Forms.Label();
            this.ReplayIcon = new FontAwesome.Sharp.IconPictureBox();
            this.CommentLikes = new System.Windows.Forms.Label();
            this.LikeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.CommenterName = new System.Windows.Forms.Label();
            this.CommentDate = new System.Windows.Forms.Label();
            this.Friend1Picture = new System.Windows.Forms.PictureBox();
            this.PublishPanel = new System.Windows.Forms.Panel();
            this.SmileIcon = new FontAwesome.Sharp.IconPictureBox();
            this.AtIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Publish = new System.Windows.Forms.Button();
            this.CommentContentBox = new System.Windows.Forms.TextBox();
            this.AddTo = new FontAwesome.Sharp.IconPictureBox();
            this.ShareNumber = new System.Windows.Forms.Label();
            this.LikedNumber = new System.Windows.Forms.Label();
            this.DownloadNumber = new System.Windows.Forms.Label();
            this.LikedIcon = new FontAwesome.Sharp.IconPictureBox();
            this.DownLoadIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ShareIcon = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MusicPicture = new System.Windows.Forms.PictureBox();
            this.LrcBox = new System.Windows.Forms.ListBox();
            this.MusicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CommentsPanel.SuspendLayout();
            this.NoComPan.SuspendLayout();
            this.CommentsLoginPanel.SuspendLayout();
            this.CommentExemple.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Friend1Picture)).BeginInit();
            this.PublishPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmileIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLoadIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicPanel
            // 
            this.MusicPanel.AutoScroll = true;
            this.MusicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.MusicPanel.Controls.Add(this.iconPictureBox1);
            this.MusicPanel.Controls.Add(this.AddPanel);
            this.MusicPanel.Controls.Add(this.panel1);
            this.MusicPanel.Controls.Add(this.CommentsPanel);
            this.MusicPanel.Controls.Add(this.AddTo);
            this.MusicPanel.Controls.Add(this.ShareNumber);
            this.MusicPanel.Controls.Add(this.LikedNumber);
            this.MusicPanel.Controls.Add(this.DownloadNumber);
            this.MusicPanel.Controls.Add(this.LikedIcon);
            this.MusicPanel.Controls.Add(this.DownLoadIcon);
            this.MusicPanel.Controls.Add(this.ShareIcon);
            this.MusicPanel.Controls.Add(this.label1);
            this.MusicPanel.Controls.Add(this.MusicPicture);
            this.MusicPanel.Controls.Add(this.LrcBox);
            this.MusicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MusicPanel.Location = new System.Drawing.Point(0, 0);
            this.MusicPanel.Name = "MusicPanel";
            this.MusicPanel.Size = new System.Drawing.Size(1232, 831);
            this.MusicPanel.TabIndex = 0;
            this.MusicPanel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconPictureBox1.IconColor = System.Drawing.Color.PapayaWhip;
            this.iconPictureBox1.IconSize = 52;
            this.iconPictureBox1.Location = new System.Drawing.Point(301, 338);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(65, 52);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 49;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.iconPictureBox1.MouseLeave += new System.EventHandler(this.HoverOutColor);
            this.iconPictureBox1.MouseHover += new System.EventHandler(this.HoverColor);
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPanel.Controls.Add(this.panel3);
            this.AddPanel.Controls.Add(this.ListBox);
            this.AddPanel.Location = new System.Drawing.Point(466, 111);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(277, 356);
            this.AddPanel.TabIndex = 43;
            this.AddPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.CancelBtn);
            this.panel3.Controls.Add(this.AddBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 306);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 48);
            this.panel3.TabIndex = 43;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(177)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(173, 7);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(81, 33);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(177)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.Location = new System.Drawing.Point(17, 7);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(81, 33);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(105)))), ((int)(((byte)(134)))));
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 29;
            this.ListBox.Location = new System.Drawing.Point(10, 7);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(255, 292);
            this.ListBox.TabIndex = 42;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SingerLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MusicAlbumLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MusicNameLabel);
            this.panel1.Location = new System.Drawing.Point(528, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 88);
            this.panel1.TabIndex = 48;
            // 
            // SingerLabel
            // 
            this.SingerLabel.AutoSize = true;
            this.SingerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SingerLabel.Location = new System.Drawing.Point(429, 52);
            this.SingerLabel.Name = "SingerLabel";
            this.SingerLabel.Size = new System.Drawing.Size(62, 24);
            this.SingerLabel.TabIndex = 7;
            this.SingerLabel.Text = "album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(327, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Singer:";
            // 
            // MusicAlbumLabel
            // 
            this.MusicAlbumLabel.AutoSize = true;
            this.MusicAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicAlbumLabel.Location = new System.Drawing.Point(126, 52);
            this.MusicAlbumLabel.Name = "MusicAlbumLabel";
            this.MusicAlbumLabel.Size = new System.Drawing.Size(62, 24);
            this.MusicAlbumLabel.TabIndex = 5;
            this.MusicAlbumLabel.Text = "album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Album:";
            // 
            // MusicNameLabel
            // 
            this.MusicNameLabel.AutoSize = true;
            this.MusicNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicNameLabel.Location = new System.Drawing.Point(15, 7);
            this.MusicNameLabel.Name = "MusicNameLabel";
            this.MusicNameLabel.Size = new System.Drawing.Size(141, 29);
            this.MusicNameLabel.TabIndex = 3;
            this.MusicNameLabel.Text = "MusicName";
            // 
            // CommentsPanel
            // 
            this.CommentsPanel.AutoScroll = true;
            this.CommentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.CommentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CommentsPanel.Controls.Add(this.NoComPan);
            this.CommentsPanel.Controls.Add(this.CommentsLoginPanel);
            this.CommentsPanel.Controls.Add(this.label4);
            this.CommentsPanel.Controls.Add(this.CommentExemple);
            this.CommentsPanel.Controls.Add(this.PublishPanel);
            this.CommentsPanel.Location = new System.Drawing.Point(31, 396);
            this.CommentsPanel.Name = "CommentsPanel";
            this.CommentsPanel.Size = new System.Drawing.Size(1112, 245);
            this.CommentsPanel.TabIndex = 47;
            // 
            // NoComPan
            // 
            this.NoComPan.Controls.Add(this.label7);
            this.NoComPan.Location = new System.Drawing.Point(88, 149);
            this.NoComPan.Name = "NoComPan";
            this.NoComPan.Size = new System.Drawing.Size(993, 71);
            this.NoComPan.TabIndex = 42;
            this.NoComPan.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(348, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "No Comments Yet";
            // 
            // CommentsLoginPanel
            // 
            this.CommentsLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(164)))), ((int)(((byte)(119)))));
            this.CommentsLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentsLoginPanel.Controls.Add(this.label5);
            this.CommentsLoginPanel.Controls.Add(this.label6);
            this.CommentsLoginPanel.Location = new System.Drawing.Point(289, 24);
            this.CommentsLoginPanel.Name = "CommentsLoginPanel";
            this.CommentsLoginPanel.Size = new System.Drawing.Size(583, 73);
            this.CommentsLoginPanel.TabIndex = 10;
            this.CommentsLoginPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(485, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Login";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(58, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "If you want to leave a comment please";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(200)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 31);
            this.label4.TabIndex = 44;
            this.label4.Text = "Comments:";
            // 
            // CommentExemple
            // 
            this.CommentExemple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(147)))), ((int)(((byte)(180)))));
            this.CommentExemple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CommentExemple.Controls.Add(this.CommentContent);
            this.CommentExemple.Controls.Add(this.ReplayIcon);
            this.CommentExemple.Controls.Add(this.CommentLikes);
            this.CommentExemple.Controls.Add(this.LikeIcon);
            this.CommentExemple.Controls.Add(this.CommenterName);
            this.CommentExemple.Controls.Add(this.CommentDate);
            this.CommentExemple.Controls.Add(this.Friend1Picture);
            this.CommentExemple.Location = new System.Drawing.Point(100, 149);
            this.CommentExemple.Name = "CommentExemple";
            this.CommentExemple.Size = new System.Drawing.Size(959, 71);
            this.CommentExemple.TabIndex = 45;
            this.CommentExemple.Visible = false;
            // 
            // CommentContent
            // 
            this.CommentContent.AutoSize = true;
            this.CommentContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommentContent.Location = new System.Drawing.Point(179, 9);
            this.CommentContent.Name = "CommentContent";
            this.CommentContent.Size = new System.Drawing.Size(187, 25);
            this.CommentContent.TabIndex = 41;
            this.CommentContent.Text = "Content of comment";
            // 
            // ReplayIcon
            // 
            this.ReplayIcon.BackColor = System.Drawing.Color.Transparent;
            this.ReplayIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReplayIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ReplayIcon.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.ReplayIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.ReplayIcon.IconSize = 30;
            this.ReplayIcon.Location = new System.Drawing.Point(914, 33);
            this.ReplayIcon.Name = "ReplayIcon";
            this.ReplayIcon.Size = new System.Drawing.Size(36, 30);
            this.ReplayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ReplayIcon.TabIndex = 40;
            this.ReplayIcon.TabStop = false;
            // 
            // CommentLikes
            // 
            this.CommentLikes.AutoSize = true;
            this.CommentLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommentLikes.Location = new System.Drawing.Point(874, 38);
            this.CommentLikes.Name = "CommentLikes";
            this.CommentLikes.Size = new System.Drawing.Size(18, 20);
            this.CommentLikes.TabIndex = 39;
            this.CommentLikes.Text = "0";
            // 
            // LikeIcon
            // 
            this.LikeIcon.BackColor = System.Drawing.Color.Transparent;
            this.LikeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikeIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LikeIcon.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.LikeIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.LikeIcon.IconSize = 30;
            this.LikeIcon.Location = new System.Drawing.Point(832, 33);
            this.LikeIcon.Name = "LikeIcon";
            this.LikeIcon.Size = new System.Drawing.Size(36, 30);
            this.LikeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LikeIcon.TabIndex = 38;
            this.LikeIcon.TabStop = false;
            // 
            // CommenterName
            // 
            this.CommenterName.AutoSize = true;
            this.CommenterName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommenterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommenterName.Location = new System.Drawing.Point(73, 9);
            this.CommenterName.Name = "CommenterName";
            this.CommenterName.Size = new System.Drawing.Size(78, 25);
            this.CommenterName.TabIndex = 12;
            this.CommenterName.Text = "Friend1";
            // 
            // CommentDate
            // 
            this.CommentDate.AutoSize = true;
            this.CommentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommentDate.Location = new System.Drawing.Point(75, 39);
            this.CommentDate.Name = "CommentDate";
            this.CommentDate.Size = new System.Drawing.Size(45, 20);
            this.CommentDate.TabIndex = 11;
            this.CommentDate.Text = "Date";
            // 
            // Friend1Picture
            // 
            this.Friend1Picture.Image = global::Muse_IC.Properties.Resources.Uer;
            this.Friend1Picture.Location = new System.Drawing.Point(13, 9);
            this.Friend1Picture.Name = "Friend1Picture";
            this.Friend1Picture.Size = new System.Drawing.Size(55, 54);
            this.Friend1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Friend1Picture.TabIndex = 10;
            this.Friend1Picture.TabStop = false;
            // 
            // PublishPanel
            // 
            this.PublishPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.PublishPanel.Controls.Add(this.SmileIcon);
            this.PublishPanel.Controls.Add(this.AtIcon);
            this.PublishPanel.Controls.Add(this.Publish);
            this.PublishPanel.Controls.Add(this.CommentContentBox);
            this.PublishPanel.Location = new System.Drawing.Point(92, 43);
            this.PublishPanel.Name = "PublishPanel";
            this.PublishPanel.Size = new System.Drawing.Size(976, 100);
            this.PublishPanel.TabIndex = 46;
            // 
            // SmileIcon
            // 
            this.SmileIcon.BackColor = System.Drawing.Color.Transparent;
            this.SmileIcon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SmileIcon.IconChar = FontAwesome.Sharp.IconChar.Smile;
            this.SmileIcon.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SmileIcon.Location = new System.Drawing.Point(17, 49);
            this.SmileIcon.Name = "SmileIcon";
            this.SmileIcon.Size = new System.Drawing.Size(32, 32);
            this.SmileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SmileIcon.TabIndex = 5;
            this.SmileIcon.TabStop = false;
            // 
            // AtIcon
            // 
            this.AtIcon.BackColor = System.Drawing.Color.Transparent;
            this.AtIcon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AtIcon.IconChar = FontAwesome.Sharp.IconChar.At;
            this.AtIcon.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AtIcon.Location = new System.Drawing.Point(63, 49);
            this.AtIcon.Name = "AtIcon";
            this.AtIcon.Size = new System.Drawing.Size(32, 32);
            this.AtIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AtIcon.TabIndex = 6;
            this.AtIcon.TabStop = false;
            // 
            // Publish
            // 
            this.Publish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(177)))));
            this.Publish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Publish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Publish.Location = new System.Drawing.Point(861, 52);
            this.Publish.Name = "Publish";
            this.Publish.Size = new System.Drawing.Size(89, 29);
            this.Publish.TabIndex = 7;
            this.Publish.Text = "Publish";
            this.Publish.UseVisualStyleBackColor = false;
            this.Publish.Click += new System.EventHandler(this.Publish_Click);
            // 
            // CommentContentBox
            // 
            this.CommentContentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommentContentBox.Location = new System.Drawing.Point(8, 11);
            this.CommentContentBox.Name = "CommentContentBox";
            this.CommentContentBox.Size = new System.Drawing.Size(953, 30);
            this.CommentContentBox.TabIndex = 4;
            // 
            // AddTo
            // 
            this.AddTo.BackColor = System.Drawing.Color.Transparent;
            this.AddTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTo.ForeColor = System.Drawing.Color.PapayaWhip;
            this.AddTo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AddTo.IconColor = System.Drawing.Color.PapayaWhip;
            this.AddTo.IconSize = 46;
            this.AddTo.Location = new System.Drawing.Point(361, 338);
            this.AddTo.Name = "AddTo";
            this.AddTo.Size = new System.Drawing.Size(76, 46);
            this.AddTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddTo.TabIndex = 41;
            this.AddTo.TabStop = false;
            this.AddTo.Click += new System.EventHandler(this.AddTo_Click);
            this.AddTo.MouseLeave += new System.EventHandler(this.HoverOutColor);
            this.AddTo.MouseHover += new System.EventHandler(this.HoverColor);
            // 
            // ShareNumber
            // 
            this.ShareNumber.AutoSize = true;
            this.ShareNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ShareNumber.ForeColor = System.Drawing.Color.PapayaWhip;
            this.ShareNumber.Location = new System.Drawing.Point(56, 311);
            this.ShareNumber.Name = "ShareNumber";
            this.ShareNumber.Size = new System.Drawing.Size(23, 25);
            this.ShareNumber.TabIndex = 40;
            this.ShareNumber.Text = "0";
            // 
            // LikedNumber
            // 
            this.LikedNumber.AutoSize = true;
            this.LikedNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LikedNumber.ForeColor = System.Drawing.Color.PapayaWhip;
            this.LikedNumber.Location = new System.Drawing.Point(242, 310);
            this.LikedNumber.Name = "LikedNumber";
            this.LikedNumber.Size = new System.Drawing.Size(23, 25);
            this.LikedNumber.TabIndex = 39;
            this.LikedNumber.Text = "0";
            // 
            // DownloadNumber
            // 
            this.DownloadNumber.AutoSize = true;
            this.DownloadNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DownloadNumber.ForeColor = System.Drawing.Color.PapayaWhip;
            this.DownloadNumber.Location = new System.Drawing.Point(153, 310);
            this.DownloadNumber.Name = "DownloadNumber";
            this.DownloadNumber.Size = new System.Drawing.Size(23, 25);
            this.DownloadNumber.TabIndex = 38;
            this.DownloadNumber.Text = "0";
            // 
            // LikedIcon
            // 
            this.LikedIcon.BackColor = System.Drawing.Color.Transparent;
            this.LikedIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LikedIcon.ForeColor = System.Drawing.Color.Black;
            this.LikedIcon.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.LikedIcon.IconColor = System.Drawing.Color.Black;
            this.LikedIcon.IconSize = 52;
            this.LikedIcon.Location = new System.Drawing.Point(221, 338);
            this.LikedIcon.Name = "LikedIcon";
            this.LikedIcon.Size = new System.Drawing.Size(65, 52);
            this.LikedIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LikedIcon.TabIndex = 37;
            this.LikedIcon.TabStop = false;
            this.LikedIcon.Click += new System.EventHandler(this.LikedIcon_Click);
            // 
            // DownLoadIcon
            // 
            this.DownLoadIcon.BackColor = System.Drawing.Color.Transparent;
            this.DownLoadIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownLoadIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.DownLoadIcon.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.DownLoadIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.DownLoadIcon.IconSize = 46;
            this.DownLoadIcon.Location = new System.Drawing.Point(123, 338);
            this.DownLoadIcon.Name = "DownLoadIcon";
            this.DownLoadIcon.Size = new System.Drawing.Size(79, 46);
            this.DownLoadIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DownLoadIcon.TabIndex = 36;
            this.DownLoadIcon.TabStop = false;
            this.DownLoadIcon.Click += new System.EventHandler(this.DownLoadIcon_Click);
            this.DownLoadIcon.MouseLeave += new System.EventHandler(this.HoverOutColor);
            this.DownLoadIcon.MouseHover += new System.EventHandler(this.HoverColor);
            // 
            // ShareIcon
            // 
            this.ShareIcon.BackColor = System.Drawing.Color.Transparent;
            this.ShareIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShareIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.ShareIcon.IconChar = FontAwesome.Sharp.IconChar.ShareAlt;
            this.ShareIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.ShareIcon.IconSize = 46;
            this.ShareIcon.Location = new System.Drawing.Point(29, 338);
            this.ShareIcon.Name = "ShareIcon";
            this.ShareIcon.Size = new System.Drawing.Size(76, 46);
            this.ShareIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ShareIcon.TabIndex = 35;
            this.ShareIcon.TabStop = false;
            this.ShareIcon.Click += new System.EventHandler(this.ShareIcon_Click);
            this.ShareIcon.MouseLeave += new System.EventHandler(this.HoverOutColor);
            this.ShareIcon.MouseHover += new System.EventHandler(this.HoverColor);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(763, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lyrics";
            // 
            // MusicPicture
            // 
            this.MusicPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(147)))));
            this.MusicPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MusicPicture.Image = global::Muse_IC.Properties.Resources.Music;
            this.MusicPicture.Location = new System.Drawing.Point(105, 35);
            this.MusicPicture.Name = "MusicPicture";
            this.MusicPicture.Size = new System.Drawing.Size(319, 264);
            this.MusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MusicPicture.TabIndex = 1;
            this.MusicPicture.TabStop = false;
            // 
            // LrcBox
            // 
            this.LrcBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(170)))));
            this.LrcBox.FormattingEnabled = true;
            this.LrcBox.ItemHeight = 16;
            this.LrcBox.Location = new System.Drawing.Point(529, 126);
            this.LrcBox.Name = "LrcBox";
            this.LrcBox.Size = new System.Drawing.Size(572, 228);
            this.LrcBox.TabIndex = 0;
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 831);
            this.Controls.Add(this.MusicPanel);
            this.Name = "MusicForm";
            this.Text = "MusicForm";
            this.MusicPanel.ResumeLayout(false);
            this.MusicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CommentsPanel.ResumeLayout(false);
            this.CommentsPanel.PerformLayout();
            this.NoComPan.ResumeLayout(false);
            this.NoComPan.PerformLayout();
            this.CommentsLoginPanel.ResumeLayout(false);
            this.CommentsLoginPanel.PerformLayout();
            this.CommentExemple.ResumeLayout(false);
            this.CommentExemple.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReplayIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Friend1Picture)).EndInit();
            this.PublishPanel.ResumeLayout(false);
            this.PublishPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SmileIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AtIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLoadIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).EndInit();
            this.ResumeLayout(false);

        }

        private void HoverColor(object sender, EventArgs e)
        {
            IconPictureBox one = (IconPictureBox)sender;
            one.IconColor = Color.LavenderBlush;
        }
        private void HoverOutColor(object sender, EventArgs e)
        {
            IconPictureBox one = (IconPictureBox)sender;
            one.IconColor = Color.PapayaWhip;
        }
        



        #endregion

        private System.Windows.Forms.Panel MusicPanel;
        private System.Windows.Forms.ListBox LrcBox;
        private System.Windows.Forms.PictureBox MusicPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SingerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MusicAlbumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MusicNameLabel;
        private FontAwesome.Sharp.IconPictureBox LikedIcon;
        private FontAwesome.Sharp.IconPictureBox DownLoadIcon;
        private FontAwesome.Sharp.IconPictureBox ShareIcon;
        private FontAwesome.Sharp.IconPictureBox AddTo;
        private System.Windows.Forms.Label ShareNumber;
        private System.Windows.Forms.Label LikedNumber;
        private System.Windows.Forms.Label DownloadNumber;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PublishPanel;
        private FontAwesome.Sharp.IconPictureBox SmileIcon;
        private FontAwesome.Sharp.IconPictureBox AtIcon;
        private System.Windows.Forms.Button Publish;
        private System.Windows.Forms.TextBox CommentContentBox;
        private System.Windows.Forms.Panel CommentExemple;
        private System.Windows.Forms.Label CommentContent;
        private FontAwesome.Sharp.IconPictureBox ReplayIcon;
        private System.Windows.Forms.Label CommentLikes;
        private FontAwesome.Sharp.IconPictureBox LikeIcon;
        private System.Windows.Forms.Label CommenterName;
        private System.Windows.Forms.Label CommentDate;
        private System.Windows.Forms.PictureBox Friend1Picture;
        private System.Windows.Forms.Panel CommentsLoginPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel CommentsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel NoComPan;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}