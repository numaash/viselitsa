using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viselitsa
{
    class KeyBoard : Control

    {
        RoundButton[] button = new RoundButton[26];
        string alphabet = "QWERTYUIOPASDFGHJKLZXCVBNM";
        public KeyBoard()
        {
            int i = 0;
            for (i = 0; i < 10; i++)
            {
                button[i] = new RoundButton(alphabet[i], 20 + i * 55, 200, Color.Yellow);
                button[i].Click += new System.EventHandler(this.press.Method);
            }

            for (i = 10; i < 19; i++)
            {
                button[i] = new RoundButton(alphabet[i], 50 + (i-10) * 55, 260, Color.Yellow);
                button[i].Click += this.press;
            }

            for (i = 19; i < 26; i++)
            {
                button[i] = new RoundButton(alphabet[i], 80 + (i - 19) * 55, 320, Color.Yellow);
                //button[i].Click += press.Invoke();

            }

        }

        public event EventHandler press;
        

        public RoundButton[] GetKeys { get { return button;} }
        
    }
}
