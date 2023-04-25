using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Project.Classes
{
    internal class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
    }
    internal class DataBaseManager
    {
        private int idd = 1;
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
        private static SqlConnection con = new SqlConnection(constring);
        private SqlDataAdapter adb;
        private DataTable table;
        private string sqlcom = "";
        private string select = "";
        public DataBaseManager() { }

        public bool AddPacient(Pacients pacient)
        {
            idd = 1;

            sqlcom = "INSERT INTO Pacients Values(@ID, @pacName, @phone, @egn, @Parent, @Doctor)";
            select = "SELECT * FROM Pacients";

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
                    pacient.Doctor1 = string.Empty;
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
                    pacient.Parent1 = string.Empty;
                }


                con.Close();
            }
            try
            {
                con.Open();
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@pacName", pacient.PacName);
                    insert.Parameters.AddWithValue("@phone", pacient.Phone);
                    insert.Parameters.AddWithValue("@egn", pacient.Egn);
                    insert.Parameters.AddWithValue("@Parent", int.Parse(pacient.Parent1));
                    insert.Parameters.AddWithValue("@Doctor", int.Parse(pacient.Doctor1));
                    insert.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in inserting data into DataBase");
                return false;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                con.Close();
            }
        }

        public bool AddPar(Parents parent)
        {
            idd = 1;
            sqlcom = "INSERT INTO Parents(ID, parName, phone, egn)  Values(@ID, @parName, @phone, @egn)";
            select = "SELECT * FROM Parents";

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
            try
            {
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {
                    con.Open();
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@parName", parent.ParName);
                    insert.Parameters.AddWithValue("@phone", parent.Phone);
                    insert.Parameters.AddWithValue("@egn", parent.Egn);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public bool AddPos(Positions position)
        {
            sqlcom = "INSERT INTO Positions(ID, posName)  Values(@ID, @posName)";
            select = "SELECT * FROM Positions";

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

            try
            {
                con.Open();
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@posName", position.PosName);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                con.Close();
            }
        }

        public bool AddWorker(Workers worker)
        {
            SqlDataAdapter adb;
            DataTable table;
            sqlcom = "INSERT INTO Workers Values(@ID, @workerName, @phone, @email, @Position, @salary)";
            select = "SELECT * FROM Workers";
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

            if (worker.Position1 == "Doctor")
            {
                isDoctor = true;
            }

            select = "SELECT ID from Positions where posName = @name";
            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();

                cmd.Parameters.AddWithValue("@name", worker.Position1);

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
                    worker.Position1 = string.Empty;
                }
                con.Close();
            }

            sqlcom = "INSERT INTO Workers Values(@ID, @workerName, @phone, @email, @Position, @salary)";

            try
            {
                con.Open();
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@workerName", worker.WorkerName);
                    insert.Parameters.AddWithValue("@phone", worker.Phone);
                    insert.Parameters.AddWithValue("@email", worker.Email);
                    insert.Parameters.AddWithValue("@Position", worker.Position1);
                    insert.Parameters.AddWithValue("@salary", worker.Salary);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                    if (isDoctor)
                    {
                        if (AddDoc(worker))
                        {
                            MessageBox.Show("Doctor input was successed");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Doctor input wasn't successed");
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public bool AddDoc(Workers worker)
        {
            sqlcom = "INSERT INTO Doctors Values(@ID, @workerName, @phone, @email, @salary)";
            select = "SELECT * FROM Doctors";
            try
            {
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {

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
                    insert.Parameters.AddWithValue("@workerName", worker.WorkerName);
                    insert.Parameters.AddWithValue("@phone", worker.Phone);
                    insert.Parameters.AddWithValue("@email", worker.Email);
                    insert.Parameters.AddWithValue("@salary", worker.Salary);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
        public bool AddReservation(Reservations reservation)
        {
            sqlcom = "INSERT INTO Reservations Values(@ID, @date, @pac, @doc)";
            select = "SELECT * FROM Reservations";
            idd = 1;
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

            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    select = "SELECT * FROM Pacients where pacName = @name";
                    using (SqlCommand sel = new SqlCommand(select, con))
                    {
                        con.Open();
                        adb = new SqlDataAdapter(sel);
                        table = new DataTable();
                        sel.Parameters.AddWithValue("@name", reservation.PacientId);
                        adb.Fill(table);
                        adb.Dispose();
                        if (table.Rows.Count == 1)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                reservation.PacientId = row["ID"].ToString();
                            }
                        }
                        else
                        {
                            reservation.PacientId = string.Empty;
                        }
                        con.Close();
                    }
                    select = "SELECT * FROM Doctors where workerName = @name";
                    using (SqlCommand sel = new SqlCommand(select, con))
                    {
                        con.Open();
                        adb = new SqlDataAdapter(sel);
                        table = new DataTable();
                        sel.Parameters.AddWithValue("@name", reservation.DoctorId);
                        adb.Fill(table);
                        adb.Dispose();

                        if (table.Rows.Count >= 1)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                reservation.DoctorId = row["ID"].ToString();
                            }
                        }
                        else
                        {
                            reservation.DoctorId = string.Empty;
                        }
                        con.Close();
                    }
                    if (reservation.DoctorId != string.Empty && reservation.PacientId != string.Empty)
                    {
                        con.Open();
                        cmd.Parameters.AddWithValue("@ID", idd);
                        cmd.Parameters.AddWithValue("@pac", reservation.PacientId);
                        cmd.Parameters.AddWithValue("@doc", reservation.DoctorId);
                        cmd.Parameters.AddWithValue("@date", reservation.Thedate);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }


        }

        public DataTable SelectPacient()
        {
            select = "SELECT Pacients.ID, Pacients.pacName as Name, Pacients.Phone, Pacients.egn, Parents.parName as Parent, Doctors.workerName as Doctor From (Pacients INNER JOIN Parents ON Pacients.Parent = Parents.ID)INNER JOIN Doctors ON Pacients.Doctor = Doctors.ID";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }

        public DataTable SelectWokrker()
        {
            select = "SELECT Workers.ID, Workers.WorkerName as Name, Workers.Phone, Workers.email, Positions.posName as Position, Workers.Salary FROM Workers INNER JOIN Positions ON Workers.Position = Positions.ID";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }

        public DataTable SelectDoctor()
        {
            select = "SELECT ID, workerName as Name, phone, email, salary FROM Doctors";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }

        public DataTable SelectParents()
        {
            select = "SELECT ID, parName as Name, phone, egn FROM Parents";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }

        public DataTable SelectPositions()
        {
            select = "SELECT ID, posName as Name FROM Positions";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }
        public DataTable SelectReservations()
        {
            select = "SELECT Reservations.ID, Reservations.thedate, Pacients.pacName as Patient, Doctors.workerName as Doctor FROM (Reservations INNER JOIN Pacients ON Reservations.Patient = Pacients.ID)INNER JOIN Doctors ON Reservations.Doctor = Doctors.ID";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }

        public bool UpdateUsingMethod(string tablename, string column, string newval, string oldval, string sql)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@newval", newval);
                    cmd.Parameters.AddWithValue("@value", oldval);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            
        }

        public bool UpdateData(string tablename, string column, string newval, string oldval)
        {
            try
            {
                switch (tablename)
                {
                    case "Pacients":

                        switch (column)
                        {
                            case "Name":

                                sqlcom = "Update Pacients SET pacName = @newval Where id = @value";

                                break;
                            case "Phone":
                                Regex phoneregex = new Regex(@"^0[0-9]{9}$");
                                sqlcom = "Update Pacients SET phone = @newval Where id = @value";

                                if (!phoneregex.IsMatch(newval)) return false;
                                break;

                            case "egn":
                                Regex egnregex = new Regex(@"^[0-9]{10}$");
                                sqlcom = "Update Pacients SET egn = @newval Where id = @value";

                                if (!egnregex.IsMatch(newval)) return false;
                                break;

                            case "Parent":
                                sqlcom = "Update Pacients SET Parent = @newval Where id = @value";

                                break;
                            case "Doctor":
                                sqlcom = "Update Pacients SET Doctor = @newval Where id = @value";

                                break;
                            default:
                                MessageBox.Show("Can't change Id's data");
                                return false;
                        }
                        break;
                    case "Doctors":
                        switch (column)
                        {
                            case "Name":
                                sqlcom = "Update Doctors SET workerName = @newval Where id = @value";
                                break;

                            case "phone":
                                Regex phoneregex = new Regex(@"^0[0-9]{9}$");
                                sqlcom = "Update Doctors SET phone = @newval Where id = @value";

                                if (!phoneregex.IsMatch(newval)) return false;
                                break;

                            case "email":
                                Regex reg = new Regex(@"(@)(.+)$");
                                sqlcom = "Update Doctors SET email = @newval Where id = @value";

                                if (!reg.IsMatch(newval)) return false;
                                break;

                            case "salary":
                                sqlcom = "Update Doctors SET salary = @newval Where id = @value";

                                break;
                            default:
                                MessageBox.Show("Can't change Id's data");
                                return false;
                        }
                        break;
                    case "Parents":
                        switch (column)
                        {
                            case "Name":
                                sqlcom = "Update Parents SET parName = @newval Where id = @value";
                                break;

                            case "phone":
                                Regex phoneregex = new Regex(@"^0[0-9]{9}$");
                                sqlcom = "Update Parents SET phone = @newval Where id = @value";

                                if (!phoneregex.IsMatch(newval)) return false;
                                break;

                            case "egn":
                                Regex egnregex = new Regex(@"^[0-9]{10}$");
                                sqlcom = "Update Parents SET egn = @newval Where id = @value";

                                if (!egnregex.IsMatch(newval)) return false;
                                break;

                            default: MessageBox.Show("Can't change Id's data");
                                return false;
                        }
                        break;
                    case "Positions":
                        switch (column)
                        {
                            case "Name":
                                sqlcom = "Update Positins SET posName = @newval Where id = @value";
                                break;

                            default:
                                MessageBox.Show("Can't change Id's data");
                                return false;
                        }
                        break;
                    case "Reservations":
                        switch (column)
                        {
                            case "thedate":
                                sqlcom = "UPDATE Reservations SET thedate = @newval Where id = @value";
                                break;
                            case "Patient":
                                sqlcom = "Update Reservations SET Patient = @newval Where id = @value";
                                break;
                            case "Doctor":
                                sqlcom = "Update Reservations SET Doctor = @newval Where id = @value";
                                break;
                            default: MessageBox.Show("Can't change Id's data");
                                return false;
                        }
                        break;
                    case "Workers":
                        switch (column)
                        {
                            case "Name":
                                sqlcom = "Update Workers SET workerName = @newval Where id = @value";

                                break;

                            case "Phone":
                                Regex phoneregex = new Regex(@"^0[0-9]{9}$");
                                sqlcom = "Update Workers SET phone = @newval Where id = @value";

                                if (!phoneregex.IsMatch(newval)) return false;
                                break;

                            case "email":
                                Regex reg = new Regex(@"(@)(.+)$");
                                sqlcom = "Update Workers SET email = @newval Where id = @value";

                                if (!reg.IsMatch(newval)) return false;
                                break;

                            case "Position":
                                sqlcom = "Update Workers SET Position = @newval Where id = @value";

                                if (newval == "Doctor")
                                {
                                    MessageBox.Show("Can't change current position to Doctor");
                                    return false;
                                }
                                break;

                            case "salary":
                                sqlcom = "Update Workers SET salary = @newval Where salary = @value";

                                break;

                            default:
                                MessageBox.Show("Can't change Id's data");
                                return false;
                        }
                        break;
                    default:
                        return false;
                }

                return UpdateUsingMethod(tablename, column, newval, oldval, sqlcom);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
                throw;
            }

        }

        public void AddPacItems(Panel panel2)
        {
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            label1.Location = new Point(32, 41);
            label1.Name = "label1";
            label1.Text = "Name";
            panel2.Controls.Add(label1);

            System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
            textBox1.Location = new Point(35, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 20);
            panel2.Controls.Add(textBox1);
            textBox1.BringToFront();

            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            label2.Location = new Point(32, 93);
            label2.Name = "label1";
            label2.Text = "Phone";
            panel2.Controls.Add(label2);

            System.Windows.Forms.TextBox textBox2 = new System.Windows.Forms.TextBox();
            textBox2.Location = new Point(35, 109);
            textBox2.Name = "textBox1";
            textBox2.Size = new Size(100, 20);
            panel2.Controls.Add(textBox2);
            textBox2.BringToFront();

            System.Windows.Forms.Label label3 = new System.Windows.Forms.Label();
            label3.Location = new Point(32, 149);
            label3.Name = "label1";
            label3.Text = "egn";
            panel2.Controls.Add(label3);

            System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox();
            textBox3.Location = new Point(35, 165);
            textBox3.Name = "textBox1";
            textBox3.Size = new Size(100, 20);
            panel2.Controls.Add(textBox3);
            textBox3.BringToFront();

            System.Windows.Forms.Label label4 = new System.Windows.Forms.Label();
            label4.Location = new Point(32, 204);
            label4.Name = "label1";
            label4.Text = "Parent";
            panel2.Controls.Add(label4);

            System.Windows.Forms.ComboBox comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox1.Location = new Point(34, 220);
            comboBox1.Name = "textBox1";
            comboBox1.Size = new Size(100, 20);
            panel2.Controls.Add(comboBox1);
            comboBox1.BringToFront();

            System.Windows.Forms.Label label5 = new System.Windows.Forms.Label();
            label5.Location = new Point(32, 254);
            label5.Name = "label1";
            label5.Text = "Doctor";
            panel2.Controls.Add(label5);

            System.Windows.Forms.ComboBox comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox2.Location = new Point(35, 270);
            comboBox2.Name = "textBox1";
            comboBox2.Size = new Size(100, 20);
            panel2.Controls.Add(comboBox2);
            comboBox2.BringToFront();

            select = "SELECT * From Parents";

            using (SqlCommand cmd = new SqlCommand(select,con))
            {
                con.Open();
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                foreach (DataRow row in table.Rows)
                {
                    string idd = row["ID"].ToString();
                    string name = row["parName"].ToString();
                    comboSource.Add(idd, name);
                    
                }
                comboBox1.DataSource = new BindingSource(comboSource, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                con.Close();
            }

            select = "SELECT * From Doctors";

            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                SqlDataAdapter adb = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                Dictionary<string, string> comboSource = new Dictionary<string, string>();
                foreach (DataRow row in table.Rows)
                {
                    string idd = row["ID"].ToString();
                    string name = row["workerName"].ToString();
                    comboSource.Add(idd, name);
                }
                comboBox2.DataSource = new BindingSource(comboSource, null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";
                con.Close();
            }
        }

    }
    
}
