using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dan2Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.Width -= 17;
            PanelBody.AutoScroll = false;
            foreach (var panel in PanelBody.Controls.OfType<Guna2Panel>())
            {
                panel.Height = PanelBody.Height;
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //PanelInfo.BringToFront();
            PanelInfo.SendToBack();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            PanelDateComparer.SendToBack();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            PanelDateWorking.SendToBack();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            PanelLeapCounter.SendToBack();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            PanelTimeConverter.SendToBack();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            PanelBirhday.SendToBack();
        }

       
        private void ResultDateComparerButton_Click(object sender, EventArgs e)
        {
            DateTime a = DateTime1.Value;
            DateTime b = DateTime2.Value;
            TimeSpan res = b - a;
            int Years = 0;
            int Months = 0;
            long Week = 0;
            long Days = 0;
            long Hour = 0;
            long Minute = 0;
            long Second = 0;
            double MS = 0;

            while (((a.Year / 4 == 0) && ((b - a).Days >= 366)) || ((a.Year / 4 != 0) && ((b - a).Days >= 365)))
            {
                a = a.AddYears(1);
                Years++;
            }
            while (((a.Day / 31 == 0) && ((b - a).Days >= 31)) || ((a.Day / 30 == 0) && ((b - a).Days >= 30)) || ((a.Day / 28 == 0) && ((b - a).Days >= 28)) || ((a.Day / 29 == 0) && ((b - a).Days >= 29)))
            {
                a = a.AddMonths(1);
                Months++;
            }
            while(((a.Day / 7 == 0)&&((b-a).Days >= 7)) || ((a.Day / 7 !=0)&&((b -a).Days >= 7))) 
            {
                a = a.AddDays(7);
                Week++;
            }
            while(((a.Day / 1 == 0 ) && ((b - a).Days >= 1)) || ((a.Day / 1 !=0)&&((b - a ).Days >= 1)))
            {
                a = a.AddDays(1);
                Days++;
            }
            //int aa = a.Year;
            //int bb = b.Year;


            //Years = bb - aa;

            //if(a.Month > b.Month)
            //    Months = a.Month - b.Month;
            //else if(a.Month < b.Month)
            //    Months = b.Month - a.Month;


            //if(a.Day > b.Day)
            //    Days = a.Day - b.Day;
            //else if (a.Day < b.Day)
            //    Days = b.Day - a.Day;

            //if (Days > 7)
            //{
            //    Week = Days / 7;
            //    Days = Days % 7;
            //}


            //var span = b - a;
            //var all_day = span.Days;



            //var all_hours = (int)span.TotalHours;
            //Hour = all_hours % all_day;

            //var all_minutes = (int)span.TotalMinutes;
            //Minute = all_minutes % 60; 

            //var all_second = (int)span.TotalSeconds;
            //Second = all_second % 60;

            //var all_ms = span.TotalMilliseconds;
            //MS = all_ms % 1000;



            //while(a.AddSeconds(Second) < b)
            //    Second++;
            //while (a.AddMilliseconds(MS) < b)
            //    MS++;


            TotalYearsLabel.Text = "";
            TotalMonthLabel.Text = "";
            TotalWeekLabel.Text = "";
            TotalDaysLabel.Text = "";
            TotalTimeLabel.Text = "";
            GlobalDaysLabel.Text = "";

            TotalYearsLabel.Text += Years.ToString();
            TotalMonthLabel.Text += Months.ToString();
            TotalWeekLabel.Text += Week.ToString();
            TotalDaysLabel.Text += Days.ToString();
            TotalTimeLabel.Text += $"Часов:{Hour}; Минут:{Minute}; Секунд:{Second}; Милисекунд:{MS}.";
            GlobalDaysLabel.Text += res.Days.ToString();



            //TotalDaysLabel.Text +=  res.ToString();

            //GlobalDaysLabel.Text += res.Days.ToString();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel39_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel47_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TotaTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalDaysLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultLeapButton_Click(object sender, EventArgs e)
        {
            LeapLabel.Text = "";
            
            DateTime start = DateTimeLeap1.Value;
            DateTime finish = DateTimeLeap2.Value;

            int Years = 0;

            for(int i = start.Year; i <= finish.Year; i++)
            {
                if (DateTime.IsLeapYear(i))
                {
                    Years++;
                }
            }

            LeapLabel.Text += Years;
        }
    }
}
