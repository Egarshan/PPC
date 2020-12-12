using PPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Result : Form
    {
        public Result(Configuration lc)
        {
            InitializeComponent();

            Type_text.Text += lc.type;
            VC_text.Text += lc.VC_info;
            Proc_text.Text += lc.Proc_info;
            RAM_text.Text += lc.RAM_info;
            SSD_text.Text += lc.SSD_info;

            Price_text.Text += lc.price + " РУБ";
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
