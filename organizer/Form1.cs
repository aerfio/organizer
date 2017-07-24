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
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 2, 0);

        }

        private void Organizer_Resize(object sender, EventArgs e)
        {
            //szerokosc tych zakladek zmienia sie wraz z rozmiarem okna
            tabControl1.ItemSize = new Size(tabControl1.Width / tabControl1.TabCount - 2, 0);
        }



        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (!monthCalendar1.SelectionEnd.ToShortDateString().Equals(monthCalendar1.TodayDate.ToShortDateString()))
            {
                monthCalendar1.AddBoldedDate(monthCalendar1.SelectionEnd);
                //MessageBox.Show(monthCalendar1.SelectionEnd.ToShortDateString() + " " + monthCalendar1.TodayDate.ToShortDateString());
            }
            monthCalendar1.UpdateBoldedDates();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAllBoldedDates();
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
