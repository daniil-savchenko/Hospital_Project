using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pacientbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 pacient = new Form2();
            pacient.ShowDialog();
            this.Close();

            
        }

        private void Workerbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
