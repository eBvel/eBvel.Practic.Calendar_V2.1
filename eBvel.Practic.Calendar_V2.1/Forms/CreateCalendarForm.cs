using System.Collections.Generic;
using System.Drawing;
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
            if (panel1.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel1.BackColor = Color.White;
                Monday.ForeColor = Color.Black;
                ListRedDays.Add("Понедельник");
            }
            else
            {
                panel1.BackColor = Color.FromArgb(64, 64, 64);
                Monday.ForeColor = Color.White;
                ListRedDays.Remove("Понедельник");
            }
        }

        private void Panel2_Down(object sender, MouseEventArgs e)
        {
            if (panel2.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel2.BackColor = Color.White;
                Tuesday.ForeColor = Color.Black;
                ListRedDays.Add("Вторник");
            }
            else
            {
                panel2.BackColor = Color.FromArgb(64, 64, 64);
                Tuesday.ForeColor = Color.White;
                ListRedDays.Remove("Вторник");
            }
        }

        private void Panel3_Down(object sender, MouseEventArgs e)
        {
            if (panel3.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel3.BackColor = Color.White;
                Wednesday.ForeColor = Color.Black;
                ListRedDays.Add("Среда");
            }
            else
            {
                panel3.BackColor = Color.FromArgb(64, 64, 64);
                Wednesday.ForeColor = Color.White;
                ListRedDays.Remove("Среда");
            }
        }

        private void Panel4_Down(object sender, MouseEventArgs e)
        {
            if (panel4.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel4.BackColor = Color.White;
                Thursday.ForeColor = Color.Black;
                ListRedDays.Add("Четверг");
            }
            else
            {
                panel4.BackColor = Color.FromArgb(64, 64, 64);
                Thursday.ForeColor = Color.White;
                ListRedDays.Remove("Четверг");
            }
        }

        private void Panel5_Down(object sender, MouseEventArgs e)
        {
            if (panel5.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel5.BackColor = Color.White;
                Friday.ForeColor = Color.Black;
                ListRedDays.Add("Пятница");
            }
            else
            {
                panel5.BackColor = Color.FromArgb(64, 64, 64);
                Friday.ForeColor = Color.White;
                ListRedDays.Remove("Пятница");
            }
        }

        private void Panel6_Down(object sender, MouseEventArgs e)
        {
            if (panel6.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel6.BackColor = Color.White;
                Saturday.ForeColor = Color.Black;
                ListRedDays.Add("Суббота");
            }
            else
            {
                panel6.BackColor = Color.FromArgb(64, 64, 64);
                Saturday.ForeColor = Color.White;
                ListRedDays.Remove("Суббота");
            }
        }

        private void Panel7_Down(object sender, MouseEventArgs e)
        {
            if (panel7.BackColor == Color.FromArgb(64, 64, 64))
            {
                panel7.BackColor = Color.White;
                Sunday.ForeColor = Color.Black;
                ListRedDays.Add("Воскресенье");
            }
            else
            {
                panel7.BackColor = Color.FromArgb(64, 64, 64);
                Sunday.ForeColor = Color.White;
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
    

