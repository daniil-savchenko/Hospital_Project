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
            Regex phoneregex = new Regex(@"^359[0-9]{7}$");
            Regex egnregex = new Regex(@"^[0-9]{10}$");
            pac.PacName = nameTextBoxP.Text;
            pac.Phone = phoneTextBoxP.Text;
            pac.Egn = egnTextBoxP.Text;
            pac.Parent1 = NameTextParentP.Text;
            pac.Doctor1 = NameTextDoctorP.Text;
            if (string.IsNullOrEmpty(nameTextBoxP.Text) || 
                string.IsNullOrEmpty(phoneTextBoxP.Text) ||
                string.IsNullOrEmpty(egnTextBoxP.Text) ||
                string.IsNullOrEmpty(NameTextParentP.Text) ||
                string.IsNullOrEmpty(NameTextDoctorP.Text) ||
                phoneregex.IsMatch(phoneTextBoxP.Text) ||
                egnregex.IsMatch(egnTextBoxP.Text)
                ) 
            { 
                MessageBox.Show("Incorrect Data");
                return;
            }
            else if(cmd.AddPacient(pac))
            {
                MessageBox.Show("Data Writing was successful");
            }
            else MessageBox.Show("something went wrong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPar par = new AddPar();
            par.ShowDialog();
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
