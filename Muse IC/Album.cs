using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Muse_IC
{
    class Album
    {
        private string name;
        private string date;
        private string author;
        private List<Music> musics = new List<Music>();
        private Image image;
        private bool isPrivate;
        private int views;
        private int shares;
        private int likes;
        private List<Comment> comments;
        private static List<Album> playLists = new List<Album>();

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Date { get => date; set => date = value; }
        internal List<Music> Musics { get => musics; set => musics = value; }
        public Image Image { get => image; set => image = value; }
        public bool IsPrivate { get => isPrivate; set => isPrivate = value; }
        public int Views { get => views; set => views = value; }
        public int Shares { get => shares; set => shares = value; }
        public int Likes { get => likes; set => likes = value; }
        internal List<Comment> Comments { get => comments; set => comments = value; }
        internal static List<Album> PlayLists { get => playLists; set => playLists = value; }
    }
}
