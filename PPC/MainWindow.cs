﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace PPC
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Anketa anketa = new Anketa();   //открытие окна анкеты
            anketa.Show();
            this.Hide();
        }

        private void Exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
