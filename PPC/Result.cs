using PPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Result : Form
    {
        public Result(Configuration C1, Configuration C2, Configuration C3)
        {
            InitializeComponent();

            Type_text.Text += C1.type;
            VC_text.Text += C1.VC_info;
            Proc_text.Text += C1.Proc_info;
            RAM_text.Text += C1.RAM_info;
            SSD_text.Text += C1.SSD_info;

            Price_text.Text += C1.price + " РУБ";

            if (C2.type != null)
            {
                Type_text2.Text += C2.type;
                VC_text2.Text += C2.VC_info;
                Proc_text2.Text += C2.Proc_info;
                RAM_text2.Text += C2.RAM_info;
                SSD_text2.Text += C2.SSD_info;

                Price_text2.Text += C2.price + " РУБ";

                Config2.Visible = true;
            }


            if (C3.type != null)
            {
                Type_text3.Text += C3.type;
                VC_text3.Text += C3.VC_info;
                Proc_text3.Text += C3.Proc_info;
                RAM_text3.Text += C3.RAM_info;
                SSD_text3.Text += C3.SSD_info;

                Price_text3.Text += C3.price + " РУБ";

                Config3.Visible = true;
            }
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
