using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viselitsa
{
    public partial class Form1 : Form
    {
        KeyBoard key;

        public Form1()
        {
            InitializeComponent();
            key = new KeyBoard();
            key.press += Key_press;
        }

        private void Key_press(object sender, EventArgs e)
        {
            (sender as RoundButton).BackColor = Color.Green;
            label1.Text += (sender as RoundButton).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.AddRange(key.GetKeys);
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
