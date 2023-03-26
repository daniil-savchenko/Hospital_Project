﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class AddPar : Form
    {
        public AddPar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idd = 1;
            string path = Path.GetFullPath(Directory.GetCurrentDirectory());
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\""+ Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(conn);
            string sqlcom = "INSERT INTO Parents(ID, parName, phone, egn)  Values(@ID, @parName, @phone, @egn)";
            var select = "SELECT * FROM Parents";

            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    idd++;
                }
                con.Close();
            }

            if (this.textBox2.Text.Length == 10 && this.textBox3.Text.Length == 10)
            {
                con.Open();
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@parName", this.textBox1.Text);
                    insert.Parameters.AddWithValue("@phone", this.textBox2.Text);
                    insert.Parameters.AddWithValue("@egn", this.textBox3.Text);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                con.Close();
                this.Close();
                this.Dispose();
            }
            else
            {
                if (this.textBox2.Text.Length != 10)
                {
                    MessageBox.Show("Wrong input of Phone number");
                }
                else MessageBox.Show("Wrong input of EGN");
            }

            
        }
    }
}
