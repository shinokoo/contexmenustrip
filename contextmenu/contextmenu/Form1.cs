using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contextmenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colordig = new ColorDialog();
            if (colordig.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.BackColor = colordig.Color;
            }
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                button1.ForeColor = color.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
