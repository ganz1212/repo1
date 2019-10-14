using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AIS_Cafe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panel2.Height = bunifuThinButton21.Height;
            panel2.Top = bunifuThinButton21.Top;
            menu121.BringToFront();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100;
            timer1.Start();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            panel2.Height = bunifuThinButton23.Height;
            panel2.Top = bunifuThinButton23.Top;
            postavki1231.BringToFront();
            postavki1231.Visible = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuThinButton21.Height;
            panel2.Top = bunifuThinButton21.Top;
            menu121.BringToFront();
        }


        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuThinButton22.Height;
            panel2.Top = bunifuThinButton22.Top;
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuThinButton24.Height;
            panel2.Top = bunifuThinButton24.Top;
            postavshikiUC1.BringToFront();
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com");
        }

        private void label1_Tick(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.ToString();
            this.label1.Text = ThData;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.ToString();
            this.label1.Text = ThData;
        }
    }
}
