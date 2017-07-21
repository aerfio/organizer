using System;
using System.Drawing;
using System.Windows.Forms;

namespace organizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 3, 0);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
           tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount -3, 0);
            
        }
    }
}
