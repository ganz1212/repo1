using System;
using System.Windows.Forms;

namespace AIS_Cafe
{
    public partial class Menu12 : UserControl
    {
        public Menu12()
        {
            InitializeComponent();
        }

        //Для подсчета суммы заказа	
        
        int count; // рассчёт
        double a, b, c, d, r;
        bool znak = true;
        int q= 230, w = 150, x = 100;
        //



        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            //греч.салат
            bunifuMetroTextbox1.Text = bunifuMetroTextbox1.Text + 230;
            int q = 230;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            //кофе
            double a = 60;
            bunifuMetroTextbox1.Text = bunifuMetroTextbox1.Text + 60;
            count = 1;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            //чизбургер
            
            int w = 150;
            bunifuMetroTextbox1.Text = bunifuMetroTextbox1.Text + 150;
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            //клуб.милкшейк
            int x = 100;
            bunifuMetroTextbox1.Text = bunifuMetroTextbox1.Text + 100;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //плюс
            int q = int.Parse(bunifuMetroTextbox1.Text);           
            int w = int.Parse(bunifuMetroTextbox1.Text);
            int x = int.Parse(bunifuMetroTextbox1.Text);

            count = 1;
            bunifuMetroTextbox1.Text = q.ToString() + "+";
            bunifuMetroTextbox1.Text = w.ToString() + "+";
            bunifuMetroTextbox1.Text = x.ToString() + "+";

            znak = true;

        }

 
        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            //пончики
            bunifuMetroTextbox1.Text = bunifuMetroTextbox1.Text + 80;           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //сброс
            string rez = "";
            byte i = 0;
            while (i < bunifuMetroTextbox1.Text.Length - 1) // Пока i меньше длины textBox-1 
            {
                rez += bunifuMetroTextbox1.Text[i];
                i++;
            }
            bunifuMetroTextbox1.Text = rez; // Переменная rez = textBox без последнего символа
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            calculate();
            bunifuMetroTextbox1.Text = "";
        }
        private void calculate()
        {
            int y = q + w;
                y = x + q;
                y = x + w;
            
            label1.Text = y.ToString();

        }
    }
}
