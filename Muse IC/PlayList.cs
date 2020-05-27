using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse_IC
{
    class PlayList
    {
        private List<Music> musics;
        private string playlistName;
        private string date;
        private Image image;
        private bool isPrivate;
        private int views;
        private int shares;
        private int likes;
        private List<Comment> comments;
        private List<String> Tags = new List<string>();
        public static List<PlayList> playLists = new List<PlayList>();

        public PlayList(String playName="")
        {
            playlistName = playName;
            musics = new List<Music>();
            Comments = new List<Comment>();
        }
       
        public Image Image { get => image; set => image = value; }
        public string PlaylistName { get => playlistName; set => playlistName = value; }
        internal List<Music> Musics { get => musics; set => musics = value; }
        public string Date { get => date; set => date = value; }
        public bool IsPrivate { get => isPrivate; set => isPrivate = value; }
        public int Views { get => views; set => views = value; }
        public int Shares { get => shares; set => shares = value; }
        public int Likes { get => likes; set => likes = value; }
        internal List<Comment> Comments { get => comments; set => comments = value; }
        public List<String> tags { get => Tags; set => Tags = value; }
    }
}
