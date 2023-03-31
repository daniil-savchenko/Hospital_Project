using Hospital_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Positions pos = new Positions();
            DataBaseManager cmd = new DataBaseManager();
            pos.PosName = textBox1.Text;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Pleaese input Data");
                return;
            }
            else if (cmd.AddPos(pos))
            {
                MessageBox.Show("Data wrining was successful");
                this.Close();
                this.Dispose();
                return;
            }else
            {
                MessageBox.Show("Something went wrong is Data writing");
                return;
            }

        }
    }
}
