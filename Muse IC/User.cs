using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Muse_IC
{
    class User
    {
        private String _name;
        private String _bio;
        private String _email;
        private Boolean _private;
        private DateTime _birthday;
        private int _following;
        private int _followers;
        private List<Music> _myMusic;
        private List<Podcast> _myPodcasts;
        private List<Podcast> _upPod;
        private List<Music> _upMusic;
        private List<Album> _myAlbums = new List<Album>();
        private List<Series> _mySeries = new List<Series>();
        private List<String> _tags;
        private Image _pic;
        private String _password;
        private Queue<Message> _messages;
        private List<Music> singles = new List<Music>();
        private List<PlayList> _playLists = new List<PlayList>();

        private Favourite _fav = new Favourite();


        public static Dictionary<String, User> users = new Dictionary<string, User>();
        public static List<PlayList> globalPlayLists = new List<PlayList>();


        public String Username
        {
            get { return Name; }
            set { Name = value; }
        }

        public String email
        {
            get { return _email; }
            set { _email = value; }
        }
        public List<Album> myAlbums
        {
            get { return _myAlbums; }
            set { _myAlbums = value; }
        }
        public List<Series> mySeries
        {
            get { return _mySeries; }
            set { _mySeries = value; }
        }

        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        public int Following
        {
            get { return _following; }
            set { _following = value; }
        }
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int Followers
        {
            get { return _followers; }
            set { _followers = value; }
        }

        public Image Picture
        {
            get { return _pic; }
            set { _pic = value; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public List<String> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }
        public Queue<Message> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }
        public List<Podcast> upPod
        {
            get { return _upPod; }
            set { _upPod = value; }

        }
        public List<Music> upMusic
        {
            get { return _upMusic; }
            set { _upMusic = value; }

        }
        public List<PlayList> myPlaylist
        {
            get { return _playLists; }
            set { _playLists = value; }

        }
        public Favourite Favorite
        {
            get { return _fav; }
            set { _fav = value; }

        }
        public string Name { get => _name; set => _name = value; }
        internal List<Album> Albums { get => _myAlbums; set => _myAlbums = value; }
        public List<Music> Singles { get => singles; set => singles = value; }


        public bool ExisteAlbum(string name)
        {
            foreach (Album album in _myAlbums)
            {
                if (album.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddMusicToAlbum(string albumname, Music music)
        {
            foreach (Album album in _myAlbums)
            {
                if (album.Name.Equals(albumname))
                {
                    album.Musics.Add(music);
                    return;
                }
            }
        }
        public User(string email, string password, string Name = "", string bio = "", Boolean privateArg = false, DateTime birthday = new DateTime(), int following = 0, int followers = 0,
            List<String> tag = null, Queue<Message> mens = null, List<Music> mymusics = null, List<Podcast> mypods = null, List<Music> upmus = null, List<Podcast> upPods = null, Favourite favs = null)
        {
            this.Name = Name;
            _email = email;
            _bio = bio;
            _private = privateArg;
            _birthday = birthday;
            _followers = followers;
            _following = following;
            //tags
            if (tag == null)
            {
                _tags = new List<String>();
            }
            else
            {
                _tags = tag;
            }
            //Mensagens
            if (mens == null)
            {
                _messages = new Queue<Message>();
            }
            else
            {
                _messages = mens;
            }
            //mymusics
            if (mymusics == null)
            {
                _myMusic = new List<Music>();
            }
            else
            {
                _myMusic = mymusics;
            }
            //myPods
            if (mypods == null)
            {
                _myPodcasts = new List<Podcast>();
            }
            else
            {
                _myPodcasts = mypods;
            }
            //Upmud
            if (upmus == null)
            {
                _upMusic = new List<Music>();
            }
            else
            {
                _upMusic = upmus;
            }
            //UpPods
            if (upPods == null)
            {
                _upPod = new List<Podcast>();
            }
            else
            {
                _upPod = upPods;
            }
            //Fva
            if (favs == null)
            {
                _fav = new Favourite();
            }
            else
            {
                _fav = favs;
            }

        }
        public User()
        {

        }




        static User()
        {

            string[] Files = Directory.GetDirectories(@"..\\..\\Users");
            Music loadMusics = new Music();
            foreach (var Directory in Files)
            {
                DirectoryInfo file = new DirectoryInfo(Directory);
                String email = file.Name;
                String UserPath = System.IO.Path.Combine("..\\..\\Users", file.Name);
                String pathString = System.IO.Path.Combine(UserPath, "user.txt");
                string[] filelines = System.IO.File.ReadAllLines(pathString);
                String name = filelines[0].Split(':')[1];
                String password = filelines[1].Split(':')[1];
                User ex = new User(file.Name, password);
                ex.Name = name;
                try
                {
                    ex.Picture = Image.FromFile(Path.Combine(UserPath, "User.jpg"));
                }
                catch
                {
                    ex.Picture = Image.FromFile(Path.Combine(UserPath, "User.png"));
                }
                string[] liked = System.IO.Directory.GetFiles(Path.Combine(UserPath, "Liked"));
                foreach (var likedFile in liked)
                {
                    if (likedFile.Equals(Path.Combine(UserPath, "Liked", "Playlists.txt")))
                    {
                        string[] musics = System.IO.File.ReadAllLines(likedFile);
                        //Create playlist
                        foreach (String str in musics)
                        {
                            String[] splitted = str.Split('»');
                            PlayList pl = new PlayList();
                            if (splitted.Length > 0)
                            {
                                String plName = splitted[0];
                                Image plImage = Image.FromFile(Path.Combine(UserPath, "Liked", "Images", str.Split('»')[2]));
                                String dte = splitted[3];
                                pl.PlaylistName = (plName);
                                pl.Image = plImage;
                                pl.Date = dte;
                                String[] musicNames = str.Split('»')[1].Split(';');
                                foreach (String m in musicNames)
                                {
                                    foreach (Music ml in Music.musicsList)
                                    {
                                        if (ml.Name.Equals(m.Split('$')[0]) && ml.Singer.Equals(m.Split('$')[1]))
                                        {
                                            pl.Musics.Add(ml);
                                        }
                                    }

                                }
                                //Order: Likes, Shares, Views

                                Boolean priv = bool.Parse(splitted[4]);
                                if (priv != false)
                                {
                                    int plLikes = Int32.Parse(splitted[5]);
                                    int plShares = Int32.Parse(splitted[6]);
                                    int plViews = Int32.Parse(splitted[7]);
                                    String desc = splitted[8];
                                    foreach (String tag in splitted[9].Split(';'))
                                    {
                                        pl.tags.Add(tag);
                                    }

                                    foreach (String com in splitted[10].Split(';'))
                                    {
                                        Comment exCom = new Comment();
                                        String[] comSplit = com.Split(':');
                                        if (users.ContainsKey(comSplit[0]))
                                        {
                                            exCom.Author = users[comSplit[0]];

                                        }
                                        else
                                        {
                                            User unk = new User();
                                            unk.Name = comSplit[0];
                                        }
                                        exCom.Content = comSplit[1];
                                        exCom.Date = comSplit[2];
                                        exCom.Likes = Int32.Parse(comSplit[3]);
                                        pl.Comments.Add(exCom);
                                    }


                                    pl.Likes = plLikes;
                                    pl.Shares = plShares;
                                    pl.Views = plViews;
                                }

                                ex.myPlaylist.Add(pl);
                            }
                        }

                    }


                    if (likedFile.Equals(Path.Combine(UserPath, "Liked", "Favorites.txt")))
                    {
                        string[] musics = System.IO.File.ReadAllLines(likedFile);
                        if (musics.Length != 0)
                        {
                            //Create playlist
                            String str = musics[0];
                            String[] splitted = str.Split('»');
                            Favourite pl = new Favourite();
                            if (splitted.Length > 0)
                            {
                                Image plImage = Image.FromFile(Path.Combine(UserPath, "Liked", "Images", str.Split('»')[0]));

                                pl.Image = plImage;
                                String[] musicNames = str.Split('»')[1].Split(';');
                                foreach (String m in musicNames)
                                {
                                    foreach (Music ml in Music.musicsList)
                                    {
                                        if (ml.Name.Equals(m.Split('$')[0]) && ml.Singer.Equals(m.Split('$')[1]))
                                        {
                                            pl.Musics.Add(ml);
                                        }
                                    }
                                }
                            }

                            //Order: Likes, Shares, Views
                            String info = musics[1];
                            String[] splittedInfo = info.Split('»');
                            if (splittedInfo.Length > 0)
                            {
                                Boolean priv = bool.Parse(splittedInfo[0]);

                                pl.IsPrivate = priv;
                                if (priv != false)
                                {
                                    int plLikes = Int32.Parse(splittedInfo[1]);
                                    int plShares = Int32.Parse(splittedInfo[2]);
                                    int plViews = Int32.Parse(splittedInfo[3]);
                                    pl.Likes = plLikes;
                                    pl.Shares = plShares;
                                    pl.Views = plViews;
                                }

                            }
                            ex.Favorite = pl;
                        }
                    }

                }
               
                    if (ex.email != "LocalData")
                    {
                        string[] ups = System.IO.Directory.GetFiles(Path.Combine(UserPath, "Uploaded"));
                        {
                            foreach (String str in ups)
                            {
                                if (str.Equals(Path.Combine(UserPath, "Uploaded", "Music.txt")) && new FileInfo(str).Length > 0)
                                {
                                    string[] musicNames = System.IO.File.ReadAllLines(str);
                                    foreach (String mName in musicNames)
                                    {
                                        foreach (Music m in loadMusics.musics)
                                        {
                                            if (m.Name == mName && ex.Name == m.Singer)
                                            {
                                                ex.upMusic.Add(m);
                                                
                                            }
                                        }
                                    }

                                }

                                if (str.Equals(Path.Combine(UserPath, "Uploaded", "Album.txt")) && new FileInfo(str).Length > 0)
                                {
                                    string[] albumNames = System.IO.File.ReadAllLines(str);

                                    foreach (String aName in albumNames)
                                    {
                                        String[] split = aName.Split('»');
                                        if (split.Length == 2)
                                        {
                                            Album newA = new Album();
                                            newA.Name = split[0];
                                            newA.Date = split[1];
                                            if (ex.Name != null)
                                            {
                                                newA.Author = ex.Name;
                                            }
                                            else
                                                newA.Author = ex.email;
                                            ex.myAlbums.Add(newA);
                                            foreach (Music m in loadMusics.musics)
                                            {
                                                if (m.Album == newA.Name)
                                                {
                                                    newA.Musics.Add(m);
                                                }
                                            }
                                        }
                                        

                                    }

                                }
                            }
                        }
                    }
                    users.Add(ex.email, ex);
                
            }
            List<PlayList> localplayLists = users["LocalData"].myPlaylist;
            PlayList.playLists = localplayLists;
            Favourite.favourite = users["LocalData"].Favorite;
            

        }


    }
}
