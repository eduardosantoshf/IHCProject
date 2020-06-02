namespace Muse_IC
{
    partial class Upload
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
            this.UpFileButton = new System.Windows.Forms.Button();
            this.PicUpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T = new System.Windows.Forms.Label();
            this.PodDescLabel = new System.Windows.Forms.Label();
            this.CommenterName = new System.Windows.Forms.Label();
            this.TypeButton = new FontAwesome.Sharp.IconPictureBox();
            this.PodcastLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.TagsText = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // UpFileButton
            // 
            this.UpFileButton.Location = new System.Drawing.Point(152, 12);
            this.UpFileButton.Name = "UpFileButton";
            this.UpFileButton.Size = new System.Drawing.Size(283, 183);
            this.UpFileButton.TabIndex = 0;
            this.UpFileButton.Text = "Upload";
            this.UpFileButton.UseVisualStyleBackColor = true;
            // 
            // PicUpButton
            // 
            this.PicUpButton.Location = new System.Drawing.Point(666, 12);
            this.PicUpButton.Name = "PicUpButton";
            this.PicUpButton.Size = new System.Drawing.Size(283, 183);
            this.PicUpButton.TabIndex = 1;
            this.PicUpButton.Text = "UploadPic";
            this.PicUpButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.TagsText);
            this.panel1.Controls.Add(this.DescriptionText);
            this.panel1.Controls.Add(this.T);
            this.panel1.Controls.Add(this.PodDescLabel);
            this.panel1.Controls.Add(this.CommenterName);
            this.panel1.Location = new System.Drawing.Point(118, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 288);
            this.panel1.TabIndex = 2;
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Cursor = System.Windows.Forms.Cursors.Hand;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.T.Location = new System.Drawing.Point(29, 188);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(57, 25);
            this.T.TabIndex = 15;
            this.T.Text = "Tags";
            // 
            // PodDescLabel
            // 
            this.PodDescLabel.AutoSize = true;
            this.PodDescLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PodDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PodDescLabel.Location = new System.Drawing.Point(29, 65);
            this.PodDescLabel.Name = "PodDescLabel";
            this.PodDescLabel.Size = new System.Drawing.Size(109, 25);
            this.PodDescLabel.TabIndex = 14;
            this.PodDescLabel.Text = "Description";
            // 
            // CommenterName
            // 
            this.CommenterName.AutoSize = true;
            this.CommenterName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CommenterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CommenterName.Location = new System.Drawing.Point(29, 24);
            this.CommenterName.Name = "CommenterName";
            this.CommenterName.Size = new System.Drawing.Size(84, 25);
            this.CommenterName.TabIndex = 13;
            this.CommenterName.Text = "SERIES";
            // 
            // TypeButton
            // 
            this.TypeButton.BackColor = System.Drawing.SystemColors.Control;
            this.TypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.TypeButton.IconChar = FontAwesome.Sharp.IconChar.ToggleOn;
            this.TypeButton.IconColor = System.Drawing.Color.LimeGreen;
            this.TypeButton.IconSize = 73;
            this.TypeButton.Location = new System.Drawing.Point(733, 224);
            this.TypeButton.Name = "TypeButton";
            this.TypeButton.Size = new System.Drawing.Size(216, 73);
            this.TypeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TypeButton.TabIndex = 35;
            this.TypeButton.TabStop = false;
            this.TypeButton.Click += new System.EventHandler(this.Podcast_Click);
            // 
            // PodcastLabel
            // 
            this.PodcastLabel.AutoSize = true;
            this.PodcastLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PodcastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PodcastLabel.Location = new System.Drawing.Point(728, 239);
            this.PodcastLabel.Name = "PodcastLabel";
            this.PodcastLabel.Size = new System.Drawing.Size(83, 25);
            this.PodcastLabel.TabIndex = 16;
            this.PodcastLabel.Text = "Podcast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(870, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Music";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(144, 69);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(654, 102);
            this.DescriptionText.TabIndex = 16;
            // 
            // TagsText
            // 
            this.TagsText.Location = new System.Drawing.Point(144, 192);
            this.TagsText.Multiline = true;
            this.TagsText.Name = "TagsText";
            this.TagsText.Size = new System.Drawing.Size(654, 43);
            this.TagsText.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 663);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PodcastLabel);
            this.Controls.Add(this.TypeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PicUpButton);
            this.Controls.Add(this.UpFileButton);
            this.Name = "Upload";
            this.Text = "SS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpFileButton;
        private System.Windows.Forms.Button PicUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Label PodDescLabel;
        private System.Windows.Forms.Label CommenterName;
        private System.Windows.Forms.TextBox DescriptionText;
        private FontAwesome.Sharp.IconPictureBox TypeButton;
        private System.Windows.Forms.Label PodcastLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TagsText;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}