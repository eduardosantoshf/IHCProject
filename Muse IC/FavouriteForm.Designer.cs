namespace Muse_IC
{
    partial class FavouriteForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyFavoritePanel = new System.Windows.Forms.Panel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NoInfoLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.OperationPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.FavouritesMusic = new System.Windows.Forms.DataGridView();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.GoLogin = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ViewsNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MusicNumber = new System.Windows.Forms.Label();
            this.Favourites = new System.Windows.Forms.Label();
            this.Friend1Picture = new System.Windows.Forms.PictureBox();
            this.UserPanel = new System.Windows.Forms.Panel();
            this.SharesNumber = new System.Windows.Forms.Label();
            this.LikesNumber = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tag = new System.Windows.Forms.Label();
            this.HeartIcon = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShareIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Bio = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.Private = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FavouritesContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlayThisMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.MyFavoritePanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.OperationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavouritesMusic)).BeginInit();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Friend1Picture)).BeginInit();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Private)).BeginInit();
            this.FavouritesContexMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.MyFavoritePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 649);
            this.panel1.TabIndex = 0;
            // 
            // MyFavoritePanel
            // 
            this.MyFavoritePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyFavoritePanel.Controls.Add(this.AddPanel);
            this.MyFavoritePanel.Controls.Add(this.OperationPanel);
            this.MyFavoritePanel.Controls.Add(this.FavouritesMusic);
            this.MyFavoritePanel.Controls.Add(this.LoginPanel);
            this.MyFavoritePanel.Controls.Add(this.panel3);
            this.MyFavoritePanel.Controls.Add(this.ViewsNumber);
            this.MyFavoritePanel.Controls.Add(this.label2);
            this.MyFavoritePanel.Controls.Add(this.label1);
            this.MyFavoritePanel.Controls.Add(this.MusicNumber);
            this.MyFavoritePanel.Controls.Add(this.Favourites);
            this.MyFavoritePanel.Controls.Add(this.Friend1Picture);
            this.MyFavoritePanel.Controls.Add(this.UserPanel);
            this.MyFavoritePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyFavoritePanel.Location = new System.Drawing.Point(0, 0);
            this.MyFavoritePanel.Name = "MyFavoritePanel";
            this.MyFavoritePanel.Size = new System.Drawing.Size(1103, 649);
            this.MyFavoritePanel.TabIndex = 1;
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.panel2);
            this.AddPanel.Controls.Add(this.NoInfoLabel);
            this.AddPanel.Controls.Add(this.ListBox);
            this.AddPanel.Location = new System.Drawing.Point(413, 146);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(277, 356);
            this.AddPanel.TabIndex = 46;
            this.AddPanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 48);
            this.panel2.TabIndex = 43;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.Location = new System.Drawing.Point(173, 7);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(81, 33);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.Location = new System.Drawing.Point(17, 7);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(81, 33);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NoInfoLabel
            // 
            this.NoInfoLabel.AutoSize = true;
            this.NoInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoInfoLabel.Location = new System.Drawing.Point(102, 140);
            this.NoInfoLabel.Name = "NoInfoLabel";
            this.NoInfoLabel.Size = new System.Drawing.Size(74, 25);
            this.NoInfoLabel.TabIndex = 0;
            this.NoInfoLabel.Text = "No Info";
            // 
            // ListBox
            // 
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 29;
            this.ListBox.Location = new System.Drawing.Point(0, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(277, 356);
            this.ListBox.TabIndex = 42;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // OperationPanel
            // 
            this.OperationPanel.Controls.Add(this.iconPictureBox7);
            this.OperationPanel.Controls.Add(this.iconPictureBox9);
            this.OperationPanel.Controls.Add(this.iconPictureBox8);
            this.OperationPanel.Location = new System.Drawing.Point(103, 354);
            this.OperationPanel.Name = "OperationPanel";
            this.OperationPanel.Size = new System.Drawing.Size(180, 29);
            this.OperationPanel.TabIndex = 45;
            this.OperationPanel.Visible = false;
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.iconPictureBox7.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox7.IconSize = 35;
            this.iconPictureBox7.Location = new System.Drawing.Point(19, 0);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Size = new System.Drawing.Size(46, 35);
            this.iconPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox7.TabIndex = 49;
            this.iconPictureBox7.TabStop = false;
            // 
            // iconPictureBox9
            // 
            this.iconPictureBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox9.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox9.IconSize = 35;
            this.iconPictureBox9.Location = new System.Drawing.Point(115, 0);
            this.iconPictureBox9.Name = "iconPictureBox9";
            this.iconPictureBox9.Size = new System.Drawing.Size(40, 35);
            this.iconPictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox9.TabIndex = 47;
            this.iconPictureBox9.TabStop = false;
            // 
            // iconPictureBox8
            // 
            this.iconPictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconPictureBox8.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox8.IconSize = 35;
            this.iconPictureBox8.Location = new System.Drawing.Point(71, 0);
            this.iconPictureBox8.Name = "iconPictureBox8";
            this.iconPictureBox8.Size = new System.Drawing.Size(38, 35);
            this.iconPictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox8.TabIndex = 48;
            this.iconPictureBox8.TabStop = false;
            // 
            // FavouritesMusic
            // 
            this.FavouritesMusic.AllowUserToAddRows = false;
            this.FavouritesMusic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FavouritesMusic.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.FavouritesMusic.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FavouritesMusic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FavouritesMusic.ColumnHeadersHeight = 40;
            this.FavouritesMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FavouritesMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operation,
            this.MusicName,
            this.Singer,
            this.Album,
            this.Duration});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FavouritesMusic.DefaultCellStyle = dataGridViewCellStyle2;
            this.FavouritesMusic.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FavouritesMusic.Location = new System.Drawing.Point(48, 290);
            this.FavouritesMusic.MultiSelect = false;
            this.FavouritesMusic.Name = "FavouritesMusic";
            this.FavouritesMusic.ReadOnly = true;
            this.FavouritesMusic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FavouritesMusic.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FavouritesMusic.RowHeadersWidth = 40;
            this.FavouritesMusic.RowTemplate.Height = 24;
            this.FavouritesMusic.Size = new System.Drawing.Size(1052, 359);
            this.FavouritesMusic.TabIndex = 42;
            this.FavouritesMusic.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FavouritesMusic_CellDoubleClick);
            this.FavouritesMusic.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FavouritesMusic_CellMouseDown);
            this.FavouritesMusic.SelectionChanged += new System.EventHandler(this.FavouritesMusic_SelectionChanged);
            this.FavouritesMusic.Sorted += new System.EventHandler(this.FavouritesMusic_Sorted);
            // 
            // Operation
            // 
            this.Operation.HeaderText = "Operation";
            this.Operation.MinimumWidth = 6;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MusicName
            // 
            this.MusicName.HeaderText = "Name";
            this.MusicName.MinimumWidth = 6;
            this.MusicName.Name = "MusicName";
            this.MusicName.ReadOnly = true;
            // 
            // Singer
            // 
            this.Singer.HeaderText = "Singer";
            this.Singer.MinimumWidth = 6;
            this.Singer.Name = "Singer";
            this.Singer.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LoginPanel.Controls.Add(this.GoLogin);
            this.LoginPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginPanel.Location = new System.Drawing.Point(256, 228);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(555, 107);
            this.LoginPanel.TabIndex = 41;
            // 
            // GoLogin
            // 
            this.GoLogin.AutoSize = true;
            this.GoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GoLogin.Location = new System.Drawing.Point(198, 35);
            this.GoLogin.Name = "GoLogin";
            this.GoLogin.Size = new System.Drawing.Size(57, 24);
            this.GoLogin.TabIndex = 1;
            this.GoLogin.Text = "Login";
            this.GoLogin.Click += new System.EventHandler(this.GoLogin_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(981, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 66);
            this.panel3.TabIndex = 33;
            // 
            // ViewsNumber
            // 
            this.ViewsNumber.AutoSize = true;
            this.ViewsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ViewsNumber.Location = new System.Drawing.Point(1013, 52);
            this.ViewsNumber.Name = "ViewsNumber";
            this.ViewsNumber.Size = new System.Drawing.Size(18, 20);
            this.ViewsNumber.TabIndex = 37;
            this.ViewsNumber.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(911, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Music";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(988, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Views";
            // 
            // MusicNumber
            // 
            this.MusicNumber.AutoSize = true;
            this.MusicNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicNumber.Location = new System.Drawing.Point(938, 51);
            this.MusicNumber.Name = "MusicNumber";
            this.MusicNumber.Size = new System.Drawing.Size(18, 20);
            this.MusicNumber.TabIndex = 36;
            this.MusicNumber.Text = "4";
            // 
            // Favourites
            // 
            this.Favourites.AutoSize = true;
            this.Favourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Favourites.Location = new System.Drawing.Point(253, 27);
            this.Favourites.Name = "Favourites";
            this.Favourites.Size = new System.Drawing.Size(125, 29);
            this.Favourites.TabIndex = 9;
            this.Favourites.Text = "Favourites";
            // 
            // Friend1Picture
            // 
            this.Friend1Picture.Image = global::Muse_IC.Properties.Resources.Favorite;
            this.Friend1Picture.Location = new System.Drawing.Point(28, 26);
            this.Friend1Picture.Name = "Friend1Picture";
            this.Friend1Picture.Size = new System.Drawing.Size(216, 180);
            this.Friend1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Friend1Picture.TabIndex = 8;
            this.Friend1Picture.TabStop = false;
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.SharesNumber);
            this.UserPanel.Controls.Add(this.LikesNumber);
            this.UserPanel.Controls.Add(this.UserPicture);
            this.UserPanel.Controls.Add(this.label3);
            this.UserPanel.Controls.Add(this.Tag);
            this.UserPanel.Controls.Add(this.HeartIcon);
            this.UserPanel.Controls.Add(this.label4);
            this.UserPanel.Controls.Add(this.ShareIcon);
            this.UserPanel.Controls.Add(this.Bio);
            this.UserPanel.Controls.Add(this.AuthorName);
            this.UserPanel.Controls.Add(this.Private);
            this.UserPanel.Controls.Add(this.label5);
            this.UserPanel.Location = new System.Drawing.Point(256, 74);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(835, 146);
            this.UserPanel.TabIndex = 40;
            // 
            // SharesNumber
            // 
            this.SharesNumber.AutoSize = true;
            this.SharesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SharesNumber.Location = new System.Drawing.Point(682, 108);
            this.SharesNumber.Name = "SharesNumber";
            this.SharesNumber.Size = new System.Drawing.Size(18, 20);
            this.SharesNumber.TabIndex = 41;
            this.SharesNumber.Text = "0";
            // 
            // LikesNumber
            // 
            this.LikesNumber.AutoSize = true;
            this.LikesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LikesNumber.Location = new System.Drawing.Point(757, 108);
            this.LikesNumber.Name = "LikesNumber";
            this.LikesNumber.Size = new System.Drawing.Size(18, 20);
            this.LikesNumber.TabIndex = 40;
            this.LikesNumber.Text = "0";
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::Muse_IC.Properties.Resources.Uer;
            this.UserPicture.Location = new System.Drawing.Point(15, 20);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(48, 46);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicture.TabIndex = 29;
            this.UserPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tag:";
            // 
            // Tag
            // 
            this.Tag.AutoSize = true;
            this.Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tag.Location = new System.Drawing.Point(69, 83);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(53, 20);
            this.Tag.TabIndex = 16;
            this.Tag.Text = "label5";
            // 
            // HeartIcon
            // 
            this.HeartIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeartIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeartIcon.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.HeartIcon.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.HeartIcon.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.HeartIcon.IconSize = 60;
            this.HeartIcon.Location = new System.Drawing.Point(735, 49);
            this.HeartIcon.Name = "HeartIcon";
            this.HeartIcon.Size = new System.Drawing.Size(60, 65);
            this.HeartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeartIcon.TabIndex = 39;
            this.HeartIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Brief description: ";
            // 
            // ShareIcon
            // 
            this.ShareIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShareIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShareIcon.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ShareIcon.IconChar = FontAwesome.Sharp.IconChar.ShareAlt;
            this.ShareIcon.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.ShareIcon.IconSize = 53;
            this.ShareIcon.Location = new System.Drawing.Point(660, 53);
            this.ShareIcon.Name = "ShareIcon";
            this.ShareIcon.Size = new System.Drawing.Size(59, 53);
            this.ShareIcon.TabIndex = 38;
            this.ShareIcon.TabStop = false;
            // 
            // Bio
            // 
            this.Bio.AutoSize = true;
            this.Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bio.Location = new System.Drawing.Point(202, 127);
            this.Bio.Name = "Bio";
            this.Bio.Size = new System.Drawing.Size(115, 20);
            this.Bio.TabIndex = 17;
            this.Bio.Text = "They are good";
            // 
            // AuthorName
            // 
            this.AuthorName.AutoSize = true;
            this.AuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorName.Location = new System.Drawing.Point(69, 28);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(147, 29);
            this.AuthorName.TabIndex = 30;
            this.AuthorName.Text = "AuthorName";
            // 
            // Private
            // 
            this.Private.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Private.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Private.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Private.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.Private.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Private.IconSize = 75;
            this.Private.Location = new System.Drawing.Point(298, 20);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(122, 75);
            this.Private.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Private.TabIndex = 34;
            this.Private.TabStop = false;
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(417, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Private";
            // 
            // FavouritesContexMenu
            // 
            this.FavouritesContexMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FavouritesContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayThisMusic});
            this.FavouritesContexMenu.Name = "contextMenuStrip3";
            this.FavouritesContexMenu.Size = new System.Drawing.Size(108, 28);
            // 
            // PlayThisMusic
            // 
            this.PlayThisMusic.Name = "PlayThisMusic";
            this.PlayThisMusic.Size = new System.Drawing.Size(107, 24);
            this.PlayThisMusic.Text = "Play";
            this.PlayThisMusic.Click += new System.EventHandler(this.PlayThisMusic_Click);
            // 
            // FavouriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 649);
            this.Controls.Add(this.panel1);
            this.Name = "FavouriteForm";
            this.Text = "MyFavorite";
            this.panel1.ResumeLayout(false);
            this.MyFavoritePanel.ResumeLayout(false);
            this.MyFavoritePanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.OperationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FavouritesMusic)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Friend1Picture)).EndInit();
            this.UserPanel.ResumeLayout(false);
            this.UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShareIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Private)).EndInit();
            this.FavouritesContexMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MyFavoritePanel;
        private System.Windows.Forms.Label Bio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Favourites;
        private System.Windows.Forms.PictureBox Friend1Picture;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Label Tag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox Private;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ViewsNumber;
        private System.Windows.Forms.Label MusicNumber;
        private FontAwesome.Sharp.IconPictureBox ShareIcon;
        private FontAwesome.Sharp.IconPictureBox HeartIcon;
        private System.Windows.Forms.Panel UserPanel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label NoInfoLabel;
        private System.Windows.Forms.Label GoLogin;
        private System.Windows.Forms.DataGridView FavouritesMusic;
        private System.Windows.Forms.Panel OperationPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private System.Windows.Forms.ContextMenuStrip FavouritesContexMenu;
        private System.Windows.Forms.ToolStripMenuItem PlayThisMusic;
        private System.Windows.Forms.Label LikesNumber;
        private System.Windows.Forms.Label SharesNumber;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox ListBox;
    }
}