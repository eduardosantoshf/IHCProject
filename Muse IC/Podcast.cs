using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Muse_IC
{
    class Podcast
    {
        private string _name;
        private int _duration;
        private List<User> _authors;
        private string _series;
        private Image _Image;

        public String Name
        {

            get { return _name; }
            set { _name = value; }

        }
        public Image Image
        {

            get { return _Image; }
            set { _Image = value; }

        }
        public String Series
        {

            get { return _series; }
            set { _series = value; }

        }
        public List<User> Authors
        {

            get { return _authors; }
            set { _authors = value; }

        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }

        }
        public Podcast(String nome, String serie="", int durac=0, List<User> addAuthors = null)
        {
            if (addAuthors == null)
            {
                _authors = new List<User>();
            }
            else
            {
                _authors = addAuthors;
            }
            _name = nome;
            _series = serie;
            _duration = durac;
        }
    }
}
