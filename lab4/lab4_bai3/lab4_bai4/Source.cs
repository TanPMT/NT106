﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_bai4
{
    public partial class Source : Form
    {
        public Source(string source)
        {
            InitializeComponent();
            richTextBox1.Text = source;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}