namespace Muse_IC
{
    partial class PlayListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewPlaylistPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayListNameBox = new System.Windows.Forms.TextBox();
            this.PlayListPanel = new System.Windows.Forms.Panel();
            this.PlaylistAdd = new System.Windows.Forms.PictureBox();
            this.Playlist7 = new System.Windows.Forms.PictureBox();
            this.Playlist6 = new System.Windows.Forms.PictureBox();
            this.Playlist5 = new System.Windows.Forms.PictureBox();
            this.Playlist4 = new System.Windows.Forms.PictureBox();
            this.Playlist2 = new System.Windows.Forms.PictureBox();
            this.Playlist3 = new System.Windows.Forms.PictureBox();
            this.Playlist1 = new System.Windows.Forms.PictureBox();
            this.PlayList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.NewPlaylistPanel.SuspendLayout();
            this.PlayListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist1)).BeginInit();
            this.PlayList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.NewPlaylistPanel);
            this.panel1.Controls.Add(this.PlayListPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 667);
            this.panel1.TabIndex = 0;
            // 
            // NewPlaylistPanel
            // 
            this.NewPlaylistPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.NewPlaylistPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPlaylistPanel.Controls.Add(this.button2);
            this.NewPlaylistPanel.Controls.Add(this.button1);
            this.NewPlaylistPanel.Controls.Add(this.label3);
            this.NewPlaylistPanel.Controls.Add(this.PlayListNameBox);
            this.NewPlaylistPanel.Location = new System.Drawing.Point(206, 172);
            this.NewPlaylistPanel.Name = "NewPlaylistPanel";
            this.NewPlaylistPanel.Size = new System.Drawing.Size(590, 233);
            this.NewPlaylistPanel.TabIndex = 2;
            this.NewPlaylistPanel.Visible = false;
            this.NewPlaylistPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NewPlaylistPanel_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(383, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(81, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CreateNewPlayList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(112, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create Your New Playlist";
            // 
            // PlayListNameBox
            // 
            this.PlayListNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PlayListNameBox.Location = new System.Drawing.Point(81, 91);
            this.PlayListNameBox.Name = "PlayListNameBox";
            this.PlayListNameBox.Size = new System.Drawing.Size(399, 38);
            this.PlayListNameBox.TabIndex = 1;
            // 
            // PlayListPanel
            // 
            this.PlayListPanel.AutoScroll = true;
            this.PlayListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.PlayListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayListPanel.Controls.Add(this.PlaylistAdd);
            this.PlayListPanel.Controls.Add(this.Playlist7);
            this.PlayListPanel.Controls.Add(this.Playlist6);
            this.PlayListPanel.Controls.Add(this.Playlist5);
            this.PlayListPanel.Controls.Add(this.Playlist4);
            this.PlayListPanel.Controls.Add(this.Playlist2);
            this.PlayListPanel.Controls.Add(this.Playlist3);
            this.PlayListPanel.Controls.Add(this.Playlist1);
            this.PlayListPanel.Controls.Add(this.PlayList);
            this.PlayListPanel.Location = new System.Drawing.Point(12, 12);
            this.PlayListPanel.Name = "PlayListPanel";
            this.PlayListPanel.Size = new System.Drawing.Size(1105, 299);
            this.PlayListPanel.TabIndex = 0;
            // 
            // PlaylistAdd
            // 
            this.PlaylistAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlaylistAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlaylistAdd.Image = ((System.Drawing.Image)(resources.GetObject("PlaylistAdd.Image")));
            this.PlaylistAdd.Location = new System.Drawing.Point(921, 145);
            this.PlaylistAdd.Name = "PlaylistAdd";
            this.PlaylistAdd.Size = new System.Drawing.Size(117, 107);
            this.PlaylistAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlaylistAdd.TabIndex = 10;
            this.PlaylistAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.PlaylistAdd, "Add");
            this.PlaylistAdd.Visible = false;
            this.PlaylistAdd.Click += new System.EventHandler(this.Playlist8_Click);
            // 
            // Playlist7
            // 
            this.Playlist7.BackColor = System.Drawing.Color.Transparent;
            this.Playlist7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist7.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist7.Location = new System.Drawing.Point(726, 145);
            this.Playlist7.Name = "Playlist7";
            this.Playlist7.Size = new System.Drawing.Size(129, 115);
            this.Playlist7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist7.TabIndex = 9;
            this.Playlist7.TabStop = false;
            this.Playlist7.Visible = false;
            // 
            // Playlist6
            // 
            this.Playlist6.BackColor = System.Drawing.Color.Transparent;
            this.Playlist6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist6.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist6.Location = new System.Drawing.Point(512, 143);
            this.Playlist6.Name = "Playlist6";
            this.Playlist6.Size = new System.Drawing.Size(134, 115);
            this.Playlist6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist6.TabIndex = 8;
            this.Playlist6.TabStop = false;
            this.Playlist6.Visible = false;
            this.Playlist6.Click += new System.EventHandler(this.Playlist6_Click);
            // 
            // Playlist5
            // 
            this.Playlist5.BackColor = System.Drawing.Color.Transparent;
            this.Playlist5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist5.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist5.Location = new System.Drawing.Point(328, 143);
            this.Playlist5.Name = "Playlist5";
            this.Playlist5.Size = new System.Drawing.Size(127, 117);
            this.Playlist5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist5.TabIndex = 7;
            this.Playlist5.TabStop = false;
            this.Playlist5.Visible = false;
            // 
            // Playlist4
            // 
            this.Playlist4.BackColor = System.Drawing.Color.Transparent;
            this.Playlist4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist4.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist4.Location = new System.Drawing.Point(137, 143);
            this.Playlist4.Name = "Playlist4";
            this.Playlist4.Size = new System.Drawing.Size(126, 117);
            this.Playlist4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist4.TabIndex = 6;
            this.Playlist4.TabStop = false;
            this.Playlist4.Visible = false;
            // 
            // Playlist2
            // 
            this.Playlist2.BackColor = System.Drawing.Color.Transparent;
            this.Playlist2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist2.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist2.Location = new System.Drawing.Point(525, 15);
            this.Playlist2.Name = "Playlist2";
            this.Playlist2.Size = new System.Drawing.Size(121, 110);
            this.Playlist2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist2.TabIndex = 4;
            this.Playlist2.TabStop = false;
            this.Playlist2.Visible = false;
            // 
            // Playlist3
            // 
            this.Playlist3.BackColor = System.Drawing.Color.Transparent;
            this.Playlist3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist3.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist3.Location = new System.Drawing.Point(726, 15);
            this.Playlist3.Name = "Playlist3";
            this.Playlist3.Size = new System.Drawing.Size(129, 118);
            this.Playlist3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist3.TabIndex = 3;
            this.Playlist3.TabStop = false;
            this.Playlist3.Visible = false;
            // 
            // Playlist1
            // 
            this.Playlist1.BackColor = System.Drawing.Color.Transparent;
            this.Playlist1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Playlist1.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.Playlist1.Location = new System.Drawing.Point(328, 15);
            this.Playlist1.Name = "Playlist1";
            this.Playlist1.Size = new System.Drawing.Size(127, 110);
            this.Playlist1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Playlist1.TabIndex = 1;
            this.Playlist1.TabStop = false;
            this.toolTip1.SetToolTip(this.Playlist1, "Playlist");
            this.Playlist1.Visible = false;
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayList.Controls.Add(this.label1);
            this.PlayList.Location = new System.Drawing.Point(47, 43);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(193, 71);
            this.PlayList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlayLists";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(134)))), ((int)(((byte)(150)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 286);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(108)))), ((int)(((byte)(134)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(28, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 71);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Podcasts";
            // 
            // PlayListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1164, 667);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlayListForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PlayListForm";
            this.panel1.ResumeLayout(false);
            this.NewPlaylistPanel.ResumeLayout(false);
            this.NewPlaylistPanel.PerformLayout();
            this.PlayListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlaylistAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playlist1)).EndInit();
            this.PlayList.ResumeLayout(false);
            this.PlayList.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PlayListPanel;
        private System.Windows.Forms.Panel PlayList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Playlist1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel NewPlaylistPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlayListNameBox;
        private System.Windows.Forms.PictureBox PlaylistAdd;
        private System.Windows.Forms.PictureBox Playlist7;
        private System.Windows.Forms.PictureBox Playlist6;
        private System.Windows.Forms.PictureBox Playlist5;
        private System.Windows.Forms.PictureBox Playlist4;
        private System.Windows.Forms.PictureBox Playlist2;
        private System.Windows.Forms.PictureBox Playlist3;
    }
}