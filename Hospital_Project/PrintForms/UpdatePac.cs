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

namespace Hospital_Project.PrintForms
{
    public partial class UpdatePac : Form
    {
        public UpdatePac()
        {
            InitializeComponent();
        }

        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePac_Load(object sender, EventArgs e)
        {

            

            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(constring);
            var select = "SELECT * FROM Pacients";
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(select, connection))
            {
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    /*comboBox1.Items.Add(row["pacName"].ToString());
                    comboBox2.Items.Add(row["phone"].ToString());
                    comboBox3.Items.Add(row["egn"].ToString());*/
                }
                connection.Close();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
