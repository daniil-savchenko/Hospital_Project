using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class PacientForm : Form
    {
        // MessageBox.Show(this.NameTextParentP.GetItemText(this.NameTextParentP.SelectedItem)); // for sql INSERT INTO
        
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
            par.ShowDialog();
        }

        private void PacientForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(constring);
            var select = "SELECT parName FROM Parents";
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

            select = "SELECT workerName from Doctors";
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
            
        }
    }
}
