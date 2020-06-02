using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse_IC
{
    class Comment
    {
        private string content;
        private int likes;
        private User author;
        private string date;

        public string Content { get => content; set => content = value; }
        public int Likes { get => likes; set => likes = value; }
        public string Date { get => date; set => date = value; }
        internal User Author { get => author; set => author = value; }
    }
}
