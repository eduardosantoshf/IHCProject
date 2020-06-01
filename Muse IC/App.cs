using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace Muse_IC
{
    public partial class App : Form
    {

        private Form activeForm = null;
        private List<Music> musics = new List<Music>();
        private int currentMusic = 0;
        private System.Timers.Timer timer;
        private User user;

        internal List<Music> Musics { get => musics; set => musics = value; }
        internal User User { get => user; set => user = value; }

        private delegate void SetControlValue(string value);
        public App()
        {
            
            User = User.users["LocalData"];

            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            App_load();
            InitUserInfo();
        }

        public App(string useremial)
        {
            User=User.users[useremial];
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            App_load();
            InitUserInfo();
        }

        private void App_load()
        {
            ProgressBar mbp = new ProgressBar(this, 200, 200, 200, 8);
            this.Controls.Add(mbp.picFocus);
            this.Controls.Add(mbp.lblbottom);

            mbp.picFocus.MouseDown += new MouseEventHandler(mbp.picFocus_MouseDown);
            mbp.picFocus.MouseMove += new MouseEventHandler(mbp.picFocus_MouseMove);
            mbp.picFocus.MouseUp += new MouseEventHandler(mbp.picFocus_MouseUp);

            Player.settings.autoStart = false;
            musics = Music.musicsList;
          
            InitMusicInfo();
            OpenChildForm(new FindForm(this));
           
        }

        private void InitMusicInfo()
        {
            MusicName.Text = Musics[currentMusic].Name;
            Singer.Text = Musics[currentMusic].Singer;
            MusicPicture.Image = Musics[currentMusic].Image == null ? Properties.Resources.Music : Musics[currentMusic].Image;
        }
        public void InitUserInfo()
        {
            if (user.email != "LocalData")
            {
                UserName.Text = user.Name;
                UserPicture.Image = user.Picture;
                UserName.Visible = true;
                LoginLabel.Visible = false;
                LognOutIcon.Visible = true;
                UploadBtn.Enabled = true;
                MySongBtn.Enabled = true;
            }
            else
            {
                LoginLabel.Location = UserName.Location;
                UserName.Visible = false;
                LoginLabel.Visible = true;
                LognOutIcon.Visible = false;
                UploadBtn.Enabled = false;
                MySongBtn.Enabled = false;
            }

        }
        public void Play(string musicname)
        {   
            int index = 0;
            foreach(Music music in musics)
            {
                if (music.Name.Equals(musicname))
                {
                    Player.URL = music.Path;
                    Player.Ctlcontrols.play();
                    PlayIcon.IconChar = IconChar.PauseCircle;
                    MusicName.Text = music.Name;
                    Singer.Text = music.Singer;
                    InitTimer();
                    currentMusic = index;
                    InitMusicInfo();
                    return;
                }
                index++;
            }
        }
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            ChildFormPanel.Controls.Add(childForm);
            ChildFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void FindBtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FindForm(this));
            Reset(sender);
        }

        private void FriendsBtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FriendsForm(this));
            Reset(sender);
        }

        private void FavouriteBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FavouriteForm(this));
            Reset(sender);
        }

        private void PlayListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlayListForm(this));
            Reset(sender);
        }

        private void MySongBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new myUploads(this));
            Reset(sender);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Upload(this));
            Reset(sender);
        }

        private void Reset(object sender)
        {
            if (sender != null)
            {
                IconButton currtenBtn = (IconButton)sender;
                CurrentIcon.IconChar = currtenBtn.IconChar;
                CurrentName.Text = currtenBtn.Text;
                CurrentIcon.IconSize = 30;
            }
        }

        private void NextIcon_MouseEnter(object sender, EventArgs e)
        {
            NextIcon.IconColor = Color.PapayaWhip;
        }

        private void NextIcon_MouseLeave(object sender, EventArgs e)
        {
            NextIcon.IconColor = Color.Moccasin;
        }

        private void PlayIcon_MouseEnter(object sender, EventArgs e)
        {
            PlayIcon.IconColor = Color.PapayaWhip;
        }

        private void PlayIcon_MouseLeave(object sender, EventArgs e)
        {
            PlayIcon.IconColor = Color.Moccasin;
        }

        private void PreviousIcon_MouseEnter(object sender, EventArgs e)
        {
            PreviousIcon.IconColor = Color.PapayaWhip;
        }

        private void PreviousIcon_MouseLeave(object sender, EventArgs e)
        {
            PreviousIcon.IconColor = Color.Moccasin;
        }

        private void Home_MouseEnter(object sender, EventArgs e)
        {
            Home.ForeColor=Color.PapayaWhip;
        }

        private void Home_MouseLeave(object sender, EventArgs e)
        {
            Home.ForeColor = Color.Moccasin;
        }

       

        private void Library_MouseEnter(object sender, EventArgs e)
        {
            Library.ForeColor = Color.PapayaWhip;
        }

        private void Library_MouseLeave(object sender, EventArgs e)
        {
            Library.ForeColor = Color.Moccasin;
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            Help.ForeColor = Color.PapayaWhip;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Home.ForeColor = Color.Moccasin;
        }

        private void VolumeIcon_Click(object sender, EventArgs e)
        {
            if (VolumeIcon.IconChar == IconChar.VolumeDown)
            {
                VolumeIcon.IconChar = IconChar.VolumeMute;
                Player.settings.mute = true;
            }
            else if (VolumeIcon.IconChar == IconChar.VolumeMute)
            {
                VolumeIcon.IconChar = IconChar.VolumeDown;
                Player.settings.mute = false;
            }
                
        }

        private void VolumeIcon_MouseEnter(object sender, EventArgs e)
        {
            VolumeIcon.IconColor = Color.PapayaWhip;
        }

        private void VolumeIcon_MouseLeave(object sender, EventArgs e)
        {
            VolumeIcon.IconColor = Color.Moccasin;
        }

        private void ModeIcon_MouseEnter(object sender, EventArgs e)
        {
            ModeIcon.IconColor = Color.PapayaWhip;
        }

        private void ModeIcon_MouseLeave(object sender, EventArgs e)
        {
            ModeIcon.IconColor = Color.Moccasin;
        }

        private void HistoryIcon_MouseEnter(object sender, EventArgs e)
        {
            HistoryIcon.IconColor = Color.PapayaWhip;
        }

        private void HistoryIcon_MouseLeave(object sender, EventArgs e)
        {
            HistoryIcon.IconColor = Color.Moccasin;
        }
        private void SingOutIcon_MouseEnter(object sender, EventArgs e)
        {
            LognOutIcon.IconColor = Color.PapayaWhip;
        }

        private void SingOutIcon_MouseLeave(object sender, EventArgs e)
        {
            LognOutIcon.IconColor = Color.Moccasin;
        }

        private void EnvelopeIcon_MouseEnter(object sender, EventArgs e)
        {
            EnvelopeIcon.IconColor = Color.PapayaWhip;
        }

        private void EnvelopeIcon_MouseLeave(object sender, EventArgs e)
        {
            EnvelopeIcon.IconColor = Color.Moccasin;
        }

        private void PlayIcon_Click(object sender, EventArgs e)
        {
            if (Player.URL == "")
            {
                Player.URL = Musics[currentMusic].Path;
                InitTimer();
                MusicStatus.Value = 0;
            }
            

            if (PlayIcon.IconChar == IconChar.PlayCircle)
            {
                PlayIcon.IconChar = IconChar.PauseCircle;
                Player.Ctlcontrols.play();
            }
            else if (PlayIcon.IconChar == IconChar.PauseCircle)
            {
                PlayIcon.IconChar = IconChar.PlayCircle;
                Player.Ctlcontrols.pause();
            }
            InitMusicInfo();
        }

        public void InitTimer(){
            if (timer != null)
            {
                timer.Stop();
                timer = null;
            }

            TimeLeft.Text = "00:00";
            TimeRight.Text = Music.GetDuration(Player.URL);
            MusicStatus.Maximum = Music.GetSeconds(Player.URL);

            foreach (Music music in Musics)
            {
                if (music.Name.Equals(MusicName.Text))
                {
                    music.Duration = TimeRight.Text;
                }
            }
            int interval = 1000;
             timer = new System.Timers.Timer(interval);
             timer.AutoReset = true;
             timer.Enabled = true;
             timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerUp);
        }

       

        private void TimerUp(object sender, System.Timers.ElapsedEventArgs e)
         {
             try
            {
                 Invoke(new SetControlValue(SetTime),Player.Ctlcontrols.currentPositionString);
                
             }
             catch (Exception ex)
             {
                Console.Write("Exception Caught:", ex);
            }
         }

        private void SetTime(string value)
        {
            TimeLeft.Text = value;
            TimeRight.Text = Player.currentMedia.durationString;
            
            if (MusicStatus.Value+1==MusicStatus.Maximum)
            {
                MusicStatus.Value = 0;
            }
            else
            {
                if (PlayIcon.IconChar != IconChar.PlayCircle)
                    MusicStatus.Value++;
            }

        }


        private void PreviousIcon_Click(object sender, EventArgs e)
        {
            MusicStatus.Value = 0;
            PlayIcon.IconChar = IconChar.PauseCircle;
            if (currentMusic - 1 < 0)
            {
                currentMusic = 0;
            }
            else
            {
                currentMusic -= 1;
            }
            Music music = Musics[currentMusic];
            Player.URL = music.Path;
            MusicStatus.Maximum = (Music.GetSeconds(music.Path));
            Player.Ctlcontrols.play();
            InitMusicInfo();
            InitTimer();
        }

        

        private void NextIcon_Click(object sender, EventArgs e)
        {
            MusicStatus.Value = 0;
            PlayIcon.IconChar = IconChar.PauseCircle;
            if (currentMusic + 1 == Musics.Count)
            {
                currentMusic = 0;
            }
            else
            {
                currentMusic += 1;
            }
            Music music = Musics[currentMusic];
            MusicStatus.Maximum = Music.GetSeconds(music.Path);
            Player.URL = music.Path;
            Player.Ctlcontrols.play();
            InitMusicInfo();
            InitTimer();
        }

        private void SingOutIcon_Click(object sender, EventArgs e)
        {
            this.User = new User();
            Login app = new Login(false);
            
            app.StartPosition = FormStartPosition.CenterParent;
            Hide();
            app.ShowDialog();
            Application.ExitThread();
            DialogResult = DialogResult.OK;
            Dispose();
        }
        private void GoLogin_Click(object sender, EventArgs e)
        {
            this.User = new User();
            Login login = new Login(true);
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                user = User.users[login.UserNameBox.Text];
                /*if (activeForm != null)
                {
                    MyChildForm myChildForm = (MyChildForm)activeForm;
                    InitUserInfo();
                }*/
            }
            InitUserInfo();
        }
        private void CurrentMusicPanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MusicForm(this, musics[currentMusic]));
        }

        private void App_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FindForm(this));
        }

        private void Home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FindForm(this));
        }


        private void Library_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PlayListForm(this));
        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void FindBtn_MouseEnter(object sender, EventArgs e)
        {
            FindBtn.BackColor = Color.FromArgb(130, 160, 177);
        }

        private void FindBtn_MouseLeave(object sender, EventArgs e)
        {
            FindBtn.BackColor = Color.FromArgb(104, 134, 177); 
        }

        private void FriendsBtn_MouseEnter(object sender, EventArgs e)
        {
            FriendsBtn.BackColor = Color.FromArgb(130, 160, 177);
        }

        private void FriendsBtn_MouseLeave(object sender, EventArgs e)
        {
            FriendsBtn.BackColor = Color.FromArgb(104, 134, 177);
        }

        private void MySongBtn_MouseEnter(object sender, EventArgs e)
        {
            MySongBtn.BackColor = Color.FromArgb(130, 160, 177);
        }

        private void MySongBtn_MouseLeave(object sender, EventArgs e)
        {
            MySongBtn.BackColor = Color.FromArgb(104, 134, 177);
        }
        private void FavouriteBtn_MouseEnter(object sender, EventArgs e)
        {
            FavouriteBtn.BackColor = Color.FromArgb(130, 160, 177);
        }

        private void FavouriteBtn_MouseLeave(object sender, EventArgs e)
        {
            FavouriteBtn.BackColor = Color.FromArgb(104, 134, 177);
        }
        private void PlayListBtn_MouseEnter(object sender, EventArgs e)
        {
            PlayListBtn.BackColor = Color.FromArgb(130, 160, 177);
        }

        private void PlayListBtn_MouseLeave(object sender, EventArgs e)
        {
            PlayListBtn.BackColor = Color.FromArgb(104, 134, 177);
        }

        private void UploadBtn_MouseEnter(object sender, EventArgs e)
        {
            UploadBtn.BackColor = Color.FromArgb(130, 160, 177);
        }

        private void UploadBtn_MouseLeave(object sender, EventArgs e)
        {
            UploadBtn.BackColor = Color.FromArgb(104, 134, 177);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.MintCream;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.LightCyan;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    interface MyChildForm
    {
        void InitUserInfo();
    }
}
