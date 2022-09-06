using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
            TotaTimeLabel.Text = "";
            TotalDaysLabel.Text = "";

            TotaTimeLabel.Text += res.ToString();
            TotalDaysLabel.Text += res.Days.ToString();
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
    }
}
