﻿using Hospital_Project.Classes;
using Hospital_Project.PrintForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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
            dataGridView.DataSource = cmd.SelectWorker();
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
            DataBaseManager databaseman = new DataBaseManager();
            try
            {
                Regex phoneregex = new Regex(@"^0[0-9]{9}$");
                Regex egnregex = new Regex(@"^[0-9]{10}$");
                Regex emailregex = new Regex(@"(@)(.+)$");
                List<string> list = new List<string>();
                switch (tablename)
                {
                    case "Pacients":
                        Pacients pacient = new Pacients();
                        pacient.ID = id;
                        
                        list.Add(textBoxPacName.Text);
                        list.Add(comboBoxpacPar.Text);
                        list.Add(comboBoxpacDoc.Text);
                        list.Add(textBoxpacPhone.Text);
                        list.Add(textBoxpacEgn.Text);
                        int i = list.Count;
                        if (databaseman.Checker(list))
                        {
                            MessageBox.Show("String can't be empty");
                            break;
                        }
                        else
                        {
                            pacient.PacName = textBoxPacName.Text;
                            pacient.Parent1 = comboBoxpacPar.Text;
                            pacient.Doctor1 = comboBoxpacDoc.Text;
                            pacient.Phone = textBoxpacPhone.Text;
                            pacient.Egn = textBoxpacEgn.Text;
                        }


                        var select = "SELECT ID from Doctors where workerName = @Doctor";

                        using (SqlCommand cmd = new SqlCommand(select, con))
                        {
                            con.Open();
                            adb = new SqlDataAdapter(cmd);
                            table = new DataTable();

                            cmd.Parameters.AddWithValue("@Doctor", pacient.Doctor1);

                            adb.Fill(table);
                            adb.Dispose();
                            if (table.Rows.Count >= 1)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    pacient.Doctor1 = row["ID"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No such Doctor");
                                break;
                            }

                            con.Close();
                        }

                        select = "SELECT ID from Parents where parName = @Parent";
                        using (SqlCommand cmd = new SqlCommand(select, con))
                        {
                            con.Open();
                            adb = new SqlDataAdapter(cmd);
                            table = new DataTable();

                            cmd.Parameters.AddWithValue("@Parent", pacient.Parent1);

                            adb.Fill(table);
                            adb.Dispose();
                            if (table.Rows.Count >= 1)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    pacient.Parent1 = row["ID"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No such Parent");
                                break;
                            }

                            con.Close();
                        }

                        if (phoneregex.IsMatch(textBoxpacPhone.Text) && egnregex.IsMatch(textBoxpacEgn.Text))
                        {
                            pacient.Phone = textBoxpacPhone.Text;
                            pacient.Egn = textBoxpacEgn.Text;
                        }
                        else { MessageBox.Show("Incorrect Phone Or EGN");  break; }

                        
                        
                        if (databaseman.UpdatePacientTable(pacient))
                        {
                            MessageBox.Show("Data was updated");
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.DataSource = databaseman.SelectPacient();
                            break;
                        }
                        else MessageBox.Show("Data was NOT updated");
                        break;
                    case "Workers":
                        Workers worker = new Workers();
                        worker.ID = id;
                        list = new List<string>();
                        list.Add(textBoxworName.Text);
                        list.Add(textBoxworPhone.Text);
                        list.Add(textBoxworSal.Text);
                        list.Add(textBoxworEmail.Text);
                        list.Add(comboBoxworPos.Text);
                        i = list.Count;
                        if (databaseman.Checker(list))
                        {
                            MessageBox.Show("String can't be empty");
                            break;
                        }
                        else
                        {
                            worker.WorkerName = textBoxworName.Text;
                            worker.Salary = textBoxworSal.Text;
                            if (phoneregex.IsMatch(textBoxworPhone.Text) &&
                            emailregex.IsMatch(textBoxworEmail.Text)
                            )
                            {
                                worker.Phone = textBoxworPhone.Text;
                                worker.Email = textBoxworEmail.Text;
                            }
                        }
                        select = "SELECT ID from Positions where posName = @pos";

                        using (SqlCommand cmd = new SqlCommand(select, con))
                        {
                            con.Open();
                            adb = new SqlDataAdapter(cmd);
                            table = new DataTable();

                            cmd.Parameters.AddWithValue("@pos", comboBoxworPos.Text);

                            adb.Fill(table);
                            adb.Dispose();
                            if (table.Rows.Count >= 1)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    worker.Position1 = row["ID"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No such position");
                                break;
                            }

                            con.Close();
                        }

                        if (databaseman.UpdateWorkerTable(worker))
                        {
                            MessageBox.Show("Data was updated");
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.DataSource = databaseman.SelectWorker();
                            break;
                        } else MessageBox.Show("Data was NOT updated");
                        break;
                    case "Doctors":
                        worker = new Workers();
                        worker.ID = id;

                        list = new List<string>();
                        list.Add(textBoxdocName.Text);
                        list.Add(textBoxdocPhone.Text);
                        list.Add(textBoxdocEmail.Text);
                        list.Add(textBoxdocSal.Text);

                        if (databaseman.Checker(list))
                        {
                            MessageBox.Show("String can't be empty");
                            break;
                        } else
                        {
                            worker.WorkerName = textBoxdocName.Text;
                            worker.Salary = textBoxdocSal.Text;
                            if (phoneregex.IsMatch(textBoxdocPhone.Text) &&
                                emailregex.IsMatch(textBoxdocEmail.Text))
                            {
                                worker.Phone = textBoxdocPhone.Text;
                                worker.Email = textBoxdocEmail.Text;
                            }
                            else { MessageBox.Show("Wrong Format of Phone or EGN"); break; }
                        }
                        if (databaseman.UpdateDoctorsTable(worker))
                        {
                            MessageBox.Show("Data was updated");
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.DataSource = databaseman.SelectDoctor();
                            break;
                        }
                        else MessageBox.Show("Data was NOT updated");
                        break;
                    case "Parents":
                        Parents parent = new Parents();
                        parent.ID = id;
                        list = new List<string>();

                        list.Add(textBoxparName.Text);
                        list.Add(textBoxparPhone.Text);
                        list.Add(textBoxparEgn.Text);

                        if (databaseman.Checker(list))
                        {
                            parent.ParName = textBoxparName.Text;
                            if (
                                phoneregex.IsMatch(textBoxparPhone.Text) &&
                                egnregex.IsMatch(textBoxparEgn.Text)
                                )
                            {
                                parent.Phone = textBoxparPhone.Text;
                                parent.Egn = textBoxparEgn.Text;
                            }
                            else { MessageBox.Show("Wrong Format of Phone or EGN "); break;  }
                        }
                        else { MessageBox.Show("String can't be Empty"); break; }
                        
                        
                        if (databaseman.UpdateParentTable(parent))
                        {
                            MessageBox.Show("Data was updated");
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.DataSource = databaseman.SelectParents();
                            break;
                        } else MessageBox.Show("Data was NOT updated");
                        break;
                    case "Reservations":
                        Reservations reservations= new Reservations();
                        reservations.ID = id;
                        list = new List<string>();
                        list.Add(comboBoxresDoc.Text);
                        list.Add(comboBoxresPac.Text);
                        list.Add(dateTimePicker1.Text);
                        if (databaseman.Checker(list))
                        {
                            MessageBox.Show("String can't be empty");
                            break;
                        } else
                        {
                            reservations.Thedate = dateTimePicker1.Text;
                        }
                        select = "SELECT ID from Doctors where workerName = @Doctor";
                        using (SqlCommand cmd = new SqlCommand(select, con))
                        {
                            con.Open();
                            adb = new SqlDataAdapter(cmd);
                            table = new DataTable();

                            cmd.Parameters.AddWithValue("@Doctor", comboBoxresDoc.Text);

                            adb.Fill(table);
                            adb.Dispose();
                            if (table.Rows.Count >= 1)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    reservations.DoctorId = row["ID"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No such Doctor");
                                con.Close();
                                break;
                            }
                            con.Close();
                        }

                        select = "SELECT ID from Pacients where pacName = @pacient";

                        using (SqlCommand cmd = new SqlCommand(select,con))
                        {
                            con.Open();

                            adb = new SqlDataAdapter(cmd);
                            table = new DataTable();

                            cmd.Parameters.AddWithValue("@pacient", comboBoxresPac.Text);

                            adb.Fill(table);
                            adb.Dispose();
                            if (table.Rows.Count >= 1)
                            {
                                foreach (DataRow row in table.Rows)
                                {
                                    reservations.PacientId = row["ID"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No such Pacient");
                                con.Close();
                                break;
                            }
                            con.Close();
                        }

                        
                        if (databaseman.UpdateReservationsTable(reservations))
                        {
                            MessageBox.Show("Data was updated");
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.DataSource = databaseman.SelectReservations();
                            break;
                        } else MessageBox.Show("Data was NOT updated");
                        break;
                    case "Positions":
                        Positions positions = new Positions();
                        positions.ID = id;
                        list = new List<string>();
                        list.Add(textBoxposName.Text);
                        if (databaseman.Checker(list))
                        {
                            MessageBox.Show("String can't be empty");
                            break;
                        } else positions.PosName = textBoxposName.Text;
                        
                        if (databaseman.UpdatePositionsTable(positions))
                        {
                            MessageBox.Show("Data was updated");
                            dataGridView.AutoResizeColumns();
                            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            dataGridView.DataSource = databaseman.SelectPositions();
                            break;
                        } else MessageBox.Show("Data was NOT updated");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            



        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
            switch (tablename)
            {
                case "Pacients":
                    id = int.Parse(row.Cells[0].Value.ToString());
                    textBoxPacName.Text = row.Cells[1].Value.ToString();
                    textBoxpacPhone.Text = row.Cells[2].Value.ToString();
                    textBoxpacEgn.Text = row.Cells[3].Value.ToString();
                    comboBoxpacPar.Text = row.Cells[4].Value.ToString();
                    comboBoxpacDoc.Text = row.Cells[5].Value.ToString();
                    break;
                case "Workers":
                    id = int.Parse(row.Cells[0].Value.ToString());
                    textBoxworName.Text = row.Cells[1].Value.ToString();
                    textBoxworPhone.Text = row.Cells[2].Value.ToString();
                    textBoxworEmail.Text = row.Cells[3].Value.ToString();
                    comboBoxworPos.Text = row.Cells[4].Value.ToString();
                    textBoxworSal.Text = row.Cells[5].Value.ToString();
                    break;
                case "Doctors":
                    id = int.Parse(row.Cells[0].Value.ToString());
                    textBoxdocName.Text = row.Cells[1].Value.ToString();
                    textBoxdocPhone.Text = row.Cells[2].Value.ToString();
                    textBoxdocEmail.Text = row.Cells[3].Value.ToString();
                    textBoxdocSal.Text = row.Cells[4].Value.ToString();
                    break;
                case "Parents":
                    id = int.Parse(row.Cells[0].Value.ToString());
                    textBoxparName.Text = row.Cells[1].Value.ToString();
                    textBoxparPhone.Text = row.Cells[2].Value.ToString();
                    textBoxparEgn.Text = row.Cells[2].Value.ToString();
                    break;
                case "Positions":
                    id = int.Parse(row.Cells[0].Value.ToString());
                    textBoxposName.Text = row.Cells[1].Value.ToString();
                    break;
                case "Reservations":
                    id = int.Parse(row.Cells[0].Value.ToString());
                    dateTimePicker1.Text = row.Cells[1].Value.ToString();
                    comboBoxresPac.Text = row.Cells[2].Value.ToString();
                    comboBoxresDoc.Text = row.Cells[3].Value.ToString();
                    break;
                default:
                    break;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            Dictionary<int, string> dic = new Dictionary<int, string>();
            foreach (DataRow row in table.Rows)
            {
                string name = row["parName"].ToString();
                comboBoxpacPar.Items.Add(name);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseManager dbm = new DataBaseManager();

            switch (tablename)
            {
                case "Pacients":
                    if (dbm.DeletePacientData(id))
                    {
                        MessageBox.Show("Item was deleted");
                        dataGridView.AutoResizeColumns();
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.DataSource = dbm.SelectPacient();
                    }
                    else MessageBox.Show("Data was NOT Deleted");
                    break;

                case "Workers":
                    if (dbm.DeleteWorkerData(id))
                    {
                        MessageBox.Show("Item was deleted");
                        dataGridView.AutoResizeColumns();
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.DataSource = dbm.SelectWorker();
                    }
                    else MessageBox.Show("Data was NOT Deleted");
                    break;

                case "Doctors":
                    if (dbm.DeleteDoctorData(id))
                    {
                        MessageBox.Show("Item was deleted");
                        dataGridView.AutoResizeColumns();
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.DataSource = dbm.SelectDoctor();
                    }
                    else MessageBox.Show("Data was NOT Deleted");
                    break;

                case "Parents":
                    if (dbm.DeleteParentsData(id))
                    {
                        MessageBox.Show("Item was deleted");
                        dataGridView.AutoResizeColumns();
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.DataSource = dbm.SelectParents();
                    }
                    else MessageBox.Show("Data was NOT Deleted");
                    break;

                case "Positions":
                    if (dbm.DeletePositionsData(id))
                    {
                        MessageBox.Show("Item was deleted");
                        dataGridView.AutoResizeColumns();
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.DataSource = dbm.SelectPositions();
                    }
                    else MessageBox.Show("Data was NOT Deleted");
                    break;

                case "Reservations":
                    if (dbm.DeleteReservData(id))
                    {
                        MessageBox.Show("Item was deleted");
                        dataGridView.AutoResizeColumns();
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.DataSource = dbm.SelectReservations();
                    }
                    else MessageBox.Show("Data was NOT Deleted");
                    break;

                default:
                    break;
            }
        }
    }
}
