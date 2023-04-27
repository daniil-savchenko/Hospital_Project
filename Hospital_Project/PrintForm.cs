using Hospital_Project.Classes;
using Hospital_Project.PrintForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Project
{
    public partial class PrintForm : Form
    {
        protected string tablename;
        private int id;
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
        private static SqlConnection con = new SqlConnection(constring);
        private SqlDataAdapter adb;
        private DataTable table;

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

            panel2.Show();
            panel2.BringToFront();

            panel3.Hide();
            panel3.SendToBack();
            panel4.Hide();
            panel4.SendToBack();
            panel5.Hide();
            panel5.SendToBack();
            panel6.Hide();
            panel6.SendToBack();
            panel7.Hide();
            panel7.SendToBack();
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
            panel3.Show();
            panel3.BringToFront();

            panel2.Hide();
            panel2.SendToBack();
            panel4.Hide();
            panel4.SendToBack();
            panel5.Hide();
            panel5.SendToBack();
            panel6.Hide();
            panel6.SendToBack();
            panel7.Hide();
            panel7.SendToBack();

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

            panel4.Show();
            panel4.BringToFront();

            panel3.Hide();
            panel3.SendToBack();
            panel2.Hide();
            panel2.SendToBack();
            panel5.Hide();
            panel5.SendToBack();
            panel6.Hide();
            panel6.SendToBack();
            panel7.Hide();
            panel7.SendToBack();

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

            panel5.Show();
            panel5.BringToFront();

            panel3.Hide();
            panel3.SendToBack();
            panel4.Hide();
            panel4.SendToBack();
            panel2.Hide();
            panel2.SendToBack();
            panel6.Hide();
            panel6.SendToBack();
            panel7.Hide();
            panel7.SendToBack();

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

            panel6.Show();
            panel6.BringToFront();

            panel3.Hide();
            panel3.SendToBack();
            panel4.Hide();
            panel4.SendToBack();
            panel5.Hide();
            panel5.SendToBack();
            panel2.Hide();
            panel2.SendToBack();
            panel7.Hide();
            panel7.SendToBack();
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

            panel7.Show();
            panel7.BringToFront();

            panel3.Hide();
            panel3.SendToBack();
            panel4.Hide();
            panel4.SendToBack();
            panel5.Hide();
            panel5.SendToBack();
            panel6.Hide();
            panel6.SendToBack();
            panel2.Hide();
            panel2.SendToBack();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*MessageBox.Show(dataGridView.SelectedCells[0].Value.ToString()); // value
            MessageBox.Show(dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].Name); // name of column
            MessageBox.Show(id.ToString());*/
            switch (tablename)
            {
                case "Pacients":

                    break;
                default:
                    break;
            }

        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var updatepac = new UpdatePac();
            DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
            id = int.Parse(row.Cells[0].Value.ToString());
            MessageBox.Show(row.Cells[1].Value.ToString());
            MessageBox.Show(row.Cells[2].Value.ToString());
            MessageBox.Show(row.Cells[3].Value.ToString());
            MessageBox.Show(row.Cells[4].Value.ToString());
            MessageBox.Show(row.Cells[5].Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();

            var select = "SELECT * FROM Parents";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
            }

            foreach (DataRow row in table.Rows)
            {
                comboBoxpacPar.Items.Add(row["parName"]);
            }

            select = "SELECT * FROM Doctors";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
            }
            foreach (DataRow row in table.Rows)
            {
                comboBoxpacDoc.Items.Add(row["workerName"]);
            }

            select = "SELECT * FROM Positions";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
            }
            foreach (DataRow row in table.Rows)
            {
                comboBoxworPos.Items.Add(row["posName"]);
            }

            select = "SELECT * FROM Doctors";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
            }
            foreach (DataRow row in table.Rows)
            {
                comboBoxresDoc.Items.Add(row["workerName"]);
            }
            select = "SELECT * FROM Pacients";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
            }
            foreach (DataRow row in table.Rows)
            {
                comboBoxresPac.Items.Add(row["pacName"]);
            }
        }
    }
}
