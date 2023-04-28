using Hospital_Project.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Project
{
    public partial class PacientForm : Form
    {
        // MessageBox.Show(this.NameTextParentP.GetItemText(this.NameTextParentP.SelectedItem)); // for sql INSERT INTO
        
        public PacientForm()
        {
            
            InitializeComponent();
        }

        

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            Pacients pac = new Pacients();
            DataBaseManager cmd = new DataBaseManager();
            Regex phoneregex = new Regex(@"^0[0-9]{9}$");
            Regex egnregex = new Regex(@"^[0-9]{10}$");
            if (phoneregex.IsMatch(phoneTextBoxP.Text))
            {
                pac.Phone = phoneTextBoxP.Text;
            }
            else
            {
                MessageBox.Show("Wrong Phone Input");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return;

            }
            if (egnregex.IsMatch(egnTextBoxP.Text))
            {
                pac.Egn = egnTextBoxP.Text;
            }
            else
            {
                MessageBox.Show("Wrong Phone Input");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return;

            }
            pac.PacName = nameTextBoxP.Text;
            pac.Parent1 = NameTextParentP.Text;
            pac.Doctor1 = NameTextDoctorP.Text;
            if (string.IsNullOrEmpty(pac.PacName) || 
                string.IsNullOrEmpty(pac.Phone) ||
                string.IsNullOrEmpty(pac.Egn) ||
                string.IsNullOrEmpty(pac.Parent1) ||
                string.IsNullOrEmpty(pac.Doctor1)
                ) 
            {
                MessageBox.Show("Incorrect Data");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return;
            }
            else if(cmd.AddPacient(pac))
            {
                MessageBox.Show("Data Writing was successful");
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return;
            }
            else
            {
                MessageBox.Show("something went with Data input");
                GC.Collect();
                GC.WaitForPendingFinalizers();
            } 
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPar par = new AddPar();
            par.ShowDialog();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PacientForm_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(constring);
            var select = "SELECT ID, parName FROM Parents";
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    NameTextParentP.Items.Add(row["parName"].ToString());
                }
                connection.Close();
            }

            select = "SELECT ID, workerName from Doctors";
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    NameTextDoctorP.Items.Add(row["workerName"].ToString());
                }
                connection.Close();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }

    }
}
