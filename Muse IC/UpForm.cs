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
    public partial class UpForm : Form
    {
        private List<Music> musicsToUpload;
        private App app;
        private User user;
        private bool fileType = true;
        
        public UpForm(App _app)
        {
            this.app = _app;
            this.user = _app.User;

            InitializeComponent();
        }
    }
}
