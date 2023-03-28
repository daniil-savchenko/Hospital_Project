﻿using System;
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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PositionForm pacient = new PositionForm();
            pacient.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idd = 1;
            string path = Path.GetFullPath(Directory.GetCurrentDirectory());
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter adb;
            DataTable table;
            string sqlcom = "INSERT INTO Workers Values(@ID, @workerName, @phone, @email, @Position, @salary)";
            var select = "SELECT * FROM Workers";
            var isDoctor = false;

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
                select = "SELECT ID FROM Positions where posName = @doc";
            


            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                cmd.Parameters.AddWithValue("@doc", "Doctor");
                adb.Fill(table);
                adb.Dispose();

                if (table.Rows.Count == 1) isDoctor = true;
                else isDoctor = false;
                con.Close();
            }

            select = "SELECT ID from Positions where posName = @name";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();

                cmd.Parameters.AddWithValue("@name", PositionTextBoxW.Text);

                adb.Fill(table);
                adb.Dispose();
                if (table.Rows.Count >= 1)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        PositionTextBoxW.Text = row["ID"].ToString();
                    }
                }
                else
                {
                    PositionTextBoxW.Text = string.Empty;
                }
                con.Close();
            }
            sqlcom = "INSERT INTO Workers Values(@ID, @workerName, @phone, @email, @Position, @salary)";
            using (SqlCommand insert = new SqlCommand(sqlcom, con))
            {
                con.Open();
                if (PositionTextBoxW.Text != string.Empty)
                {
                    if (NameTextBoxW.Text != string.Empty && PhoneTextBoxW.Text != string.Empty && EmailTextBoxW.Text != string.Empty && SalaryTextBoxW.Text != string.Empty)
                    {
                        insert.Parameters.AddWithValue("@ID", idd);
                        insert.Parameters.AddWithValue("@workerName", NameTextBoxW.Text);
                        insert.Parameters.AddWithValue("@phone", PhoneTextBoxW.Text);
                        insert.Parameters.AddWithValue("@email", EmailTextBoxW.Text);
                        insert.Parameters.AddWithValue("@Position", PositionTextBoxW.Text);
                        insert.Parameters.AddWithValue("@salary", SalaryTextBoxW.Text);
                        insert.CommandType = CommandType.Text;
                        insert.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("please inout data");
                    }
                }
                else
                {
                    MessageBox.Show("wrong Input of Position");
                }
                con.Close();
            }

            

            sqlcom = "INSERT INTO Doctors Values(@ID, @workerName, @phone, @email, @salary)";
            con.Open();
            using (SqlCommand insert = new SqlCommand(sqlcom, con))
            {
                if (isDoctor == true)
                {
                    select = "SELECT * FROM Doctors";
                    idd = 1;
                    using (SqlCommand cmd = new SqlCommand(select, con))
                    {
                        adb = new SqlDataAdapter(cmd);
                        table = new DataTable();
                        adb.Fill(table);
                        adb.Dispose();
                        foreach (DataRow row in table.Rows)
                        {
                            idd++;
                        }
                    }

                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@workerName", NameTextBoxW.Text);
                    insert.Parameters.AddWithValue("@phone", PhoneTextBoxW.Text);
                    insert.Parameters.AddWithValue("@email", EmailTextBoxW.Text);
                    insert.Parameters.AddWithValue("@salary", SalaryTextBoxW.Text);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                }
                con.Close();
            }
            NameTextBoxW.Text = string.Empty;
            PhoneTextBoxW.Text = string.Empty;
            EmailTextBoxW.Text = string.Empty;
            PositionTextBoxW.Text = string.Empty;
            SalaryTextBoxW.Text = string.Empty;

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(constring);
            var select = "SELECT ID, posName FROM Positions";
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    PositionTextBoxW.Items.Add(row["posName"].ToString());
                }
                connection.Close();
            }
        }
    }
}
