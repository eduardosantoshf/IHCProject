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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FindMusicPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NoInfoLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.MusicFound = new System.Windows.Forms.DataGridView();
            this.FindMusicContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlayThisMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.MusicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FindMusicPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicFound)).BeginInit();
            this.FindMusicContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FindMusicPanel
            // 
            this.FindMusicPanel.BackColor = System.Drawing.Color.White;
            this.FindMusicPanel.Controls.Add(this.panel1);
            this.FindMusicPanel.Controls.Add(this.AddPanel);
            this.FindMusicPanel.Controls.Add(this.MusicFound);
            this.FindMusicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindMusicPanel.Location = new System.Drawing.Point(0, 0);
            this.FindMusicPanel.Name = "FindMusicPanel";
            this.FindMusicPanel.Size = new System.Drawing.Size(1239, 730);
            this.FindMusicPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 51);
            this.panel1.TabIndex = 49;
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.panel2);
            this.AddPanel.Controls.Add(this.NoInfoLabel);
            this.AddPanel.Controls.Add(this.ListBox);
            this.AddPanel.Location = new System.Drawing.Point(481, 142);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(277, 356);
            this.AddPanel.TabIndex = 47;
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
            this.NoInfoLabel.Location = new System.Drawing.Point(46, 140);
            this.NoInfoLabel.Name = "NoInfoLabel";
            this.NoInfoLabel.Size = new System.Drawing.Size(198, 25);
            this.NoInfoLabel.TabIndex = 0;
            this.NoInfoLabel.Text = "No Playlists Available";
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
            // MusicFound
            // 
            this.MusicFound.AllowUserToAddRows = false;
            this.MusicFound.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MusicFound.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.MusicFound.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusicFound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MusicFound.ColumnHeadersHeight = 40;
            this.MusicFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MusicFound.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.MusicFound.DefaultCellStyle = dataGridViewCellStyle2;
            this.MusicFound.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.MusicFound.Location = new System.Drawing.Point(0, 68);
            this.MusicFound.MultiSelect = false;
            this.MusicFound.Name = "MusicFound";
            this.MusicFound.ReadOnly = true;
            this.MusicFound.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MusicFound.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MusicFound.RowHeadersWidth = 40;
            this.MusicFound.RowTemplate.Height = 24;
            this.MusicFound.Size = new System.Drawing.Size(1239, 642);
            this.MusicFound.TabIndex = 43;
            this.MusicFound.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicFound_MouseContentClick);
            this.MusicFound.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicFound_CellMouseDown);
            this.MusicFound.SelectionChanged += new System.EventHandler(this.MusicFound_SelectionChanged);
            this.MusicFound.Sorted += new System.EventHandler(this.MusicFound_Sorted);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Muse_IC.Properties.Resources.FindFind;
            this.pictureBox3.Location = new System.Drawing.Point(786, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(452, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Muse_IC.Properties.Resources.FindFind;
            this.pictureBox2.Location = new System.Drawing.Point(390, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(403, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            this.panel1.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicFound)).EndInit();
            this.FindMusicContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
    }
}