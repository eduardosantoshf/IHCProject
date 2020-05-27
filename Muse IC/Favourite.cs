using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse_IC
{
    class Favourite
    {
        private List<Music> musics;
        private string description;
        private List<string> tags;
        private bool isPrivate;
        private int likes;
        private int views;
        private int shares;
        private Image image;
        public Favourite()
        {
            musics = new List<Music>();
        }

        public static Favourite favourite;
        public string Description { get => description; set => description = value; }
        public List<string> Tags { get => tags; set => tags = value; }
        public bool IsPrivate { get => isPrivate; set => isPrivate = value; }
        public int Views { get => views; set => views = value; }
        internal List<Music> Musics { get => musics; set => musics = value; }
        public Image Image { get => image; set => image = value; }
        public int Likes { get => likes; set => likes = value; }
        public int Shares { get => shares; set => shares = value; }
    }
}
