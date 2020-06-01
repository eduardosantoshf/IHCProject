using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muse_IC
{
    class ProgressBar
    {
        public PictureBox picFocus;
        public Label lbltop;
        public Label lblbottom;
        int value = 0;
        int x1;
        int y1;
        int h1;
        int w1;
        Form f1;

        public ProgressBar(Form f, int x, int y, int width, int high)
        {
            //绘制进度条，用两个label以及一个picturebox组合为进度条
            lblbottom = new Label();
            lbltop = new Label();
            lblbottom.BackColor = Color.Gray;
            lbltop.BackColor = Color.Yellow;

            //进度条上的光标
            picFocus = new PictureBox();
            picFocus.Size = new Size(high + 6, high + 6);
            picFocus.Location = new Point(x + value, y - 3);
            picFocus.BackgroundImage = Properties.Resources.Bola;
            picFocus.BackgroundImageLayout = ImageLayout.Stretch;
            picFocus.BackColor = Color.Transparent;

            lblbottom.SetBounds(x, y, width, high);
            lbltop.Size = new Size(value, high);
            lblbottom.Controls.Add(lbltop);
            f.Controls.Add(picFocus);
            f.Controls.Add(lblbottom);

            x1 = x;
            y1 = y;
            h1 = high;
            w1 = width;
            f1 = f;

        }
        public void updateFocus(int value)
        {
            picFocus.Location = new Point(x1 + value, y1 - 3);
            lbltop.Size = new Size(value, h1);
        }

        Point clickPoint;
        public bool isDrag;
        internal void picFocus_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            clickPoint = new Point(e.X, e.Y);
        }

        int offsetX;

        internal void picFocus_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                offsetX = e.X - clickPoint.X;

                if (picFocus.Location.X >= lblbottom.Location.X && picFocus.Location.X <= lblbottom.Location.X + w1 - picFocus.Width)
                {
                    picFocus.Location = new Point(picFocus.Location.X + offsetX, picFocus.Location.Y);
                }
                if (picFocus.Location.X < lblbottom.Location.X)
                {
                    picFocus.Location = new Point(lblbottom.Location.X, picFocus.Location.Y);
                }
                if (picFocus.Location.X > lblbottom.Location.X + w1 - picFocus.Width)
                {
                    picFocus.Location = new Point(lblbottom.Location.X + w1 - picFocus.Width, picFocus.Location.Y);
                }
                int value = picFocus.Location.X - lblbottom.Location.X;
                this.updateFocus(value);
            }
        }

        internal void picFocus_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }
    }
}
