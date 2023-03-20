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
            if (this.panel2.Controls.Count > 0)
            {
                foreach (Control control in this.panel2.Controls)
                {
                    control.Dispose();
                }
                this.panel2.Controls.Clear();
            }
            this.panel2.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.ControlBox = false;
            a.BringToFront();
            a.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void Workerbtn_Click(object sender, EventArgs e)
        {
            WorkerForm a = new WorkerForm();
            a.TopLevel = false;
            if (this.panel2.Controls.Count > 0)
            {
                foreach (Control control in this.panel2.Controls)
                {
                    control.Dispose();
                }
                this.panel2.Controls.Clear();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            if (this.panel2.Controls.Count > 0)
            {
                foreach (Control control in this.panel2.Controls)
                {
                    control.Dispose();
                }
                this.panel2.Controls.Clear();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            if (this.panel2.Controls.Count > 0)
            {
                foreach (Control control in this.panel2.Controls)
                {
                    control.Dispose();
                }
                this.panel2.Controls.Clear();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.panel2.Controls.Add(a);
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            a.ControlBox = false;
            a.BringToFront();
            a.Show();
            
        }
    }
}
