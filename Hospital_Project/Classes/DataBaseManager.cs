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
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

                    if (int.Parse(row["ID"].ToString()) == idd)
                    {
                        idd++;
                    } else break;
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
                    if (int.Parse(row["ID"].ToString()) == idd)
                    {
                        idd++;
                    }
                    else break;
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
                    if (int.Parse(row["ID"].ToString()) == idd)
                    {
                        idd++;
                    }
                    else break;
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

        public bool AddWorker(Workers worker, bool isDoctor)
        {
            SqlDataAdapter adb;
            DataTable table;
            sqlcom = "INSERT INTO Workers Values(@ID, @workerName, @phone, @email, @Position, @salary)";
            select = "SELECT * FROM Workers";

            using (SqlCommand cmd = new SqlCommand(select, con))
            {
                con.Open();
                adb = new SqlDataAdapter(cmd);
                table = new DataTable();
                adb.Fill(table);
                adb.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    if (int.Parse(row["ID"].ToString()) == idd)
                    {
                        idd++;
                    }
                    else break;
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
                            if (int.Parse(row["ID"].ToString()) == idd)
                            {
                                idd++;
                            }
                            else break;
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
                    if (int.Parse(row["ID"].ToString()) == idd)
                    {
                        idd++;
                    }
                    else break;
                }
                con.Close();
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    
                        con.Open();
                        cmd.Parameters.AddWithValue("@ID", idd);
                        cmd.Parameters.AddWithValue("@pac", reservation.PacientId);
                        cmd.Parameters.AddWithValue("@doc", reservation.DoctorId);
                        cmd.Parameters.AddWithValue("@date", reservation.Thedate);
                        cmd.ExecuteNonQuery();
                        return true;
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

        public DataTable SelectWorker()
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
            select = "SELECT Reservations.ID, Reservations.thedate, Pacients.pacName as Pacient, Doctors.workerName as Doctor FROM (Reservations INNER JOIN Pacients ON Reservations.Patient = Pacients.ID)INNER JOIN Doctors ON Reservations.Doctor = Doctors.ID";
            SqlCommand cmd = new SqlCommand(select, con);
            adb = new SqlDataAdapter(cmd);
            table = new DataTable();
            adb.Fill(table);
            adb.Dispose();
            return table;
        }

        public bool UpdatePacientTable(Pacients pacient)
        {
            try
            {
                con.Open();
                sqlcom = "Update Pacients SET pacName = @parname, phone = @phone, egn = @egn , Parent = @par, Doctor = @doc WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@parname", pacient.PacName);
                    cmd.Parameters.AddWithValue("@phone", pacient.Phone);
                    cmd.Parameters.AddWithValue("@egn", pacient.Egn);
                    cmd.Parameters.AddWithValue("@par", pacient.Parent1);
                    cmd.Parameters.AddWithValue("@doc", pacient.Doctor1);
                    cmd.Parameters.AddWithValue("@ID", pacient.ID);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateWorkerTable(Workers worker)
        {
            try
            {
                con.Open();
                sqlcom = "Update Workers SET workerName = @workerName, phone = @phone, email = @email , Position = @pos, salary = @sal WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@workerName", worker.WorkerName);
                    cmd.Parameters.AddWithValue("@phone", worker.Phone);
                    cmd.Parameters.AddWithValue("@email", worker.Email);
                    cmd.Parameters.AddWithValue("@pos", worker.Position1);
                    cmd.Parameters.AddWithValue("@sal", worker.Salary);
                    cmd.Parameters.AddWithValue("@id", worker.ID);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateDoctorsTable(Workers worker)
        {
            try
            {
                con.Open();
                sqlcom = "Update Doctors SET workerName = @workerName, phone = @phone, email = @email , salary = @sal WHERE ID = @id";

                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@workerName", worker.WorkerName);
                    cmd.Parameters.AddWithValue("@phone", worker.Phone);
                    cmd.Parameters.AddWithValue("@email", worker.Email);
                    cmd.Parameters.AddWithValue("@sal", worker.Salary);
                    cmd.Parameters.AddWithValue("@id", worker.ID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateParentTable(Parents parent)
        {
            try
            {
                con.Open();

                sqlcom = "Update Parents Set parName = @parname, phone = @phone, egn = @egn where ID = @id";

                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@parname", parent.ParName);
                    cmd.Parameters.AddWithValue("@phone", parent.Phone);
                    cmd.Parameters.AddWithValue("@egn", parent.Egn);
                    cmd.Parameters.AddWithValue("@id", parent.ID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdatePositionsTable(Positions positions)
        {
            try
            {
                con.Open();

                sqlcom = "Update Positions Set posName = @posname where ID = @id";

                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@posname", positions.PosName);
                    cmd.Parameters.AddWithValue("@id", positions.ID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateReservationsTable(Reservations reservations)
        {
            sqlcom = "Update Reservations Set thedate = @date, Patient = @pac, Doctor = @doc where ID = @id";
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@date", reservations.Thedate);
                    cmd.Parameters.AddWithValue("@pac", reservations.PacientId);
                    cmd.Parameters.AddWithValue("@doc", reservations.DoctorId);
                    cmd.Parameters.AddWithValue("@id", reservations.ID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool DeletePacientData(int id)
        {
            sqlcom = "DELETE FROM Pacients where ID = @id";

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@id", id.ToString());
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }

        }

        public bool DeleteWorkerData(int id)
        {
            sqlcom = "DELETE FROM Workers Where ID = @id";

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool DeleteDoctorData(int id)
        {
            sqlcom = "DELETE FROM Doctors Where ID = @id";

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool DeleteParentsData(int id)
        {
            sqlcom = "DELETE FROM Parents Where ID = @id";

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool DeleteReservData(int id)
        {
            sqlcom = "DELETE FROM Reservations Where ID = @id";

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool DeletePositionsData(int id)
        {
            sqlcom = "DELETE FROM Positions Where ID = @id";

            try
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlcom, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally { con.Close(); }
        }

        public bool Checker(List<string> list)
        {
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (string.IsNullOrEmpty(list[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
    
}
