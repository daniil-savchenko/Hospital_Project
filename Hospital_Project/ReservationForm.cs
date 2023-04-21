using Hospital_Project.Classes;
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
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm:ss tt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            Reservations res = new Reservations();
            res.DoctorId = DocBox.Text;
            res.PacientId = PacientBox.Text;
            res.Thedate = dateTimePicker.Text;

            if (cmd.AddReservation(res))
            {
                MessageBox.Show("Success");
            } else
            {
                MessageBox.Show("no");
            }
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
