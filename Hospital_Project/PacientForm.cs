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
            var idd = 1;
            string path = Path.GetFullPath(Directory.GetCurrentDirectory());
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adb;
            DataTable table;
            string sqlcom = "INSERT INTO Pacients Values(@ID, @pacName, @phone, @egn, @Parent, @Doctor)";
            var select = "SELECT * FROM Pacients";

            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    idd++;
                }
                con.Close();
            }

            select = "SELECT ID from Doctors where workerName = @Doctor";
            
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();

                cmd.Parameters.AddWithValue("@Doctor", NameTextDoctorP.Text);

                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    NameTextDoctorP.Text = row["ID"].ToString();
                }
                con.Close();
            }

            select = "SELECT ID from Parents where parName = @Parent";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();

                cmd.Parameters.AddWithValue("@Parent", NameTextParentP.Text);

                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    NameTextParentP.Text = row["ID"].ToString();
                }

                con.Close();
            }

            
            con.Open();
            using (SqlCommand insert = new SqlCommand(sqlcom, con))
            {

                if (NameTextParentP.Text != string.Empty && NameTextDoctorP.Text != string.Empty)
                {
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@pacName", nameTextBoxP.Text);
                    insert.Parameters.AddWithValue("@phone", phoneTextBoxP.Text);
                    insert.Parameters.AddWithValue("@egn", egnTextBoxP.Text);
                    insert.Parameters.AddWithValue("@Parent", NameTextParentP.Text);
                    insert.Parameters.AddWithValue("@Doctor", NameTextDoctorP.Text);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("wrong Input of Parent or Doctor");
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            con.Close();
            nameTextBoxP.Text = string.Empty;
            phoneTextBoxP.Text = string.Empty;
            egnTextBoxP.Text = string.Empty;
            NameTextParentP.Text = string.Empty;
            NameTextDoctorP.Text = string.Empty;

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
