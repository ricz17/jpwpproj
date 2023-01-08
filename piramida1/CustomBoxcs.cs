using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace CustomPictureBoxControl
{
    public class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(IContainer container)
        {
            container.Add(this);
        }
        Point point;
        protected override void OnMouseDown(MouseEventArgs e)//ruchomy obrazek
        {
            point = e.Location;
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)//ruchomy obrazek
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
            base.OnMouseMove(e);
        }
    }
}

