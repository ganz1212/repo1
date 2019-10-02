using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AIS_Cafe
{
    public partial class Registration : Form
    {
        string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\student\Desktop\kurs\ais cafe1\AIS Cafe\AIS Cafe\Login.mdf;Integrated Security=True");
    
        public Registration()
        {
            InitializeComponent();
        }

        private void RegistrationThinButton_Click(object sender, EventArgs e)
        {

            if (RegLoginTextbox.Text == "" || RegPasswordTextBox.Text == "")
                MessageBox.Show("Проверьте все ли поля заполненны");
            else if (RegPasswordTextBox.Text != RegPasswordTextbox2.Text)
                MessageBox.Show("Пароли не совпадают!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {

                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@username", RegLoginTextbox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", RegPasswordTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    Clear();


                    MessageBox.Show("Регистрация прошла успешно");
                    LOGIN objForm1 = new LOGIN();
                    this.Close();
                    objForm1.Show();
                }
            }
            void Clear()
            {
                RegPasswordTextBox.Text = RegPasswordTextbox2.Text = RegLoginTextbox.Text = "";
            }
        }

        private void RegLoginTextbox_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void RegPasswordTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN ifrm = new LOGIN();
            ifrm.Show();
        }

        private void RegLoginTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void RegPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void RegPasswordTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }
    }
}
