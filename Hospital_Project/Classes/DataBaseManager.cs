using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
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
                MessageBox.Show("Error with Data Input");
                return false;
            }
            finally 
            { 
                con.Close();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

        }

        public void AddPos(Positions position)
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

            if (position.PosName != string.Empty)
            {
                con.Open();
                using (SqlCommand insert = new SqlCommand(sqlcom, con))
                {
                    insert.Parameters.AddWithValue("@ID", idd);
                    insert.Parameters.AddWithValue("@posName", position.PosName);
                    insert.CommandType = CommandType.Text;
                    insert.ExecuteNonQuery();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                con.Close();
                /*this.Close();
                this.Dispose();*/
            }
            else MessageBox.Show("please Input the Position");
        }

    }
}
