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
    public partial class MainForm : Form
    {
        
        public MainForm()
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
            PacientForm a = new PacientForm();
            a.TopLevel = false;
            this.panel2.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.ControlBox = false;
            a.BringToFront();
            a.Show();

        }

        private void Workerbtn_Click(object sender, EventArgs e)
        {
            WorkerForm a = new WorkerForm();
            a.TopLevel = false;
            this.panel2.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.ControlBox = false;
            a.BringToFront();
            a.Show();
        }

        private void Reservbtn_Click(object sender, EventArgs e)
        {
            ReservationForm a = new ReservationForm();
            a.TopLevel = false;
            this.panel2.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.ControlBox = false;
            a.BringToFront();
            a.Show();
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            PrintForm a = new PrintForm();
            a.TopLevel = false;
            this.panel2.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.ControlBox = false;
            a.BringToFront();
            a.Show();
        }
    }
}
