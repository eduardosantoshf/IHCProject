using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse_IC
{
    public partial class FindForm : Form
    {
        private Size musicSize;
        private Size singerSize;
        private Size podacastsSize;
        private Size albumsSize;
        private App app;
        public FindForm(App app)
        {
            this.app = app;
            InitializeComponent();
            musicSize = MusicZone.Size;
            singerSize = SingerZone.Size;
            albumsSize = AlbumsZone.Size;
            podacastsSize = PodcastsZone.Size;
        }

        private void MusicZone_MouseHover(object sender, EventArgs e)
        {
            MusicZone.Size = new Size(musicSize.Width+5,musicSize.Height+5);
        }

        private void MusicZone_MouseLeave(object sender, EventArgs e)
        {
            MusicZone.Size = musicSize;
        }

        private void SingerZone_MouseHover(object sender, EventArgs e)
        {
            SingerZone.Size = new Size(singerSize.Width + 5, singerSize.Height + 5);
        }

        private void SingerZone_MouseLeave(object sender, EventArgs e)
        {
            SingerZone.Size = singerSize;
        }

        private void AlbumsZone_MouseHover(object sender, EventArgs e)
        {
            AlbumsZone.Size = new Size(albumsSize.Width + 5, albumsSize.Height + 5);
        }

        private void AlbumsZone_MouseLeave(object sender, EventArgs e)
        {
            AlbumsZone.Size = albumsSize;
        }

        private void PodcastsZone_MouseHover(object sender, EventArgs e)
        {
            PodcastsZone.Size = new Size(podacastsSize.Width + 5, podacastsSize.Height + 5);
        }

        private void PodcastsZone_MouseLeave(object sender, EventArgs e)
        {
            PodcastsZone.Size = podacastsSize;
        }

        private void MusicZone_Click(object sender, EventArgs e)
        {
            app.OpenChildForm(new FindMusicForm(app));
        }
    }
}
