namespace Muse_IC
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NextIcon = new FontAwesome.Sharp.IconPictureBox();
            this.PlayIcon = new FontAwesome.Sharp.IconPictureBox();
            this.PreviousIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.UploadBtn = new FontAwesome.Sharp.IconButton();
            this.MySongBtn = new FontAwesome.Sharp.IconButton();
            this.PlayListBtn = new FontAwesome.Sharp.IconButton();
            this.FavouriteBtn = new FontAwesome.Sharp.IconButton();
            this.FriendsBtn = new FontAwesome.Sharp.IconButton();
            this.FindBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Singer = new System.Windows.Forms.Label();
            this.MusicName = new System.Windows.Forms.Label();
            this.MusicPicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EnvelopeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.UserName = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.LognOutIcon = new FontAwesome.Sharp.IconPictureBox();
            this.CurrentName = new System.Windows.Forms.Label();
            this.CurrentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.HistoryIcon = new FontAwesome.Sharp.IconPictureBox();
            this.ModeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.VolumeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Help = new System.Windows.Forms.Label();
            this.Library = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.TimeRight = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousIcon)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnvelopeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LognOutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIcon)).BeginInit();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeIcon)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.NextIcon);
            this.panel1.Controls.Add(this.PlayIcon);
            this.panel1.Controls.Add(this.PreviousIcon);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.UploadBtn);
            this.panel1.Controls.Add(this.MySongBtn);
            this.panel1.Controls.Add(this.PlayListBtn);
            this.panel1.Controls.Add(this.FavouriteBtn);
            this.panel1.Controls.Add(this.FriendsBtn);
            this.panel1.Controls.Add(this.FindBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 789);
            this.panel1.TabIndex = 0;
            // 
            // NextIcon
            // 
            this.NextIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NextIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.NextIcon.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.NextIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.NextIcon.IconSize = 50;
            this.NextIcon.Location = new System.Drawing.Point(172, 707);
            this.NextIcon.Name = "NextIcon";
            this.NextIcon.Size = new System.Drawing.Size(71, 50);
            this.NextIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NextIcon.TabIndex = 30;
            this.NextIcon.TabStop = false;
            this.NextIcon.Click += new System.EventHandler(this.NextIcon_Click);
            this.NextIcon.MouseEnter += new System.EventHandler(this.NextIcon_MouseEnter);
            this.NextIcon.MouseLeave += new System.EventHandler(this.NextIcon_MouseLeave);
            // 
            // PlayIcon
            // 
            this.PlayIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PlayIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PlayIcon.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.PlayIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.PlayIcon.IconSize = 59;
            this.PlayIcon.Location = new System.Drawing.Point(91, 704);
            this.PlayIcon.Name = "PlayIcon";
            this.PlayIcon.Size = new System.Drawing.Size(75, 59);
            this.PlayIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PlayIcon.TabIndex = 29;
            this.PlayIcon.TabStop = false;
            this.PlayIcon.Click += new System.EventHandler(this.PlayIcon_Click);
            this.PlayIcon.MouseEnter += new System.EventHandler(this.PlayIcon_MouseEnter);
            this.PlayIcon.MouseLeave += new System.EventHandler(this.PlayIcon_MouseLeave);
            // 
            // PreviousIcon
            // 
            this.PreviousIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PreviousIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PreviousIcon.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.PreviousIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.PreviousIcon.IconSize = 53;
            this.PreviousIcon.Location = new System.Drawing.Point(22, 704);
            this.PreviousIcon.Name = "PreviousIcon";
            this.PreviousIcon.Size = new System.Drawing.Size(65, 53);
            this.PreviousIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviousIcon.TabIndex = 28;
            this.PreviousIcon.TabStop = false;
            this.PreviousIcon.Click += new System.EventHandler(this.PreviousIcon_Click);
            this.PreviousIcon.MouseEnter += new System.EventHandler(this.PreviousIcon_MouseEnter);
            this.PreviousIcon.MouseLeave += new System.EventHandler(this.PreviousIcon_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 43);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 26);
            this.textBox1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.PapayaWhip;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(232, 6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 29);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UploadBtn.FlatAppearance.BorderSize = 0;
            this.UploadBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.UploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.UploadBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.UploadBtn.IconColor = System.Drawing.Color.PapayaWhip;
            this.UploadBtn.IconSize = 40;
            this.UploadBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UploadBtn.Location = new System.Drawing.Point(-1, 496);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UploadBtn.Rotation = 0D;
            this.UploadBtn.Size = new System.Drawing.Size(262, 68);
            this.UploadBtn.TabIndex = 27;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // MySongBtn
            // 
            this.MySongBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MySongBtn.FlatAppearance.BorderSize = 0;
            this.MySongBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MySongBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MySongBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.MySongBtn.IconChar = FontAwesome.Sharp.IconChar.Microphone;
            this.MySongBtn.IconColor = System.Drawing.Color.PapayaWhip;
            this.MySongBtn.IconSize = 40;
            this.MySongBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MySongBtn.Location = new System.Drawing.Point(-1, 409);
            this.MySongBtn.Name = "MySongBtn";
            this.MySongBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.MySongBtn.Rotation = 0D;
            this.MySongBtn.Size = new System.Drawing.Size(262, 67);
            this.MySongBtn.TabIndex = 26;
            this.MySongBtn.Text = "MyUploads";
            this.MySongBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MySongBtn.UseVisualStyleBackColor = false;
            this.MySongBtn.Click += new System.EventHandler(this.MySongBtn_Click);
            // 
            // PlayListBtn
            // 
            this.PlayListBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PlayListBtn.FlatAppearance.BorderSize = 0;
            this.PlayListBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PlayListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayListBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PlayListBtn.IconChar = FontAwesome.Sharp.IconChar.List;
            this.PlayListBtn.IconColor = System.Drawing.Color.PapayaWhip;
            this.PlayListBtn.IconSize = 40;
            this.PlayListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayListBtn.Location = new System.Drawing.Point(-1, 319);
            this.PlayListBtn.Name = "PlayListBtn";
            this.PlayListBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PlayListBtn.Rotation = 0D;
            this.PlayListBtn.Size = new System.Drawing.Size(262, 62);
            this.PlayListBtn.TabIndex = 25;
            this.PlayListBtn.Text = "MyPlaylists/Podcasts";
            this.PlayListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayListBtn.UseVisualStyleBackColor = false;
            this.PlayListBtn.Click += new System.EventHandler(this.PlayListBtn_Click);
            // 
            // FavouriteBtn
            // 
            this.FavouriteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FavouriteBtn.FlatAppearance.BorderSize = 0;
            this.FavouriteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.FavouriteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FavouriteBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.FavouriteBtn.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.FavouriteBtn.IconColor = System.Drawing.Color.PapayaWhip;
            this.FavouriteBtn.IconSize = 40;
            this.FavouriteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavouriteBtn.Location = new System.Drawing.Point(-1, 235);
            this.FavouriteBtn.Name = "FavouriteBtn";
            this.FavouriteBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FavouriteBtn.Rotation = 0D;
            this.FavouriteBtn.Size = new System.Drawing.Size(262, 62);
            this.FavouriteBtn.TabIndex = 24;
            this.FavouriteBtn.Text = "Favourites";
            this.FavouriteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FavouriteBtn.UseVisualStyleBackColor = false;
            this.FavouriteBtn.Click += new System.EventHandler(this.FavouriteBtn_Click);
            // 
            // FriendsBtn
            // 
            this.FriendsBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FriendsBtn.FlatAppearance.BorderSize = 0;
            this.FriendsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.FriendsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FriendsBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.FriendsBtn.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.FriendsBtn.IconColor = System.Drawing.Color.PapayaWhip;
            this.FriendsBtn.IconSize = 40;
            this.FriendsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FriendsBtn.Location = new System.Drawing.Point(0, 144);
            this.FriendsBtn.Name = "FriendsBtn";
            this.FriendsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FriendsBtn.Rotation = 0D;
            this.FriendsBtn.Size = new System.Drawing.Size(261, 62);
            this.FriendsBtn.TabIndex = 23;
            this.FriendsBtn.Text = "Friends";
            this.FriendsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FriendsBtn.UseVisualStyleBackColor = false;
            this.FriendsBtn.Click += new System.EventHandler(this.FriendsBtn_Click_1);
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.FindBtn.FlatAppearance.BorderSize = 0;
            this.FindBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindBtn.ForeColor = System.Drawing.Color.PapayaWhip;
            this.FindBtn.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.FindBtn.IconColor = System.Drawing.Color.PapayaWhip;
            this.FindBtn.IconSize = 40;
            this.FindBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindBtn.Location = new System.Drawing.Point(-1, 59);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FindBtn.Rotation = 0D;
            this.FindBtn.Size = new System.Drawing.Size(262, 62);
            this.FindBtn.TabIndex = 22;
            this.FindBtn.Text = "Find";
            this.FindBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Singer);
            this.panel2.Controls.Add(this.MusicName);
            this.panel2.Controls.Add(this.MusicPicture);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(3, 589);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 109);
            this.panel2.TabIndex = 13;
            this.panel2.Click += new System.EventHandler(this.CurrentMusicPanel_Click);
            // 
            // Singer
            // 
            this.Singer.AutoSize = true;
            this.Singer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Singer.Location = new System.Drawing.Point(103, 47);
            this.Singer.Name = "Singer";
            this.Singer.Size = new System.Drawing.Size(90, 18);
            this.Singer.TabIndex = 2;
            this.Singer.Text = "SingerName";
            this.Singer.Click += new System.EventHandler(this.CurrentMusicPanel_Click);
            // 
            // MusicName
            // 
            this.MusicName.AutoSize = true;
            this.MusicName.Location = new System.Drawing.Point(102, 18);
            this.MusicName.Name = "MusicName";
            this.MusicName.Size = new System.Drawing.Size(98, 20);
            this.MusicName.TabIndex = 1;
            this.MusicName.Text = "MusicName";
            this.MusicName.Click += new System.EventHandler(this.CurrentMusicPanel_Click);
            // 
            // MusicPicture
            // 
            this.MusicPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicPicture.Image = global::Muse_IC.Properties.Resources.Music;
            this.MusicPicture.Location = new System.Drawing.Point(3, 6);
            this.MusicPicture.Name = "MusicPicture";
            this.MusicPicture.Size = new System.Drawing.Size(93, 96);
            this.MusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MusicPicture.TabIndex = 0;
            this.MusicPicture.TabStop = false;
            this.MusicPicture.Click += new System.EventHandler(this.CurrentMusicPanel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LoginLabel);
            this.panel3.Controls.Add(this.EnvelopeIcon);
            this.panel3.Controls.Add(this.UserName);
            this.panel3.Controls.Add(this.UserPicture);
            this.panel3.Controls.Add(this.LognOutIcon);
            this.panel3.Controls.Add(this.CurrentName);
            this.panel3.Controls.Add(this.CurrentIcon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(261, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 43);
            this.panel3.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginLabel.ForeColor = System.Drawing.Color.PapayaWhip;
            this.LoginLabel.Location = new System.Drawing.Point(746, 6);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(60, 25);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.Visible = false;
            this.LoginLabel.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // EnvelopeIcon
            // 
            this.EnvelopeIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EnvelopeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnvelopeIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.EnvelopeIcon.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.EnvelopeIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.EnvelopeIcon.Location = new System.Drawing.Point(1116, 6);
            this.EnvelopeIcon.Name = "EnvelopeIcon";
            this.EnvelopeIcon.Size = new System.Drawing.Size(32, 32);
            this.EnvelopeIcon.TabIndex = 5;
            this.EnvelopeIcon.TabStop = false;
            this.EnvelopeIcon.MouseEnter += new System.EventHandler(this.EnvelopeIcon_MouseEnter);
            this.EnvelopeIcon.MouseLeave += new System.EventHandler(this.EnvelopeIcon_MouseLeave);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.ForeColor = System.Drawing.Color.PapayaWhip;
            this.UserName.Location = new System.Drawing.Point(981, 8);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(105, 25);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "UserName";
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Muse_IC.Properties.Resources.Image;
            this.UserPicture.Location = new System.Drawing.Point(908, 1);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(67, 37);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicture.TabIndex = 3;
            this.UserPicture.TabStop = false;
            // 
            // LognOutIcon
            // 
            this.LognOutIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LognOutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LognOutIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.LognOutIcon.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.LognOutIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.LognOutIcon.Location = new System.Drawing.Point(868, 5);
            this.LognOutIcon.Name = "LognOutIcon";
            this.LognOutIcon.Size = new System.Drawing.Size(32, 32);
            this.LognOutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LognOutIcon.TabIndex = 2;
            this.LognOutIcon.TabStop = false;
            this.LognOutIcon.Click += new System.EventHandler(this.SingOutIcon_Click);
            this.LognOutIcon.MouseEnter += new System.EventHandler(this.SingOutIcon_MouseEnter);
            this.LognOutIcon.MouseLeave += new System.EventHandler(this.SingOutIcon_MouseLeave);
            // 
            // CurrentName
            // 
            this.CurrentName.AutoSize = true;
            this.CurrentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentName.ForeColor = System.Drawing.Color.PapayaWhip;
            this.CurrentName.Location = new System.Drawing.Point(49, 5);
            this.CurrentName.Name = "CurrentName";
            this.CurrentName.Size = new System.Drawing.Size(82, 29);
            this.CurrentName.TabIndex = 1;
            this.CurrentName.Text = "Home";
            // 
            // CurrentIcon
            // 
            this.CurrentIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CurrentIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.CurrentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.CurrentIcon.IconSize = 36;
            this.CurrentIcon.Location = new System.Drawing.Point(13, 7);
            this.CurrentIcon.Name = "CurrentIcon";
            this.CurrentIcon.Size = new System.Drawing.Size(32, 32);
            this.CurrentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CurrentIcon.TabIndex = 0;
            this.CurrentIcon.TabStop = false;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ChildFormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChildFormPanel.Controls.Add(this.Player);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(261, 43);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1163, 746);
            this.ChildFormPanel.TabIndex = 3;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(56, 477);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(10, 13);
            this.Player.TabIndex = 0;
            this.Player.Visible = false;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBottom.Controls.Add(this.HistoryIcon);
            this.PanelBottom.Controls.Add(this.ModeIcon);
            this.PanelBottom.Controls.Add(this.panel7);
            this.PanelBottom.Controls.Add(this.VolumeIcon);
            this.PanelBottom.Controls.Add(this.panel6);
            this.PanelBottom.Controls.Add(this.TimeRight);
            this.PanelBottom.Controls.Add(this.panel5);
            this.PanelBottom.Controls.Add(this.TimeLeft);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.ForeColor = System.Drawing.Color.PapayaWhip;
            this.PanelBottom.Location = new System.Drawing.Point(261, 703);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1163, 86);
            this.PanelBottom.TabIndex = 4;
            // 
            // HistoryIcon
            // 
            this.HistoryIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.HistoryIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.HistoryIcon.IconChar = FontAwesome.Sharp.IconChar.History;
            this.HistoryIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.HistoryIcon.Location = new System.Drawing.Point(908, 13);
            this.HistoryIcon.Name = "HistoryIcon";
            this.HistoryIcon.Size = new System.Drawing.Size(32, 38);
            this.HistoryIcon.TabIndex = 7;
            this.HistoryIcon.TabStop = false;
            this.HistoryIcon.MouseEnter += new System.EventHandler(this.HistoryIcon_MouseEnter);
            this.HistoryIcon.MouseLeave += new System.EventHandler(this.HistoryIcon_MouseLeave);
            // 
            // ModeIcon
            // 
            this.ModeIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ModeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModeIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.ModeIcon.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.ModeIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.ModeIcon.Location = new System.Drawing.Point(870, 12);
            this.ModeIcon.Name = "ModeIcon";
            this.ModeIcon.Size = new System.Drawing.Size(32, 38);
            this.ModeIcon.TabIndex = 6;
            this.ModeIcon.TabStop = false;
            this.ModeIcon.MouseEnter += new System.EventHandler(this.ModeIcon_MouseEnter);
            this.ModeIcon.MouseLeave += new System.EventHandler(this.ModeIcon_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(777, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(78, 16);
            this.panel7.TabIndex = 5;
            // 
            // VolumeIcon
            // 
            this.VolumeIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.VolumeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VolumeIcon.ForeColor = System.Drawing.Color.PapayaWhip;
            this.VolumeIcon.IconChar = FontAwesome.Sharp.IconChar.VolumeDown;
            this.VolumeIcon.IconColor = System.Drawing.Color.PapayaWhip;
            this.VolumeIcon.Location = new System.Drawing.Point(739, 13);
            this.VolumeIcon.Name = "VolumeIcon";
            this.VolumeIcon.Size = new System.Drawing.Size(32, 38);
            this.VolumeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.VolumeIcon.TabIndex = 4;
            this.VolumeIcon.TabStop = false;
            this.VolumeIcon.Click += new System.EventHandler(this.VolumeIcon_Click);
            this.VolumeIcon.MouseEnter += new System.EventHandler(this.VolumeIcon_MouseEnter);
            this.VolumeIcon.MouseLeave += new System.EventHandler(this.VolumeIcon_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Help);
            this.panel6.Controls.Add(this.Library);
            this.panel6.Controls.Add(this.Home);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.ForeColor = System.Drawing.Color.PapayaWhip;
            this.panel6.Location = new System.Drawing.Point(0, 56);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1161, 28);
            this.panel6.TabIndex = 3;
            // 
            // Help
            // 
            this.Help.AutoSize = true;
            this.Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Help.Location = new System.Drawing.Point(661, 3);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 20);
            this.Help.TabIndex = 4;
            this.Help.Text = "Help";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            this.Help.MouseEnter += new System.EventHandler(this.Help_MouseEnter);
            this.Help.MouseLeave += new System.EventHandler(this.Help_MouseLeave);
            // 
            // Library
            // 
            this.Library.AutoSize = true;
            this.Library.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Library.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Library.Location = new System.Drawing.Point(539, 4);
            this.Library.Name = "Library";
            this.Library.Size = new System.Drawing.Size(61, 20);
            this.Library.TabIndex = 3;
            this.Library.Text = "Library";
            this.Library.Click += new System.EventHandler(this.Library_Click);
            this.Library.MouseEnter += new System.EventHandler(this.Library_MouseEnter);
            this.Library.MouseLeave += new System.EventHandler(this.Library_MouseLeave);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Home.ForeColor = System.Drawing.Color.PapayaWhip;
            this.Home.Location = new System.Drawing.Point(430, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(54, 20);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            this.Home.MouseEnter += new System.EventHandler(this.Home_MouseEnter);
            this.Home.MouseLeave += new System.EventHandler(this.Home_MouseLeave);
            // 
            // TimeRight
            // 
            this.TimeRight.AutoSize = true;
            this.TimeRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeRight.Location = new System.Drawing.Point(665, 19);
            this.TimeRight.Name = "TimeRight";
            this.TimeRight.Size = new System.Drawing.Size(41, 20);
            this.TimeRight.TabIndex = 2;
            this.TimeRight.Text = "2:10";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(225, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(425, 16);
            this.panel5.TabIndex = 1;
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLeft.Location = new System.Drawing.Point(164, 20);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(41, 20);
            this.TimeLeft.TabIndex = 0;
            this.TimeLeft.Text = "2:10";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 789);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "App";
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviousIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnvelopeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LognOutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentIcon)).EndInit();
            this.ChildFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeIcon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox MusicPicture;
        private System.Windows.Forms.Label Singer;
        private System.Windows.Forms.Label MusicName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel ChildFormPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton PlayListBtn;
        private FontAwesome.Sharp.IconButton FavouriteBtn;
        private FontAwesome.Sharp.IconButton FriendsBtn;
        private FontAwesome.Sharp.IconButton FindBtn;
        private FontAwesome.Sharp.IconButton MySongBtn;
        private FontAwesome.Sharp.IconButton UploadBtn;
        private FontAwesome.Sharp.IconPictureBox CurrentIcon;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Label CurrentName;
        private FontAwesome.Sharp.IconPictureBox LognOutIcon;
        private System.Windows.Forms.PictureBox UserPicture;
        private FontAwesome.Sharp.IconPictureBox EnvelopeIcon;
        private System.Windows.Forms.Label UserName;
        private FontAwesome.Sharp.IconPictureBox NextIcon;
        private FontAwesome.Sharp.IconPictureBox PlayIcon;
        private FontAwesome.Sharp.IconPictureBox PreviousIcon;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Label Library;
        private System.Windows.Forms.Label TimeRight;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Home;
        private FontAwesome.Sharp.IconPictureBox VolumeIcon;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconPictureBox ModeIcon;
        private FontAwesome.Sharp.IconPictureBox HistoryIcon;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label LoginLabel;
    }
}