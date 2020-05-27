using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace Muse_IC
{
    public partial class Upload : Form
    {
        private List<Music> musicsToUpload;
        private App app;
        private User user;
        private bool fileType = true;
        private bool hasImg = false;
        public Upload(App app)
        {

            this.app = app;
            user = app.User;
            musicsToUpload = new List<Music>();
            InitializeComponent();
            Upload_Load();
        }

        private void Upload_Load()
        {
            if (fileType == true)
            {
                foreach (Album album in app.User.Albums)
                {
                    AlbumsBox.Items.Add(album.Name);
                }
                AlbumsBox.Items.Add("Single");
                AlbumsBox.SelectedIndex = 0;
                
            }
            else
            {
                foreach (Series serie in app.User.mySeries)
                {
                    AlbumsBox.Items.Add(serie.name);
                }
                AlbumsBox.Items.Add("Single");
                AlbumsBox.SelectedIndex = 0;
            }
                
            
           
        }
        private void AddMusicPanel_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            ofd.Title = "Upload your music";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            if (ofd.FileNames.Count() > 0)
            {
                if (ofd.FileNames.Count() > 1)
                    MusicNameBox.Enabled = false;
                else
                    MusicNameBox.Enabled = true;

                string[] paths = ofd.FileNames;

                for (int i = 0; i < paths.Count(); i++)
                {
                    Music music = new Music();
                    music.Path = paths[i];
                    music.Duration = Music.GetDuration(paths[i]);
                    music.Name = Path.GetFileNameWithoutExtension(ofd.FileNames[i]);
                    musicsToUpload.Add(music);
                }
                AddMusicIcon.IconChar = IconChar.Music;
                label8.Text = "Music File Added";
            }

        }


        private void AddMusicPanel_MouseEnter(object sender, EventArgs e)
        {
            AddMusicPanel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void AddMusicPanel_MouseLeave(object sender, EventArgs e)
        {
            AddMusicPanel.BorderStyle = BorderStyle.FixedSingle;
        }
        private void CoverPanel_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.Title = "Upload a cover picture";
            ofd.Multiselect = false;
            ofd.ShowDialog();

            if (ofd.FileName.Trim().Length > 0)
            {
                CoverPicture.Image = Image.FromFile(ofd.FileName);
                hasImg = true;
            }
            label9.Text = "Cover Picture Added";
        }


        private void CoverPanel_MouseEnter(object sender, EventArgs e)
        {
            CoverPanel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void CoverPanel_MouseLeave(object sender, EventArgs e)
        {
            CoverPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void PrivateIcon_Click(object sender, EventArgs e)
        {
            if (PrivateIcon.IconChar == IconChar.ToggleOn)
                PrivateIcon.IconChar = IconChar.ToggleOff;
            else
                PrivateIcon.IconChar = IconChar.ToggleOn;
        }
        private void MusicOrPodcastIcon_Click(object sender, EventArgs e)
        {
            if (MusicOrPodcastIcon.IconChar == IconChar.ToggleOn)
            {
                MusicOrPodcastIcon.IconChar = IconChar.ToggleOff;
                AlbumsOrSeries.Text = "Series:";
                fileType = false;
                AlbumsBox.Items.Clear();
                Upload_Load();

            }
            else
            {
                MusicOrPodcastIcon.IconChar = IconChar.ToggleOn;
                fileType = true;
                AlbumsOrSeries.Text = "Albums:";
                AlbumsBox.Items.Clear();
                Upload_Load();
            }
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if (musicsToUpload.Count == 0 | (MusicNameBox.Text.Trim().Length < 1))
            {
                MessageBox.Show("No music to upload or Name box is empty!");
                return;
            }


            if (musicsToUpload.Count == 1)
            {
                musicsToUpload[0].Name = MusicNameBox.Text;
                musicsToUpload[0].Album = AlbumsBox.SelectedItem.ToString(); 
                musicsToUpload[0].Image = CoverPicture.Image;
                
                foreach (String tag in TagsBox.Text.Split(','))
                    musicsToUpload[0].Tags.Add(tag);
               
                musicsToUpload[0].Description = DescriptionBox.Text;
                if (AlbumsBox.SelectedItem.ToString().Equals("Single"))
                    app.User.Singles.Add(musicsToUpload[0]);
                else
                    app.User.AddMusicToAlbum(AlbumsBox.SelectedItem.ToString(), musicsToUpload[0]);
                Music music = musicsToUpload[0];
                String newPath = Path.Combine("..\\..\\Musics\\", music.Name + "$" + this.app.User.Name);
                System.IO.Directory.CreateDirectory(newPath);
                System.IO.File.WriteAllText(Path.Combine(newPath, "musicInfo.txt"), music.Album + "\n" + music.Duration);
                System.IO.File.Copy(music.Path, Path.Combine(newPath, music.Name+".mp3"));
                music.Singer = user.Name;
                if (hasImg)
                    music.Image = CoverPicture.Image;
                app.User.upMusic.Add(music);
                StreamWriter sw = File.AppendText(Path.Combine("..\\..\\Users", user.email, "Uploaded", "Music.txt"));
                sw.WriteLine("\n" + music.Name);
                sw.Close();
            }
            else
            {
                foreach (Music music in musicsToUpload)
                {
                    music.Album = AlbumsBox.SelectedItem.ToString(); ;
                    music.Image = CoverPicture.Image;
                    music.Tags.AddRange(TagsBox.Text.Split(new char[] { ',' }));
                    music.Description = DescriptionBox.Text;
                    if (hasImg)
                        music.Image = CoverPicture.Image;
                    if (AlbumsBox.SelectedItem.ToString().Equals("Single"))
                        app.User.Singles.Add(music);
                    else
                        app.User.AddMusicToAlbum(AlbumsBox.SelectedItem.ToString(), music);
                    String newPath = Path.Combine("..\\..\\Musics\\", music.Name + "$" + this.app.User.Name);
                    System.IO.Directory.CreateDirectory(newPath);
                    System.IO.File.Create(Path.Combine(newPath, "musicInfo.txt"));
                    System.IO.File.WriteAllText(Path.Combine(newPath, "musicInfo.txt"), music.Album + "\n" + music.Duration);
                    System.IO.File.Copy(music.Path, Path.Combine(newPath, music.Name));

                    app.User.upMusic.Add(music);
                    StreamWriter sw = File.AppendText(Path.Combine("..\\..\\Users", user.email, "Uploaded", "Music.txt"));
                    sw.WriteLine("\n" + music.Name);
                    sw.Close();
                }
            }
            MessageBox.Show("Music uploaded!");
            AlbumsBox.SelectedIndex = 0;
            MusicNameBox.Text = "";
            DescriptionBox.Text = "";
            TagsBox.Text = "";
            label9.Text = "(Click Here to add cover picture)";
            label8.Text = "(Click Here to add music)";
            musicsToUpload.Clear();
            CoverPicture.Image = Properties.Resources.Image;
            hasImg = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album();
            if (NewAlbumName.Text != "")
            {
                newAlbum.Name = NewAlbumName.Text;
                user.myAlbums.Add(newAlbum);
                AlbumsBox.Items.Clear();
                Upload_Load();
            }
            StreamWriter sw = File.AppendText(Path.Combine("..\\..\\Users", user.email, "Uploaded", "Album.txt"));
            sw.WriteLine("\n" + newAlbum.Name);
            
            panelAddAlbum.Visible = false;
        }

        private void CreateSeries_Click(object sender, EventArgs e)
        {
            Series newSeries = new Series();
            if (newSeriesName.Text != "")
            {
                newSeries.name = newSeriesName.Text;
                user.mySeries.Add(newSeries);
                AlbumsBox.Items.Clear();
                Upload_Load();
            }
            StreamWriter sw = File.AppendText(Path.Combine("..\\..\\Users", user.email, "Uploaded", "Series.txt"));
            sw.WriteLine("\n" +newSeries.name);
            panelAddSeries.Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
         if (fileType==true)
            {
                panelAddAlbum.Visible = true;
            }
            else
            {
                panelAddSeries.Visible = true;
            }
                   

             
        }

        private void CancelAlbum_Click(object sender, EventArgs e)
        {
            panelAddAlbum.Visible = false;
        }

        private void CancelSeries_Click(object sender, EventArgs e)
        {
            panelAddSeries.Visible = false;
        }
    }
}

