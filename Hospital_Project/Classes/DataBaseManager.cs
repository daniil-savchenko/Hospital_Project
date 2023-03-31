﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Project.Classes
{
    internal class DataBaseManager
    {
        private int idd = 1;
        private static string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory()), @"..\..\Hospital_database.mdf")) + "\";Integrated Security=True;Connect Timeout=30";
        private static SqlConnection con = new SqlConnection(constring);
        public DataBaseManager() { }

        public bool AddPacient(Pacients pacient)
        {
            idd = 1;
            SqlDataAdapter adb;
            DataTable table;
            string sqlcom = "INSERT INTO Pacients Values(@ID, @pacName, @phone, @egn, @Parent, @Doctor)";
            var select = "SELECT * FROM Pacients";

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
            string sqlcom = "INSERT INTO Positions(ID, posName)  Values(@ID, @posName)";
            var select = "SELECT * FROM Positions";

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
            string sqlcom = "INSERT INTO Workers Values(@ID, @workerName, @phone, @email, @Position, @salary)";
            var select = "SELECT * FROM Workers";
            SqlDataAdapter adb;
            DataTable table;
            try
            {
                sqlcom = "INSERT INTO Doctors Values(@ID, @workerName, @phone, @email, @salary)";
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
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
    }
}
