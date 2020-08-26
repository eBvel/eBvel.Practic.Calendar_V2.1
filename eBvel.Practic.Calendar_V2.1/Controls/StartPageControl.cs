using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBvel.Practic.Calendar_V2._1.Forms;
using CLibrary;

namespace eBvel.Practic.Calendar_V2._1.Controls
{
    public partial class StartPageControl : UserControl
    {
        CalendarDBContext db;
        public StartPageControl()
        {
            InitializeComponent();
            db = new CalendarDBContext();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region LabelMouseEvent
        private void ReferencesLabel_MouseEnter(object sender, EventArgs e)
        {
            References_Label.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void ReferencesLabel_MouseLeave(object sender, EventArgs e)
        {
            References_Label.ForeColor = Color.White;
        }

        private void ReportsLabel_MouseEnter(object sender, EventArgs e)
        {
            Reports_Label.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void ReportsLabel_MouseLeave(object sender, EventArgs e)
        {
            Reports_Label.ForeColor = Color.White;
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            Exit_Label.ForeColor = Color.FromArgb(64,64,64);
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            Exit_Label.ForeColor = Color.White;
        }
        #endregion

        private void ReferencesLabel_Click(object sender, EventArgs e)
        {
            Reports_Panel.Visible = false;
            References_Panel.Visible = true;
        }

        private void ReportsLabel_Click(object sender, EventArgs e)
        {
            References_Panel.Visible = false;
            Reports_Panel.Visible = true;
        }

        private void ReportLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportLable2_Click(object sender, EventArgs e)
        {

        }

        private void ReferenceLabel1_Click(object sender, EventArgs e)
        {
            string ToDay1 = DateTime.Today.AddDays(-1).ToShortDateString(); //Yesterday

            var printForm = new PrintDocumentForm();
            printForm.label1.Text = "СПРАВКА\r\nо запланированных мероприятиях за прошедший день.";
            printForm.dataGridView1.DataSource = db.DbEvents.Local.Where(p => p.Calendars.ToString() == ToDay1).ToList();
            DialogResult result = printForm.ShowDialog(this);
        }

        private void ReferenceLabel2_Click(object sender, EventArgs e)
        {
            var printForm = new PrintDocumentForm();
            printForm.label1.Text = "СПРАВКА\r\nо запланированных мероприятиях на текущий год.";
            printForm.dataGridView1.DataSource = db.DbEvents.Local.Where(p => p.IsEvent == true).OrderBy(p => p.Id).ToList();
            DialogResult result = printForm.ShowDialog(this);
        }
    }
}
