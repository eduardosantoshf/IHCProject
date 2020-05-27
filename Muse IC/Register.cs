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

namespace Muse_IC
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Regiter_load();
        }

        private void Regiter_load()
        {
            ToolTip toolTip1 = new ToolTip();

            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(info, "Alguma coisa aqui");
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            String email = EmailBox.Text;
            String pathString = System.IO.Path.Combine("..\\..\\Users", email);
            if (!System.IO.File.Exists(pathString))
            {
                DialogResult = DialogResult.OK;
                System.IO.Directory.CreateDirectory(pathString);
                String Liked = Path.Combine(pathString, "Liked");
                Directory.CreateDirectory(Liked);
                File.Create(Path.Combine(Liked, "Playlists.txt"));
                System.IO.File.Create(Path.Combine(Liked, "Podcasts.txt"));
                System.IO.File.Create(Path.Combine(Liked, "Favorites.txt"));
                System.IO.Directory.CreateDirectory(Path.Combine(Liked, "Images"));
                File.Copy("..\\..\\Resources\\Playlist.jpg", Path.Combine(Liked, "Images\\Default.jpg"));
                String Upload = Path.Combine(pathString, "Uploaded");
                Directory.CreateDirectory(Upload);
                System.IO.File.Create(Path.Combine(Upload, "Podcasts.txt"));
                System.IO.File.Create(Path.Combine(Upload, "Music.txt"));
                System.IO.File.Create(Path.Combine(Upload, "Album.txt"));
                System.IO.File.Create(Path.Combine(Upload, "Series.txt"));

                String Image = Path.Combine(pathString, "User.png");
                
                File.Copy("..\\..\\Resources\\User.png",Image);
                using (StreamWriter outputFile = new StreamWriter(System.IO.File.Create(Path.Combine(pathString, "user.txt"))))
                {
                    outputFile.WriteLine("Name:" + NameBox.Text );
                    outputFile.WriteLine("Pass:" + PwdText.Text);
                    outputFile.WriteLine("Birthday:" + BirthdayPicker.Text);
                }
            }
                
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
