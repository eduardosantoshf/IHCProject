using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muse_IC
{
    class Message
    {
        private string _topic;
        private string _message;
        private User _author;
        public String Topic
        {

            get { return _topic; }
            set { _topic = value; }

        }
        public String message
        {
            get { return _message; }
            set { _message = value; }

        }
        public User author
        {
            get { return _author; }
            set { _author = value; }
        }

    }
}
