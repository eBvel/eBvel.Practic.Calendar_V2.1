using eBvel.Practic.Calendar_V2._1.Controls;
using System;
using System.Windows.Forms;

namespace eBvel.Practic.Calendar_V2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var c = new StartPageControl();
            panel1.Controls.Add(c);
        }

        private void CreateCalendar_Menu_Click(object sender, EventArgs e)
        {
            var c = new CreateCalendarControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
        }

        private void OpenCalendar_Menu_Click(object sender, EventArgs e)
        {
            var c = new OpenCalendarControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
            c.SecondConstruction();
        }

        private void Exit_Menu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenEvents_Menu_Click(object sender, EventArgs e)
        {
            var c = new OpenEventsControl();
            if (panel1.Controls.Count > 0)
                panel1.Controls.RemoveAt(0);
            panel1.Controls.Add(c);
            c.SecondConstruction();
        }
    }
}
