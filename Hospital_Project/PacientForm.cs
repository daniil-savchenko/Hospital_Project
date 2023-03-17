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

        private void Homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm pacient = new MainForm();
            pacient.ShowDialog();
            this.Close();
        }

        private void Pacientbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PacientForm pacient = new PacientForm();
            pacient.ShowDialog();
            this.Close();
        }

        private void Workerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerForm pacient = new WorkerForm();
            pacient.ShowDialog();
            this.Close();
        }

        private void Reservbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationForm pacient = new ReservationForm();
            pacient.ShowDialog();
            this.Close();
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintForm pacient = new PrintForm();
            pacient.ShowDialog();
            this.Close();
        }
    }
}
