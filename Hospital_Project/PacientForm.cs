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
    public partial class PacientForm : Form
    {
        public PacientForm()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPar par = new AddPar();
            par.Show();
        }
    }
}
