using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace viselitsa
{
    class RoundButton:Button
    {
        public RoundButton(char letter, int x, int y, Color color)
        {            
            this.Left = x;
            this.Top = y;
            this.Height = 50;
            this.Width = 50;
            this.BackColor = color;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(4, 4, Width -8, Height -8);          
            //path.AddEllipse(10, 10, Width - 20, Height - 20);
            Region region = new Region(path);            
            this.Region = region;
            this.Text = "" + letter;
            this.Font = new Font("Arial", 14f);
            this.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
