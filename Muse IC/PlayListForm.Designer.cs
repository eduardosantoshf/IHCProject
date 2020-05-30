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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlayListPanel = new System.Windows.Forms.Panel();
            this.NewPlaylistPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayListNameBox = new System.Windows.Forms.TextBox();
            this.PictureBoxExemplo = new System.Windows.Forms.PictureBox();
            this.PlayList = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.PlayListPanel.SuspendLayout();
            this.NewPlaylistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExemplo)).BeginInit();
            this.PlayList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.Controls.Add(this.PlayListPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 667);
            this.panel1.TabIndex = 0;
            // 
            // PlayListPanel
            // 
            this.PlayListPanel.AutoScroll = true;
            this.PlayListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayListPanel.Controls.Add(this.NewPlaylistPanel);
            this.PlayListPanel.Controls.Add(this.PictureBoxExemplo);
            this.PlayListPanel.Controls.Add(this.PlayList);
            this.PlayListPanel.Location = new System.Drawing.Point(12, 12);
            this.PlayListPanel.Name = "PlayListPanel";
            this.PlayListPanel.Size = new System.Drawing.Size(1140, 325);
            this.PlayListPanel.TabIndex = 0;
            // 
            // NewPlaylistPanel
            // 
            this.NewPlaylistPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPlaylistPanel.Controls.Add(this.button2);
            this.NewPlaylistPanel.Controls.Add(this.button1);
            this.NewPlaylistPanel.Controls.Add(this.label3);
            this.NewPlaylistPanel.Controls.Add(this.PlayListNameBox);
            this.NewPlaylistPanel.Location = new System.Drawing.Point(287, 77);
            this.NewPlaylistPanel.Name = "NewPlaylistPanel";
            this.NewPlaylistPanel.Size = new System.Drawing.Size(546, 235);
            this.NewPlaylistPanel.TabIndex = 2;
            this.NewPlaylistPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(383, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(81, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateNewPlayList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(75, 26);
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
            // PictureBoxExemplo
            // 
            this.PictureBoxExemplo.Image = global::Muse_IC.Properties.Resources.Playlist1;
            this.PictureBoxExemplo.Location = new System.Drawing.Point(326, 15);
            this.PictureBoxExemplo.Name = "PictureBoxExemplo";
            this.PictureBoxExemplo.Size = new System.Drawing.Size(139, 125);
            this.PictureBoxExemplo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxExemplo.TabIndex = 1;
            this.PictureBoxExemplo.TabStop = false;
            this.PictureBoxExemplo.Visible = false;
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayList.Controls.Add(this.label1);
            this.PlayList.Location = new System.Drawing.Point(47, 48);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(193, 71);
            this.PlayList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlayLists";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(12, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 325);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(930, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 71);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(32, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Podcasts";
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 667);
            this.Controls.Add(this.panel1);
            this.Name = "PlayListForm";
            this.Text = "PlayListForm";
            this.panel1.ResumeLayout(false);
            this.PlayListPanel.ResumeLayout(false);
            this.NewPlaylistPanel.ResumeLayout(false);
            this.NewPlaylistPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxExemplo)).EndInit();
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
        private System.Windows.Forms.PictureBox PictureBoxExemplo;
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
    }
}