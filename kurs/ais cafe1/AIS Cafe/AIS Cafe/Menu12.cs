using System;
using System.Windows.Forms;

namespace AIS_Cafe
{
    public partial class Menu12 : UserControl
    {
        public Menu12()
        {
            InitializeComponent();
            //плюс
            if (ch == '+')
                sum += Double.Parse(bunifuMetroTextbox1.Text);
            bunifuMetroTextbox1.Text = sum.ToString();
            label2.Text = bunifuMetroTextbox1.Text;
        }

        //Для подсчета суммы заказа	

       
        //



        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            //греч.салат
            bunifuMetroTextbox1.Text += 230;
            zakaztextbox.Text += "греч.салат" + Environment.NewLine;
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            //кофе
            bunifuMetroTextbox1.Text += 60;
            zakaztextbox.Text += "кофе" + Environment.NewLine;

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            //чизбургер
            bunifuMetroTextbox1.Text += 150;
            zakaztextbox.Text += "чизбургер" + Environment.NewLine;
            

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            //клуб.милкшейк
            bunifuMetroTextbox1.Text += 100;
            zakaztextbox.Text += "клуб.милкшейк" + Environment.NewLine;
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //плюс           
            if (bunifuMetroTextbox1.Text == "")
                MessageBox.Show("Данные не введены");
            else
            {
                ch = '+';
                sum += Double.Parse(bunifuMetroTextbox1.Text);
                bunifuMetroTextbox1.Text = "+";
            }
        }

 
        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            //пончики
            bunifuMetroTextbox1.Text += 80;
            zakaztextbox.Text += "пончики" + Environment.NewLine;

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //сброс
            bunifuMetroTextbox1.Text = "";
            sum = 0;
            zakaztextbox.Text = "";
    }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //вывод суммы
             if (ch == '+')
               sum += Double.Parse(bunifuMetroTextbox1.Text);
            bunifuMetroTextbox1.Text = sum.ToString();
            
            
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            // плюс милкшейк
            
            bunifuMetroTextbox1.Text +=50;
            ch = '+';
            sum = Double.Parse(bunifuMetroTextbox1.Text);
            bunifuMetroTextbox1.Text = "+";
            zakaztextbox.Text += "клуб.милкшейк" + Environment.NewLine;
            
            

            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            // минус милкшейк
            zakaztextbox.Text = "";
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //минус гамбургер
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            // плюс гамбургер
            bunifuMetroTextbox1.Text +=75;
            ch = '+';
            sum = Double.Parse(bunifuMetroTextbox1.Text);
            bunifuMetroTextbox1.Text = "+";
            zakaztextbox.Text += "Гамбургер" + Environment.NewLine;
            

            
        }
    }
}
