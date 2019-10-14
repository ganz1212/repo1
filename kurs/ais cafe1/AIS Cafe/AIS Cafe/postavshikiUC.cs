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
    public partial class postavshikiUC : UserControl
    {
        public postavshikiUC()
        {
            InitializeComponent();
            
        }

        private void postavshikiUC_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://optlist.ru");
        }
    }
}
