using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.trackBar1_ValueChanged(this, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Purple;
            panel1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Green;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            //panel1.BackColor = Color.Yellow;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\u001B') Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
