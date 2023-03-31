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
using System.Text.RegularExpressions;
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
            Workers worker = new Workers();
            DataBaseManager cmd = new DataBaseManager();
            Regex reg = new Regex(@"(@)(.+)$");
            Regex phoneregex = new Regex(@"^0[0-9]{9}$");
            string pattern = @"(@)(.+)$";
            if (Regex.IsMatch(EmailTextBoxW.Text, pattern, RegexOptions.IgnoreCase))
            {
                worker.Email = EmailTextBoxW.Text;
            }
            else
            {
                MessageBox.Show("Email was inputted wrong");
                EmailTextBoxW.Text = string.Empty;
                return;
            }
            if (phoneregex.IsMatch(PhoneTextBoxW.Text))
            {
                worker.Phone = PhoneTextBoxW.Text;
            }
            else PhoneTextBoxW.Text = string.Empty;

            worker.WorkerName = NameTextBoxW.Text;
            worker.Position1 = PositionTextBoxW.Text;
            worker.Salary = SalaryTextBoxW.Text;

            if (
                string.IsNullOrEmpty(NameTextBoxW.Text) ||
                string.IsNullOrEmpty(PhoneTextBoxW.Text) ||
                string.IsNullOrEmpty(EmailTextBoxW.Text) ||
                string.IsNullOrEmpty(PositionTextBoxW.Text) ||
                string.IsNullOrEmpty(SalaryTextBoxW.Text)
                )
            {
                MessageBox.Show("Wrong Data input");
                return;
            }
            else if (cmd.AddWorker(worker))
            {
                MessageBox.Show("Data writing was successed");
                return;
            }
            else
            {
                MessageBox.Show("Something went wrong with data input");
                return;
            }
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
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
