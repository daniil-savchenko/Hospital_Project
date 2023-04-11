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
using static System.Net.WebRequestMethods;

namespace Hospital_Project
{
    public partial class PrintForm : Form
    {
        private string tablename;
        public PrintForm()
        {
            InitializeComponent();
        }

        private void PrintPacBtn_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = cmd.SelectPacient();
            tablename = "Pacients";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PrintWorBtn_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = cmd.SelectWokrker();
            tablename = "Workers";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PrintDocBtn_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = cmd.SelectDoctor();
            tablename = "Doctors";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PrintParBtn_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = cmd.SelectParents();
            tablename = "Parents";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PrintPosBtn_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = cmd.SelectPositions();
            tablename = "Positions";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void PrintResBtn_Click(object sender, EventArgs e)
        {
            DataBaseManager cmd = new DataBaseManager();
            dataGridView.AutoResizeColumns();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.DataSource = cmd.SelectReservations();
            tablename = "Reservations";
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string column1 = dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name;
            string value1 = dataGridView.SelectedCells[0].Value.ToString();*/
            MessageBox.Show(dataGridView.SelectedCells[0].Value.ToString()); // value
            MessageBox.Show(dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name); // name of column
            
            string columnname = dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name;
            string newval = textBox1.Text;
            string oldval = dataGridView.SelectedCells[0].Value.ToString();
            DataBaseManager cmd = new DataBaseManager();
            /* var command = "Update Pacients SET @column1 = @newval where @column1 = @value1";
             string path = Path.GetFullPath(Directory.GetCurrentDirectory());
             string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
             SqlConnection con = new SqlConnection(conn);
             using (SqlCommand cmd = new SqlCommand(command, con))
             {
                 con.Open();
                 cmd.Parameters.AddWithValue("@column1", column1.ToString());
                 cmd.Parameters.AddWithValue("@newval", textBox1.Text);
                 cmd.Parameters.AddWithValue("@value1", value1.ToString());
                 cmd.ExecuteNonQuery();
                 co*/
            
            if (cmd.UpdateData(tablename, columnname, newval, oldval))
            {
                MessageBox.Show("Success");
            }else MessageBox.Show("meow");

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
