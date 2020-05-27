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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OperationPanel = new System.Windows.Forms.Panel();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NoInfoLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.MusicFound = new System.Windows.Forms.DataGridView();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FindMusicContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlayThisMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.FindMusicPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OperationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).BeginInit();
            this.AddPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicFound)).BeginInit();
            this.FindMusicContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindMusicPanel
            // 
            this.FindMusicPanel.BackColor = System.Drawing.Color.White;
            this.FindMusicPanel.Controls.Add(this.panel1);
            this.FindMusicPanel.Controls.Add(this.OperationPanel);
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
            // OperationPanel
            // 
            this.OperationPanel.Controls.Add(this.iconPictureBox7);
            this.OperationPanel.Controls.Add(this.iconPictureBox9);
            this.OperationPanel.Controls.Add(this.iconPictureBox8);
            this.OperationPanel.Location = new System.Drawing.Point(67, 125);
            this.OperationPanel.Name = "OperationPanel";
            this.OperationPanel.Size = new System.Drawing.Size(180, 29);
            this.OperationPanel.TabIndex = 48;
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
            this.Operation,
            this.MusicName,
            this.Singer,
            this.Album,
            this.Duration});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MusicFound.DefaultCellStyle = dataGridViewCellStyle5;
            this.MusicFound.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MusicFound.Location = new System.Drawing.Point(0, 68);
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
            this.MusicFound.RowHeadersWidth = 40;
            this.MusicFound.RowTemplate.Height = 24;
            this.MusicFound.Size = new System.Drawing.Size(1239, 642);
            this.MusicFound.TabIndex = 43;
            this.MusicFound.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusicFound_CellDoubleClick);
            this.MusicFound.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicFound_MouseContentClick);
            this.MusicFound.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MusicFound_CellMouseDown);
            this.MusicFound.SelectionChanged += new System.EventHandler(this.MusicFound_SelectionChanged);
            this.MusicFound.Sorted += new System.EventHandler(this.MusicFound_Sorted);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OperationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox8)).EndInit();
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicFound)).EndInit();
            this.FindMusicContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FindMusicPanel;
        private System.Windows.Forms.DataGridView MusicFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Singer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NoInfoLabel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Panel OperationPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox8;
        private System.Windows.Forms.ContextMenuStrip FindMusicContextMenu;
        private System.Windows.Forms.ToolStripMenuItem PlayThisMusic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}