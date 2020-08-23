using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBvel.Practic.Calendar_V2._1.Forms
{
    public partial class CreateCalendarForm : Form
    {
        public List<string> ListRedDays = new List<string>();
        public CreateCalendarForm()
        {
            InitializeComponent();
        }


        private void Panel1_Down(object sender, MouseEventArgs e)
        {
            if (panel1.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel1.BackColor = Color.Red;
                Monday.ForeColor = Color.White;
                ListRedDays.Add("Понедельник");
            }
            else
            {
                panel1.BackColor = Color.FromArgb(128, 128, 255);
                Monday.ForeColor = Color.Black;
                ListRedDays.Remove("Понедельник");
            }
        }

        private void Panel2_Down(object sender, MouseEventArgs e)
        {
            if (panel2.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel2.BackColor = Color.Red;
                Tuesday.ForeColor = Color.White;
                ListRedDays.Add("Вторник");
            }
            else
            {
                panel2.BackColor = Color.FromArgb(128, 128, 255);
                Tuesday.ForeColor = Color.Black;
                ListRedDays.Remove("Вторник");
            }
        }

        private void Panel3_Down(object sender, MouseEventArgs e)
        {
            if (panel3.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel3.BackColor = Color.Red;
                Wednesday.ForeColor = Color.White;
                ListRedDays.Add("Среда");
            }
            else
            {
                panel3.BackColor = Color.FromArgb(128, 128, 255);
                Wednesday.ForeColor = Color.Black;
                ListRedDays.Remove("Среда");
            }
        }

        private void Panel4_Down(object sender, MouseEventArgs e)
        {
            if (panel4.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel4.BackColor = Color.Red;
                Thursday.ForeColor = Color.White;
                ListRedDays.Add("Четверг");
            }
            else
            {
                panel4.BackColor = Color.FromArgb(128, 128, 255);
                Thursday.ForeColor = Color.Black;
                ListRedDays.Remove("Четверг");
            }
        }

        private void Panel5_Down(object sender, MouseEventArgs e)
        {
            if (panel5.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel5.BackColor = Color.Red;
                Friday.ForeColor = Color.White;
                ListRedDays.Add("Пятница");
            }
            else
            {
                panel5.BackColor = Color.FromArgb(128, 128, 255);
                Friday.ForeColor = Color.Black;
                ListRedDays.Remove("Пятница");
            }
        }

        private void Panel6_Down(object sender, MouseEventArgs e)
        {
            if (panel6.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel6.BackColor = Color.Red;
                Saturday.ForeColor = Color.White;
                ListRedDays.Add("Суббота");
            }
            else
            {
                panel6.BackColor = Color.FromArgb(128, 128, 255);
                Saturday.ForeColor = Color.Black;
                ListRedDays.Remove("Суббота");
            }
        }

        private void Panel7_Down(object sender, MouseEventArgs e)
        {
            if (panel7.BackColor == Color.FromArgb(128, 128, 255))
            {
                panel7.BackColor = Color.Red;
                Sunday.ForeColor = Color.White;
                ListRedDays.Add("Воскресенье");
            }
            else
            {
                panel7.BackColor = Color.FromArgb(128, 128, 255);
                Sunday.ForeColor = Color.Black;
                ListRedDays.Remove("Воскресенье");
            }
        }

        private void lMonday_Down(object sender, MouseEventArgs e)
        {
            Panel1_Down(sender, e);
        }

        private void lTuesday_Down(object sender, MouseEventArgs e)
        {
            Panel2_Down(sender, e);
        }

        private void lWednesday_Down(object sender, MouseEventArgs e)
        {
            Panel3_Down(sender, e);
        }

        private void lThursday_Down(object sender, MouseEventArgs e)
        {
            Panel4_Down(sender, e);
        }

        private void lFriday_Down(object sender, MouseEventArgs e)
        {
            Panel5_Down(sender, e);
        }

        private void lSaturday_Down(object sender, MouseEventArgs e)
        {
            Panel6_Down(sender, e);
        }

        private void lSunday_Down(object sender, MouseEventArgs e)
        {
            Panel7_Down(sender, e);
        }
    }
}
    

