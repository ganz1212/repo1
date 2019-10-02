using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIS_Cafe
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ermolaevdataDataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.напиткиTableAdapter.Fill(this.pRODUCTSDBDataSet.Напитки);
            this.хлебИздTableAdapter.Fill(this.pRODUCTSDBDataSet.ХлебИзд);
            this.полуфабрикатыTableAdapter.Fill(this.pRODUCTSDBDataSet.Полуфабрикаты);


        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            dataGridView3.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            dataGridView3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            напиткиBindingSource.MovePrevious();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            напиткиBindingSource.MoveLast();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            напиткиBindingSource.AddNew();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.напиткиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTSDBDataSet);
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            хлебИздBindingSource.MovePrevious();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            хлебИздBindingSource.MoveLast();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.хлебИздBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTSDBDataSet);
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            хлебИздBindingSource.AddNew();
        }

        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            полуфабрикатыBindingSource.MovePrevious();
        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            полуфабрикатыBindingSource.MoveLast();
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            полуфабрикатыBindingSource.AddNew();
        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.полуфабрикатыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pRODUCTSDBDataSet);
        }

        private void bunifuThinButton216_Click(object sender, EventArgs e)
        {
            полуфабрикатыBindingSource.RemoveCurrent();
        }
    }
}
