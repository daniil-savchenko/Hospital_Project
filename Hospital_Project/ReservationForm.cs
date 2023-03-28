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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(constring);
            SqlDataAdapter adb;
            DataTable table;
            var idd = 1;
            var select = "SELECT * FROM Reservations";
            var insert = "INSERT INTO Reservations VALUES(@ID, @date, @pac, @doc)";

            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                connection.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();

                foreach (DataRow row in table.Rows)
                {
                    idd++;
                }
                connection.Close();
            }

            using (SqlCommand cmd = new SqlCommand(insert, connection))
            {
                select = "SELECT * FROM Pacients where pacName = @name";
                using (SqlCommand sel = new SqlCommand(select, connection))
                {
                    connection.Open();
                    adb = new SqlDataAdapter(sel);
                    table = new DataTable();
                    sel.Parameters.AddWithValue("@name", PacientBox.Text);
                    adb.Fill(table);
                    adb.Dispose();
                    if (table.Rows.Count == 1)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            PacientBox.Text = row["ID"].ToString();
                        }
                    }
                    else
                    {
                        PacientBox.Text = string.Empty;
                    }
                    connection.Close();
                }
                select = "SELECT * FROM Doctors where workerName = @name";
                using (SqlCommand sel = new SqlCommand(select, connection))
                {
                    connection.Open();
                    adb = new SqlDataAdapter(sel);
                    table = new DataTable();
                    sel.Parameters.AddWithValue("@name", DocBox.Text);
                    adb.Fill(table);
                    adb.Dispose();

                    if (table.Rows.Count >= 1)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            DocBox.Text = row["ID"].ToString();
                        }
                    }
                    else
                    {
                        DocBox.Text = string.Empty;
                    }
                    connection.Close();
                }
                connection.Open();

                if (PacientBox.Text != string.Empty && DocBox.Text != string.Empty && dateTimePicker.Text != DateTime.Now.ToString("yyyy-MM-dd hh:mm"))
                {
                    cmd.Parameters.AddWithValue("@ID", idd);
                    cmd.Parameters.AddWithValue("@pac", PacientBox.Text);
                    cmd.Parameters.AddWithValue("@doc", DocBox.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);
                    cmd.ExecuteNonQuery();
                }
                    else MessageBox.Show("wrong input");
                connection.Close();
                PacientBox.Text = string.Empty;
                DocBox.Text = string.Empty;
                dateTimePicker.Value = DateTime.Now;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(constring);
            SqlDataAdapter adb;
            DataTable table;
            var select = "SELECT * FROM Pacients";
            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                connection.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    PacientBox.Items.Add(row["pacName"].ToString());
                }
                connection.Close();
            }
            select = "SELECT * FROM Doctors";
            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    DocBox.Items.Add(row["workerName"].ToString());
                }
                connection.Close();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
