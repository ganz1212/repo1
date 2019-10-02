using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Cafe
{
    public partial class postavki : Form
    {
        public postavki()
        {
            InitializeComponent();
        }

        private void postavki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postavkiDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.postavkiDataSet.Table);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
