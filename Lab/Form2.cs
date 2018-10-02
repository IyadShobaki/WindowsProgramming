﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.BackColor = colorDialog1.Color;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Hide();

        }
    }
}
