﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiFormSelect
{
    public partial class Form2 : Form
    {
        public Form2(string strgVar)
        {
            InitializeComponent();
            textBox1.Text = strgVar;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
