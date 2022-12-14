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
using static System.Windows.Forms.AxHost;

namespace Dan2Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TimerUnix.Start();

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
        public DateTime date = DateTime.Now;
        public int DaysOfMonths(DateTime a)
        {
            a = DateTimeDate1.Value;

            int MonthsOfA = DateTime.DaysInMonth(a.Year, a.Month);

            return MonthsOfA;
        }
        public void FromDateToDate()
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

                    while ((b - a).Days >= DaysOfMonths(a))
                    {
                        a = a.AddMonths(1);
                        Months++;
                    }

                    while ((a.Day / 7 >= 0) && ((b - a).Days >= 7))
                    {
                        a = a.AddDays(7);
                        Week++;
                    }
                    while ((a.Day / 1 >= 0) && ((b - a).Days >= 1))
                    {
                        a = a.AddDays(1);
                        Days++;
                    }
                    while ((a.Hour / 1 >= 0) && ((b - a).Hours >= 1))
                    {
                        a = a.AddHours(1);
                        Hour++;
                    }
                    while ((a.Minute / 1 >= 0) && ((b - a).Minutes >= 1))
                    {
                        a = a.AddMinutes(1);
                        Minute++;
                    }
                    while ((a.Second / 1 >= 0) && ((b - a).Seconds >= 1))
                    {
                        a = a.AddSeconds(1);
                        Second++;
                    }
                    while ((a.Millisecond / 1 >= 0) && ((b - a).Milliseconds >= 1))
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
        public void LifeFromBirth()
        {
            try
            {
                LifeLabel.Text = "";
                NextBirthdLabel.Text = "";
                Years18Label.Text = "";
                NYearsLabel.Text = "";



                DateTime a = DateTimeBirthday.Value;
                DateTime Years18 = a.AddYears(18);
                date = DateTime.Now;

                int NYears = (int)NyearsNumeric.Value;
                DateTime ValueYears = a.AddYears(NYears);

                DateTime NextBirthday = new DateTime(DateTime.Now.Year, a.Month, a.Day);

                if (NextBirthday < DateTime.Now)
                    NextBirthday = new DateTime(DateTime.Now.Year + 1, a.Month, a.Day);

                NYearsTextLabel.Text = $"Вам исполнится {NYears}  через :";



                int Years = 0;
                int Months = 0;
                int Days = 0;
                int Hour = 0;
                int Minute = 0;
                int Second = 0;



                while (((a.Year / 4 == 0) && ((date - a).Days >= 366)) || ((a.Year / 4 != 0) && ((date - a).Days >= 365)))
                {
                    a = a.AddYears(1);
                    Years++;
                }

                while ((date - a).Days >= DaysOfMonths(a))
                {
                    a = a.AddMonths(1);
                    Months++;
                }

                while ((a.Day / 1 >= 0) && ((date - a).Days >= 1))
                {
                    a = a.AddDays(1);
                    Days++;
                }
                while ((a.Hour / 1 >= 0) && ((date - a).Hours >= 1))
                {
                    a = a.AddHours(1);
                    Hour++;
                }
                while ((a.Minute / 1 >= 0) && ((date - a).Minutes >= 1))
                {
                    a = a.AddMinutes(1);
                    Minute++;
                }
                while ((a.Second / 1 >= 0) && ((date - a).Seconds >= 1))
                {
                    a = a.AddSeconds(1);
                    Second++;
                }

                LifeLabel.Text = $"{Years}л.{Months}м.{Days}д.{Hour}ч.{Minute}м.{Second}с.";



                if (Years >= 18)
                {
                    Years18TextLabel.Text = "Вам исполнилось 18 лет :";

                    Years = 0;
                    Months = 0;
                    Days = 0;
                    Hour = 0;
                    Minute = 0;
                    Second = 0;


                    while (((Years18.Year / 4 == 0) && ((date - Years18).Days >= 366)) || ((Years18.Year / 4 != 0) && ((date - Years18).Days >= 365)))
                    {
                        Years18 = Years18.AddYears(1);
                        Years++;
                    }

                    while ((date - Years18).Days >= DaysOfMonths(Years18))
                    {
                        Years18 = Years18.AddMonths(1);
                        Months++;
                    }

                    while ((Years18.Day / 1 >= 0) && ((date - Years18).Days >= 1))
                    {
                        Years18 = Years18.AddDays(1);
                        Days++;
                    }
                    while ((Years18.Hour / 1 >= 0) && ((date - Years18).Hours >= 1))
                    {
                        Years18 = Years18.AddHours(1);
                        Hour++;
                    }
                    while ((Years18.Minute / 1 >= 0) && ((date - Years18).Minutes >= 1))
                    {
                        Years18 = Years18.AddMinutes(1);
                        Minute++;
                    }
                    while ((Years18.Second / 1 >= 0) && ((date - Years18).Seconds >= 1))
                    {
                        Years18 = Years18.AddSeconds(1);
                        Second++;
                    }

                    Years18Label.Text = $"{Years}л.{Months}м.{Days}д.{Hour}ч.{Minute}м.{Second}с.";

                }


                else if (Years < 18)
                {
                    Years18TextLabel.Text = "Вам исполниться 18 лет :";

                    Years = 0;
                    Months = 0;
                    Days = 0;
                    Hour = 0;
                    Minute = 0;
                    Second = 0;

                    while (((Years18.Year / 4 == 0) && ((Years18 - date).Days >= 366)) || ((Years18.Year / 4 != 0) && ((Years18 - date).Days >= 365)))
                    {
                        date = date.AddYears(1);
                        Years++;
                    }

                    while ((Years18 - date).Days >= DaysOfMonths(Years18))
                    {
                        date = date.AddMonths(1);
                        Months++;
                    }

                    while ((Years18.Day / 1 >= 0) && ((Years18 - date).Days >= 1))
                    {
                        date = date.AddDays(1);
                        Days++;
                    }
                    while ((Years18.Hour / 1 >= 0) && ((Years18 - date).Hours >= 1))
                    {
                        date = date.AddHours(1);
                        Hour++;
                    }
                    while ((Years18.Minute / 1 >= 0) && ((Years18 - date).Minutes >= 1))
                    {
                        date = date.AddMinutes(1);
                        Minute++;
                    }
                    while ((Years18.Second / 1 >= 0) && ((Years18 - date).Seconds >= 1))
                    {
                        date = date.AddSeconds(1);
                        Second++;
                    }

                    Years18Label.Text = $"{Years}л.{Months}м.{Days}д.{Hour}ч.{Minute}м.{Second}с.";


                }
                

                if (Years < NYears)
                {

                    date = DateTime.Now;

                    Years = 0;
                    Months = 0;
                    Days = 0;
                    Hour = 0;
                    Minute = 0;
                    Second = 0;

                    while (((ValueYears.Year / 4 == 0) && ((ValueYears - date).Days >= 366)) || ((ValueYears.Year / 4 != 0) && ((ValueYears - date).Days >= 365)))
                    {
                        date = date.AddYears(1);
                        Years++;
                    }

                    while ((ValueYears - date).Days >= DaysOfMonths(ValueYears))
                    {
                        date = date.AddMonths(1);
                        Months++;
                    }

                    while ((ValueYears.Day / 1 >= 0) && ((ValueYears - date).Days >= 1))
                    {
                        date = date.AddDays(1);
                        Days++;
                    }
                    while ((ValueYears.Hour / 1 >= 0) && ((ValueYears - date).Hours >= 1))
                    {
                        date = date.AddHours(1);
                        Hour++;
                    }
                    while ((ValueYears.Minute / 1 >= 0) && ((ValueYears - date).Minutes >= 1))
                    {
                        date = date.AddMinutes(1);
                        Minute++;
                    }
                    while ((ValueYears.Second / 1 >= 0) && ((ValueYears - date).Seconds >= 1))
                    {
                        date = date.AddSeconds(1);
                        Second++;
                    }

                    NYearsLabel.Text = $"{Years}л.{Months}м.{Days}д.{Hour}ч.{Minute}м.{Second}с.";

                    
                }
                








                if (true)
                {


                    date = DateTime.Now;

                    Years = 0;
                    Months = 0;
                    Days = 0;
                    Hour = 0;
                    Minute = 0;
                    Second = 0;

                    while (((NextBirthday.Year / 4 == 0) && ((NextBirthday - date).Days >= 366)) || ((NextBirthday.Year / 4 != 0) && ((NextBirthday - date).Days >= 365)))
                    {
                        date = date.AddYears(1);
                        Years++;
                    }

                    while ((NextBirthday - date).Days >= DaysOfMonths(NextBirthday))
                    {
                        date = date.AddMonths(1);
                        Months++;
                    }

                    while ((NextBirthday.Day / 1 >= 0) && ((NextBirthday - date).Days >= 1))
                    {
                        date = date.AddDays(1);
                        Days++;
                    }
                    while ((NextBirthday.Hour / 1 >= 0) && ((NextBirthday - date).Hours >= 1))
                    {
                        date = date.AddHours(1);
                        Hour++;
                    }
                    while ((NextBirthday.Minute / 1 >= 0) && ((NextBirthday - date).Minutes >= 1))
                    {
                        date = date.AddMinutes(1);
                        Minute++;
                    }
                    while ((NextBirthday.Second / 1 >= 0) && ((NextBirthday - date).Seconds >= 1))
                    {
                        date = date.AddSeconds(1);
                        Second++;
                    }

                    NextBirthdLabel.Text = $"{Months}м.{Days}д.{Hour}ч.{Minute}м.{Second}с.";
                }





            }
            catch
            {

            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
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
            try
            {
                FromDateToDate();
            }
            catch { }
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

        private void ResultTimeConverterButton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                
                try
                {
                    long num = (long)ResNumeric.Value;
                    long res = 0;

                    if (ComboStartBox.Text == "Год")
                    {
                        if (ComboFinishBox.Text == "Год")
                        {
                            res = num;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Году :";
                                TimeConverterLabel2.Text = $" {res} Год.";
                            }
                            else if (num > 1 && num < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Года.";
                            }
                            else if (num >= 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Месяц")
                        {
                            res = num * 12;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Году :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";

                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                        }
                        else if (ComboFinishBox.Text == "День")
                        {
                            res = num * 365;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Году :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Час")
                        {
                            res = num * 8760;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Году :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Минута")
                        {
                            res = num * 525600;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Году :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Секунда")
                        {
                            res = num * 31536000;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Году :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Годах :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                        }

                    }


                    else if (ComboStartBox.Text == "Месяц")
                    {
                        if (ComboFinishBox.Text == "Год")
                        {
                            res = num / 12;

                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяце :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }

                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }


                            if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Года.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Год.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Месяц")
                        {
                            res = num;

                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяце :";
                                TimeConverterLabel2.Text = $" {res} Месяц.";
                            }
                            else if (num > 1 && num < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Месяца.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }

                        }
                        else if (ComboFinishBox.Text == "День")
                        {
                            res = num * 30;

                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяце :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }

                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Час")
                        {
                            res = num * 720;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяце :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }

                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Минута")
                        {
                            res = num * 43200;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяце :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }

                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Секунда")
                        {
                            res = num * 2592000;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяце :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }

                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Месяцах :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                        }
                    }


                    else if (ComboStartBox.Text == "День")
                    {
                        if (ComboFinishBox.Text == "Год")
                        {
                            res = num / 365;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Дне :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                            else if (num > 1 && res < 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Год.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Года.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Месяц")
                        {
                            res = num / 30;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Дне :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                            else if (num > 1 && res < 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Месяц.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Месяца.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                        }
                        else if (ComboFinishBox.Text == "День")
                        {
                            res = num;
                            if (num == 1 && res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Дне :";
                                TimeConverterLabel2.Text = $" {res} День.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Дня.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Час")
                        {
                            res = num * 24;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Дне :";
                                TimeConverterLabel2.Text = $" {res} Часа.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Минута")
                        {
                            res = num * 1440;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Дне :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Секунда")
                        {
                            res = num * 86400;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Дне :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Днях :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                        }

                    }


                    else if (ComboStartBox.Text == "Час")
                    {
                        if (ComboFinishBox.Text == "Год")
                        {
                            res = num / 8760;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часу :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах :";
                                TimeConverterLabel2.Text = $" {res} Год.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Года.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Месяц")
                        {
                            res = num / 720;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часу :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах :";
                                TimeConverterLabel2.Text = $" {res} Месяц.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Месяца.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                        }
                        else if (ComboFinishBox.Text == "День")
                        {
                            res = num / 24;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часу :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах :";
                                TimeConverterLabel2.Text = $" {res} День.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Дня.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Час")
                        {
                            res = num;
                            if (num == 1 && res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часе :";
                                TimeConverterLabel2.Text = $" {res} Час.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах :";
                                TimeConverterLabel2.Text = $" {res} Часа.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Минута")
                        {
                            res = num * 60;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часе :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Секунда")
                        {
                            res = num * 3600;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Часе :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Часах:";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                        }

                    }


                    else if (ComboStartBox.Text == "Минута")
                    {
                        if (ComboFinishBox.Text == "Год")
                        {
                            res = num / 525600;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минуте :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Год.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Года.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Месяц")
                        {
                            res = num / 43200;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минуте :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Месяц.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Месяца.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                        }
                        else if (ComboFinishBox.Text == "День")
                        {
                            res = num / 1140;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минуте :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} День.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Дня.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Час")
                        {
                            res = num / 60;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минуте :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                            else if (res == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Час.";
                            }
                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Часа.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Минута")
                        {
                            res = num;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минуте :";
                                TimeConverterLabel2.Text = $" {res} Минута.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Минуты.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Секунда")
                        {
                            res = num * 60;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минуте :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Секунды.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Минутах :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                        }

                    }


                    else if (ComboStartBox.Text == "Секунда")
                    {
                        if (ComboFinishBox.Text == "Год")
                        {
                            res = num / 31536000;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секунде :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Года.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Лет.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Месяц")
                        {
                            res = num / 2592000;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секунде :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Месяца.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Месяцев.";
                            }
                        }
                        else if (ComboFinishBox.Text == "День")
                        {
                            res = num / 864000;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секунде :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Дня.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Дней.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Час")
                        {
                            res = num / 3600;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секунде :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Часа.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Часов.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Минута")
                        {
                            res = num / 60;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секунде :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }

                            else if (res > 1 && res < 5)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Минуты.";
                            }
                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Минут.";
                            }
                        }
                        else if (ComboFinishBox.Text == "Секунда")
                        {
                            res = num;
                            if (num == 1)
                            {
                                TimeConverterLabel1.Text = $"В {num} Секунде :";
                                TimeConverterLabel2.Text = $" {res} Секунда.";
                            }

                            else
                            {
                                TimeConverterLabel1.Text = $"В {num} Секундах :";
                                TimeConverterLabel2.Text = $" {res} Секунд.";
                            }
                        }
                    }

                    break;

                }
                catch { }
            }
        }

        public long UNIX()
        {
            date = DateTime.Now;
            long unix =  (long)(date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            return unix;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                try
                {
                    UnixTimaLabel.Text = UNIX().ToString();
                   
                }
                catch { }  

        }
  

        private void guna2GradientButton12_Click(object sender, EventArgs e)
        {
            try
            {
                TimerLifeFromBirth.Start();
            }
            catch { }
                 
        }

        private void TimerLife_Tick(object sender, EventArgs e)
        {
            try
            {
                LifeFromBirth();
            }
            catch { }
            
            
        }


        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

            while (true)
            {
                try
                {
                    WorkDayLabel.Text = "";


                    DateTime StartDay = DateTimeWorking1.Value;
                    DateTime FinishDay = DateTimeWorking2.Value;
                    int day = 0;

                    if (StartDay < FinishDay)
                    {
                        while(StartDay <= FinishDay)
                        {

                            if (MondayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Monday)
                            {
                                day++;
                            }
                            if (TuesdayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Tuesday)
                            {
                                day++;
                            }
                            if (WednesdayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Wednesday)
                            {
                                day++;
                            }
                            if (ThurdayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Thursday)
                            {
                                day++;
                            }
                            if (FridayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Friday)
                            {
                                day++;
                            }
                            if (SaturdayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Saturday)
                            {
                                day++;
                            }
                            if (SundayChek.Checked == true && StartDay.DayOfWeek == DayOfWeek.Sunday)
                            {
                                day++;
                            }

                            StartDay = StartDay.AddDays(1);
                            

                        }

                        WorkDayLabel.Text = $"{day} рабочих дней.";
                        
                        break;
                    }
                    else if (StartDay > FinishDay)
                    {
                        MessageBox.Show("Первое число не может быть больше второго !");

                        break;
                    }
                    else if (StartDay == FinishDay)
                    {
                        MessageBox.Show("Даты не могут быть одинаковыми!");

                        break;
                    }
                }
                catch { }
            }
            



        }
    }
}