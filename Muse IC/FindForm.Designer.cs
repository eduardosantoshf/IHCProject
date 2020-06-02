namespace Muse_IC
{
    partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SingerZone = new System.Windows.Forms.PictureBox();
            this.AlbumsZone = new System.Windows.Forms.PictureBox();
            this.PodcastsZone = new System.Windows.Forms.PictureBox();
            this.MusicZone = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SingerZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodcastsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1116, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(241, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Musics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(615, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Singer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(242, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Albums";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(615, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Podcasts";
            // 
            // SingerZone
            // 
            this.SingerZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingerZone.Enabled = false;
            this.SingerZone.Image = global::Muse_IC.Properties.Resources.Singers;
            this.SingerZone.Location = new System.Drawing.Point(611, 86);
            this.SingerZone.Name = "SingerZone";
            this.SingerZone.Size = new System.Drawing.Size(302, 239);
            this.SingerZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SingerZone.TabIndex = 4;
            this.SingerZone.TabStop = false;
            this.SingerZone.Tag = "Podcasts";
            this.SingerZone.MouseEnter += new System.EventHandler(this.SingerZone_MouseHover);
            this.SingerZone.MouseLeave += new System.EventHandler(this.SingerZone_MouseLeave);
            // 
            // AlbumsZone
            // 
            this.AlbumsZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlbumsZone.Enabled = false;
            this.AlbumsZone.Image = ((System.Drawing.Image)(resources.GetObject("AlbumsZone.Image")));
            this.AlbumsZone.Location = new System.Drawing.Point(238, 362);
            this.AlbumsZone.Name = "AlbumsZone";
            this.AlbumsZone.Size = new System.Drawing.Size(292, 233);
            this.AlbumsZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumsZone.TabIndex = 3;
            this.AlbumsZone.TabStop = false;
            this.AlbumsZone.MouseEnter += new System.EventHandler(this.AlbumsZone_MouseHover);
            this.AlbumsZone.MouseLeave += new System.EventHandler(this.AlbumsZone_MouseLeave);
            // 
            // PodcastsZone
            // 
            this.PodcastsZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PodcastsZone.Enabled = false;
            this.PodcastsZone.Image = global::Muse_IC.Properties.Resources.Podcast;
            this.PodcastsZone.Location = new System.Drawing.Point(611, 362);
            this.PodcastsZone.Name = "PodcastsZone";
            this.PodcastsZone.Size = new System.Drawing.Size(302, 234);
            this.PodcastsZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PodcastsZone.TabIndex = 2;
            this.PodcastsZone.TabStop = false;
            this.PodcastsZone.MouseEnter += new System.EventHandler(this.PodcastsZone_MouseHover);
            this.PodcastsZone.MouseLeave += new System.EventHandler(this.PodcastsZone_MouseLeave);
            // 
            // MusicZone
            // 
            this.MusicZone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MusicZone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MusicZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MusicZone.Image = global::Muse_IC.Properties.Resources.MusicImage;
            this.MusicZone.Location = new System.Drawing.Point(237, 86);
            this.MusicZone.Name = "MusicZone";
            this.MusicZone.Size = new System.Drawing.Size(293, 239);
            this.MusicZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MusicZone.TabIndex = 1;
            this.MusicZone.TabStop = false;
            this.MusicZone.Click += new System.EventHandler(this.MusicZone_Click);
            this.MusicZone.MouseEnter += new System.EventHandler(this.MusicZone_MouseHover);
            this.MusicZone.MouseLeave += new System.EventHandler(this.MusicZone_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Muse_IC.Properties.Resources.FindFind;
            this.pictureBox3.Location = new System.Drawing.Point(712, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(403, 48);
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
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(89)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1116, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SingerZone);
            this.Controls.Add(this.AlbumsZone);
            this.Controls.Add(this.PodcastsZone);
            this.Controls.Add(this.MusicZone);
            this.Controls.Add(this.panel1);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SingerZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PodcastsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MusicZone;
        private System.Windows.Forms.PictureBox PodcastsZone;
        private System.Windows.Forms.PictureBox AlbumsZone;
        private System.Windows.Forms.PictureBox SingerZone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}