using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse_IC
{
    class Series
    {
        private String Name;
        private String description;
        private Image cover;
        private int numberOfEps;
        private User author;
        private List<Podcast> episodes;

        public String name
        {
            get { return Name; }
            set { Name = value; }
        }
        public String Desc
        {
            get { return description; }
            set { description  = value; }
        }
        public Image Picture
        {
            get { return cover; }
            set { cover = value; }
        }
        public int number
        {
            get { return numberOfEps; }
            set { numberOfEps = value; }
        }
        public User Author
        {
            get { return author; }
            set { author = value; }
        }
        public List<Podcast> Episodes
        {
            get { return episodes; }
            set { episodes = value; }
        }
    }
}
