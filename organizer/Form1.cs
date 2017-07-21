using System;
using System.Drawing;
using System.Windows.Forms;

namespace organizer
{
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 2, 0);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
           tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount -2, 0);
            
        }

        private void Organizer_Resize(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 2, 0);
        }
    }
}
