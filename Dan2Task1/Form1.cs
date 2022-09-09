﻿using Guna.UI2.WinForms;
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

            DateTimeDate1.Value = DateTime.Now;
            DateTimeDate2.Value = DateTime.Now;
            DateTimeLeap1.Value = DateTime.Now;
            DateTimeLeap2.Value = DateTime.Now;
            DateTimeWorking1.Value = DateTime.Now;
            DateTimeWorking2.Value = DateTime.Now;

            this.Width -= 17;
            PanelBody.AutoScroll = false;
            foreach (var panel in PanelBody.Controls.OfType<Guna2Panel>())
            {
                panel.Height = PanelBody.Height;
            }

        }

        public int DaysOfMonths( DateTime a)
        {
           a = DateTimeDate1.Value;
           
           int MonthsOfA = DateTime.DaysInMonth(a.Year, a.Month);
           
            return MonthsOfA;
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
            while (true)
            {
                try
                {
                    DateTime a = DateTime.Now;
                    DateTime b = DateTime.Now;
                    TimeSpan res = b - a;


                    if (DateTimeDate1.Value < DateTimeDate2.Value)
                    {
                        a = DateTimeDate1.Value;
                        b = DateTimeDate2.Value;
                        res = b - a;
                    }
                    else if (DateTimeDate1.Value > DateTimeDate2.Value)
                    {
                        b = DateTimeDate1.Value;
                        a = DateTimeDate2.Value;
                        res = b - a;
                    }

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

                    while((b -a).Days >= DaysOfMonths(a))
                    {
                        a = a.AddMonths(1);
                        Months++;
                    }

                    while ((a.Day / 7 >= 0) && ((b - a).Days >= 7))
                    {
                        a = a.AddDays(7);
                        Week++;
                    }
                    while((a.Day / 1 >= 0) && ((b - a).Days >= 1))
                    {
                        a = a.AddDays(1);
                        Days++;
                    }
                    while((a.Hour / 1 >=0) && ((b - a).Hours >= 1))
                    {
                        a = a.AddHours(1);
                        Hour++;
                    }
                    while((a.Minute/1>=0)&& ((b - a).Minutes >= 1))
                    {
                        a = a.AddMinutes(1);
                        Minute++;
                    }
                    while((a.Second / 1 >=0)&&((b - a ).Seconds >= 1))
                    {
                        a = a.AddSeconds(1);
                        Second++;
                    }
                    while((a.Millisecond / 1 >=0)&&((b - a).Milliseconds >= 1))
                    {
                        a = a.AddMilliseconds(1);
                        MS++;
                    }

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

                    break;
                }
                catch { }   
            }
        }
        private void ResultLeapButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    LeapLabel.Text = "";

                    DateTime start = DateTimeLeap1.Value;
                    DateTime finish = DateTimeLeap2.Value;

                    int Years = 0;

                    for (int i = start.Year; i <= finish.Year; i++)
                    {
                        if (DateTime.IsLeapYear(i))
                        {
                            Years++;
                        }
                    }

                    LeapLabel.Text += Years;

                    break;
                }
                catch { }
            }
            
        }
    }
}
