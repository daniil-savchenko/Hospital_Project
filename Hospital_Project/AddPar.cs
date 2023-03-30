﻿using Hospital_Project.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class AddPar : Form
    {
        public AddPar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parents parent = new Parents();
            DataBaseManager cmd = new DataBaseManager();
            parent.ParName = textBox1.Text;
            parent.Phone = textBox2.Text;
            parent.Egn= textBox3.Text;

            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text)
                )
            {
                MessageBox.Show("Inorrent Data");
                return;
            }else  if (cmd.AddPar(parent))
                {
                    MessageBox.Show("Data writing was successed");
                    return;
                }
                    else MessageBox.Show("Something went wrong");
        }
    }
}
