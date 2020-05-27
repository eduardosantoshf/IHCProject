using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace Muse_IC
{
    public class Music
    {
        private string name;
        private string singer = "Anonimous";
        private string album = "NoName";
        private string path;
        private string duration;
        private Image image;
        private String description;
        private List<String> tags = new List<String>();
        public static List<Music> musicsList = new List<Music>();
        

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public String Duration { get => duration; set => duration = value; }
        public String Singer { get => singer; set => singer = value; }
        public String Album { get => album; set => album = value; }
        public Image Image { get => image; set => image = value; }
        public List<String> Tags { get => tags; set => tags = value; }
        public List<Music> musics { get => musicsList; set => musicsList = value; }
        public String Description { get => description; set => description = value; }

        public Music(String nome, String pathFile, String _singer = "Anonimous", String Album = "NoName", String dur = "")
        {
            name = nome;
            path = pathFile;
            singer = _singer;
            album = Album;
            duration = dur;
            musicsList = new List<Music>();

        }
        public Music()
        {

        }
        static Music()
        {


            string[] Files = Directory.GetDirectories(@"..\\..\\Musics");
            List<Music> play = new List<Music>();
            foreach (var Directory in Files)
            {
                DirectoryInfo file = new DirectoryInfo(Directory);
                string name = file.Name.Split('$')[0];
                string singer = file.Name.Split('$')[1];
                string folderPath = System.IO.Path.Combine("..\\..\\Musics", file.Name);
                string pathString = System.IO.Path.Combine(folderPath, "musicInfo.txt");
                string[] filelines = System.IO.File.ReadAllLines(pathString);
                String musicName = name + ".mp3";
                string filepath = System.IO.Path.Combine(file.FullName, musicName);
                string Album = filelines[0];
                string Duration = filelines[1];
                Music ex = new Music(name, filepath, singer, Album, Duration);
                play.Add(ex);
            }
            musicsList = play;

        }
        public static Music GetMusicByName(string name)
        {
            foreach (Music music in musicsList)
            {
                if (music.name.Equals(name))
                {
                    return music;
                }
            }
            return null;
        }
        public static string GetDuration(string Path)
        {
            TimeSpan a = GetVideoDuration(Path);
            int duration = (int)Math.Round(a.TotalSeconds);
            StringBuilder sb = new StringBuilder();

            int mins = duration / 60;
            int seconds = duration % 60;

            if (mins < 10)
                sb.Append("0").Append(mins).Append(":");
            else
                sb.Append(mins).Append(":");

            if (seconds < 10)
                sb.Append("0").Append(seconds);
            else
                sb.Append(seconds);
            return sb.ToString();
        }
        private static TimeSpan GetVideoDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if ((obj.GetType().Equals(this.GetType())) == false)
            {
                return false;
            }
            Music temp = null;
            temp = (Music)obj;

            return name.Equals(temp.name) && path.Equals(temp.path) && singer.Equals(temp.singer) && duration.Equals(temp.duration);
        }
    }
   
}
