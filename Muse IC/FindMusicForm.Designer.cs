namespace Muse_IC
{
    partial class FindMusicForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FindMusicPanel = new System.Windows.Forms.Panel();
            this.NewPlaylistPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayListNameBox = new System.Windows.Forms.TextBox();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NoInfoLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MusicFound = new System.Windows.Forms.DataGridView();
            this.MusicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindMusicContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlayThisMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FindMusicPanel.SuspendLayout();
            this.NewPlaylistPanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicFound)).BeginInit();
            this.FindMusicContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FindMusicPanel
            // 
            this.FindMusicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.FindMusicPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindMusicPanel.Controls.Add(this.NewPlaylistPanel);
            this.FindMusicPanel.Controls.Add(this.AddPanel);
            this.FindMusicPanel.Controls.Add(this.panel1);
            this.FindMusicPanel.Controls.Add(this.MusicFound);
            this.FindMusicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindMusicPanel.Location = new System.Drawing.Point(0, 0);
            this.FindMusicPanel.Name = "FindMusicPanel";
            this.FindMusicPanel.Size = new System.Drawing.Size(1239, 730);
            this.FindMusicPanel.TabIndex = 0;
            // 
            // NewPlaylistPanel
            // 
            this.NewPlaylistPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.NewPlaylistPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPlaylistPanel.Controls.Add(this.button3);
            this.NewPlaylistPanel.Controls.Add(this.button4);
            this.NewPlaylistPanel.Controls.Add(this.label6);
            this.NewPlaylistPanel.Controls.Add(this.PlayListNameBox);
            this.NewPlaylistPanel.Location = new System.Drawing.Point(317, 85);
            this.NewPlaylistPanel.Name = "NewPlaylistPanel";
            this.NewPlaylistPanel.Size = new System.Drawing.Size(590, 233);
            this.NewPlaylistPanel.TabIndex = 47;
            this.NewPlaylistPanel.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(383, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(81, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Create";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(112, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Create Your New Playlist";
            // 
            // PlayListNameBox
            // 
            this.PlayListNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayListNameBox.Location = new System.Drawing.Point(81, 91);
            this.PlayListNameBox.Name = "PlayListNameBox";
            this.PlayListNameBox.Size = new System.Drawing.Size(399, 38);
            this.PlayListNameBox.TabIndex = 1;
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.AddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPanel.Controls.Add(this.button6);
            this.AddPanel.Controls.Add(this.panel2);
            this.AddPanel.Controls.Add(this.NoInfoLabel);
            this.AddPanel.Controls.Add(this.ListBox);
            this.AddPanel.Location = new System.Drawing.Point(482, 69);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(277, 356);
            this.AddPanel.TabIndex = 47;
            this.AddPanel.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(177)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(174, 254);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "Create";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Controls.Add(this.AddBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 48);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(177)))));
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBtn.Location = new System.Drawing.Point(17, 7);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(81, 33);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NoInfoLabel
            // 
            this.NoInfoLabel.AutoSize = true;
            this.NoInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(105)))), ((int)(((byte)(134)))));
            this.NoInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoInfoLabel.Location = new System.Drawing.Point(46, 159);
            this.NoInfoLabel.Name = "NoInfoLabel";
            this.NoInfoLabel.Size = new System.Drawing.Size(198, 25);
            this.NoInfoLabel.TabIndex = 0;
            this.NoInfoLabel.Text = "No Playlists Available";
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(105)))), ((int)(((byte)(134)))));
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 29;
            this.ListBox.Location = new System.Drawing.Point(4, 3);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(268, 292);
            this.ListBox.TabIndex = 42;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 51);
            this.panel1.TabIndex = 49;
            // 
            // MusicFound
            // 
            this.MusicFound.AllowUserToAddRows = false;
            this.MusicFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MusicFound.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.MusicFound.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusicFound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.MusicFound.ColumnHeadersHeight = 40;
            this.MusicFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MusicFound.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MusicName,
            this.Singer,
            this.Album,
            this.Duration});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(134)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MusicFound.DefaultCellStyle = dataGridViewCellStyle5;
            this.MusicFound.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.MusicFound.Location = new System.Drawing.Point(53, 106);
            this.MusicFound.MultiSelect = false;
            this.MusicFound.Name = "MusicFound";
            this.MusicFound.ReadOnly = true;
            this.MusicFound.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusicFound.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.MusicFound.RowHeadersVisible = false;
            this.MusicFound.RowHeadersWidth = 40;
            this.MusicFound.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.MusicFound.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.MusicFound.RowTemplate.Height = 24;
            this.MusicFound.Size = new System.Drawing.Size(1064, 514);
            this.MusicFound.TabIndex = 43;
            this.MusicFound.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicFound_MouseContentClick);
            this.MusicFound.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicFound_CellMouseDown);
            this.MusicFound.SelectionChanged += new System.EventHandler(this.MusicFound_SelectionChanged);
            this.MusicFound.Sorted += new System.EventHandler(this.MusicFound_Sorted);
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
            // FindMusicContextMenu
            // 
            this.FindMusicContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FindMusicContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayThisMusic});
            this.FindMusicContextMenu.Name = "FindMusicContextMenu";
            this.FindMusicContextMenu.Size = new System.Drawing.Size(106, 28);
            // 
            // PlayThisMusic
            // 
            this.PlayThisMusic.Name = "PlayThisMusic";
            this.PlayThisMusic.Size = new System.Drawing.Size(105, 24);
            this.PlayThisMusic.Text = "Play";
            this.PlayThisMusic.Click += new System.EventHandler(this.PlayThisMusic_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Muse_IC.Properties.Resources.FindFind;
            this.pictureBox2.Location = new System.Drawing.Point(394, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Muse_IC.Properties.Resources.FindFind;
            this.pictureBox3.Location = new System.Drawing.Point(803, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(434, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Muse_IC.Properties.Resources.FindFind;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FindMusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 730);
            this.Controls.Add(this.FindMusicPanel);
            this.Name = "FindMusicForm";
            this.Text = "FindMusicForm";
            this.FindMusicPanel.ResumeLayout(false);
            this.NewPlaylistPanel.ResumeLayout(false);
            this.NewPlaylistPanel.PerformLayout();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicFound)).EndInit();
            this.FindMusicContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FindMusicPanel;
        private System.Windows.Forms.DataGridView MusicFound;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NoInfoLabel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.ContextMenuStrip FindMusicContextMenu;
        private System.Windows.Forms.ToolStripMenuItem PlayThisMusic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Panel NewPlaylistPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PlayListNameBox;
        private System.Windows.Forms.Button button6;
    }
}