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

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            panel2.Height = bunifuThinButton23.Height;
            panel2.Top = bunifuThinButton23.Top;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuThinButton21.Height;
            panel2.Top = bunifuThinButton21.Top;
            menu121.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuThinButton22.Height;
            panel2.Top = bunifuThinButton22.Top;
            userControl11.BringToFront();
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            panel2.Height = bunifuThinButton24.Height;
            panel2.Top = bunifuThinButton24.Top;
            browserpostavok ifrm2 = new browserpostavok();
            ifrm2.Show(); // отображаем browserpostavok
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
    }
}
