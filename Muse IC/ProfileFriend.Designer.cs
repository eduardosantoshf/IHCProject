namespace Muse_IC
{
    partial class ProfileFriend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.Cancel = new FontAwesome.Sharp.IconPictureBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Topic = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UploadedBtn = new System.Windows.Forms.Button();
            this.MusicListView = new System.Windows.Forms.ListView();
            this.Bio = new System.Windows.Forms.Label();
            this.Tag = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnvelopeIcon = new FontAwesome.Sharp.IconPictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Friend1Picture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvelopeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Friend1Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.MessagePanel);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.UploadedBtn);
            this.panel1.Controls.Add(this.MusicListView);
            this.panel1.Controls.Add(this.Bio);
            this.panel1.Controls.Add(this.Tag);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EnvelopeIcon);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Friend1Picture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 623);
            this.panel1.TabIndex = 0;
            // 
            // MessagePanel
            // 
            this.MessagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagePanel.Controls.Add(this.Cancel);
            this.MessagePanel.Controls.Add(this.SendBtn);
            this.MessagePanel.Controls.Add(this.label5);
            this.MessagePanel.Controls.Add(this.Message);
            this.MessagePanel.Controls.Add(this.label1);
            this.MessagePanel.Controls.Add(this.Topic);
            this.MessagePanel.Location = new System.Drawing.Point(115, 121);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(708, 308);
            this.MessagePanel.TabIndex = 29;
            this.MessagePanel.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.ForeColor = System.Drawing.Color.Brown;
            this.Cancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Cancel.IconColor = System.Drawing.Color.Brown;
            this.Cancel.Location = new System.Drawing.Point(650, 3);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(32, 32);
            this.Cancel.TabIndex = 5;
            this.Cancel.TabStop = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendBtn.Location = new System.Drawing.Point(565, 259);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(76, 35);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Message";
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Message.Location = new System.Drawing.Point(114, 66);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(527, 187);
            this.Message.TabIndex = 2;
            this.Message.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic";
            // 
            // Topic
            // 
            this.Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Topic.Location = new System.Drawing.Point(114, 18);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(305, 30);
            this.Topic.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(605, 267);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 34);
            this.button7.TabIndex = 28;
            this.button7.Text = "Podcasts";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(414, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 34);
            this.button5.TabIndex = 27;
            this.button5.Text = "Playlists";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(210, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 34);
            this.button2.TabIndex = 24;
            this.button2.Text = "Albums";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UploadedBtn
            // 
            this.UploadedBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UploadedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UploadedBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadedBtn.Location = new System.Drawing.Point(35, 267);
            this.UploadedBtn.Name = "UploadedBtn";
            this.UploadedBtn.Size = new System.Drawing.Size(122, 34);
            this.UploadedBtn.TabIndex = 23;
            this.UploadedBtn.Text = "Uploaded";
            this.UploadedBtn.UseVisualStyleBackColor = false;
            // 
            // MusicListView
            // 
            this.MusicListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MusicListView.HideSelection = false;
            this.MusicListView.Location = new System.Drawing.Point(45, 318);
            this.MusicListView.Name = "MusicListView";
            this.MusicListView.Size = new System.Drawing.Size(793, 279);
            this.MusicListView.TabIndex = 18;
            this.MusicListView.UseCompatibleStateImageBehavior = false;
            // 
            // Bio
            // 
            this.Bio.AutoSize = true;
            this.Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bio.Location = new System.Drawing.Point(106, 191);
            this.Bio.Name = "Bio";
            this.Bio.Size = new System.Drawing.Size(53, 20);
            this.Bio.TabIndex = 17;
            this.Bio.Text = "label5";
            // 
            // Tag
            // 
            this.Tag.AutoSize = true;
            this.Tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tag.Location = new System.Drawing.Point(315, 121);
            this.Tag.Name = "Tag";
            this.Tag.Size = new System.Drawing.Size(53, 20);
            this.Tag.TabIndex = 16;
            this.Tag.Text = "label5";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Birthday.Location = new System.Drawing.Point(315, 85);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(53, 20);
            this.Birthday.TabIndex = 15;
            this.Birthday.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Bio:";
            // 
            // EnvelopeIcon
            // 
            this.EnvelopeIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnvelopeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnvelopeIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnvelopeIcon.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.EnvelopeIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.EnvelopeIcon.IconSize = 48;
            this.EnvelopeIcon.Location = new System.Drawing.Point(762, 16);
            this.EnvelopeIcon.Name = "EnvelopeIcon";
            this.EnvelopeIcon.Size = new System.Drawing.Size(61, 48);
            this.EnvelopeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EnvelopeIcon.TabIndex = 13;
            this.EnvelopeIcon.TabStop = false;
            this.EnvelopeIcon.Click += new System.EventHandler(this.EnvelopeIcon_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(730, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Unfollow";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(205, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tag:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(205, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Birthday:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username.Location = new System.Drawing.Point(205, 35);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(96, 29);
            this.Username.TabIndex = 9;
            this.Username.Text = "Friend1";
            // 
            // Friend1Picture
            // 
            this.Friend1Picture.Image = global::Muse_IC.Properties.Resources.Uer;
            this.Friend1Picture.Location = new System.Drawing.Point(35, 16);
            this.Friend1Picture.Name = "Friend1Picture";
            this.Friend1Picture.Size = new System.Drawing.Size(164, 148);
            this.Friend1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Friend1Picture.TabIndex = 8;
            this.Friend1Picture.TabStop = false;
            // 
            // ProfileFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 623);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileFriend";
            this.Text = "ProfileFriend";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvelopeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Friend1Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Friend1Picture;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox EnvelopeIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Bio;
        private System.Windows.Forms.Label Tag;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UploadedBtn;
        private System.Windows.Forms.ListView MusicListView;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel MessagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Message;
        private System.Windows.Forms.Button SendBtn;
        private FontAwesome.Sharp.IconPictureBox Cancel;
    }
}