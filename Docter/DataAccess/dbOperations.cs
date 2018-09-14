using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Docter.DataAccess
{
   public class dbOperations
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter adapter;
        private SqlDataReader reader;
        private DataSet dataSet;
        private DataTable dataTable;
        //public string connString= "Data Source=DESKTOP-V9GGFFC\\Pathum;Initial Catalog=DOCTERDB;User ID=sa;Password=***********";
        public string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Docter\\Docter\\DoctorDB.mdf;Integrated Security=True";
        public dbOperations()
        {
            SetConncectionString(connString);
        }




        #region Connection
        public void SetConncectionString(string connString)
        {
            sqlConnection = new SqlConnection(connString);
           // MessageBox.Show(connString);
        }

        public bool checkDatabaseExist()
        {
            try
            {
                
                ConOpen();
               // MessageBox.Show("True checked");
                return true;
            }
            catch
            {
               // MessageBox.Show("false cheked");
                return false;
                
            }
        }

        public void GenerateDatabase()
        {
            List<string> cmds = new List<string>();
            if (File.Exists(Application.StartupPath + "\\DocterDB.sql"))
            {
                TextReader tr = new StreamReader(Application.StartupPath + "\\DocterDB.sql");
                string line = "";
                string cmd = "";
                while ((line = tr.ReadLine()) != null)
                {
                    if (line.Trim().ToUpper() == "GO")
                    {
                        cmds.Add(cmd);
                        cmd = "";
                    }
                    else
                    {
                        cmd += line + "\r\n";
                    }
                }
                if (cmd.Length > 0)
                {
                    cmds.Add(cmd);
                    cmd = "";
                }
                tr.Close();
            }
            if (cmds.Count > 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = new SqlConnection("Data Source=DESKTOP-V9GGFFC;Initial Catalog=DocterDB;Integrated Security=True;");
                command.CommandType = System.Data.CommandType.Text;
                command.Connection.Open();
                for (int i = 0; i < cmds.Count; i++)
                {
                    command.CommandText = cmds[i];
                    command.ExecuteNonQuery();
                }
            }

        }

        private void ConOpen()
        {
           // MessageBox.Show(sqlConnection.State.ToString());
            
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("This Error Occured: " + ex);

            }
        }

        private void ConClose()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        #endregion

        #region Insert, Update, Delete
        private Int32 InsertUpdateDelete(string query)
        {
            Int32 AffectedRows = 0;
            ConOpen();
            sqlCommand = new SqlCommand(query, sqlConnection);
            AffectedRows = sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            ConClose();
            return AffectedRows;
        }

        public Int32 InsertData(string query)
        {
            return InsertUpdateDelete(query);
        }
        public Int32 UpdateData(string query)
        {
            return InsertUpdateDelete(query);
        }
        public Int32 DeleteData(string query)
        {
            return InsertUpdateDelete(query);
        }
        #endregion

        #region Retrieve single Data

        public string GetStringValue(string query)
        {
            string ReturnValue = "";
            ConOpen();
            sqlCommand = new SqlCommand(query, sqlConnection);
            reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                ReturnValue = reader[0].ToString();
                
            }
            if (!reader.IsClosed)
            {
                reader.Close();
            }

            reader.Close();
            //ConClose();

            return ReturnValue;
        }

        public Int32 GetIntValue(string query)
        {
            Int32 ReturnValue=0;
            ConOpen();
            sqlCommand = new SqlCommand(query, sqlConnection);
            reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                ReturnValue = Int32.Parse(reader[0].ToString());

            }
            if (!reader.IsClosed)
            {
                reader.Close();
            }

            reader.Close();
            ConClose();

            return ReturnValue;
        }


        #endregion

        public Boolean isAvailable(string query)
        {
            ConOpen();
            sqlCommand = new SqlCommand(query, sqlConnection);
            Boolean result = (bool)sqlCommand.ExecuteScalar();
            ConClose();

            return result;
        }


        #region Retrieve multiple data

        public Boolean SelectMultipleRows(string query,ref DataTable table)
        {
            Boolean hasData = false;
            try
            {
                ConOpen();
                adapter = new SqlDataAdapter(query, sqlConnection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count <= 0)
                {
                    hasData = true;
                }
                else
                {
                    hasData = false;
                }
                ConClose();
            }
            catch(Exception ex)
            {

            }
            
            return hasData;

        }

        public DataTable SelectMultipleDataSet(string query)
        {
            DataTable table = new DataTable();
            try
            {
                ConOpen();
                adapter = new SqlDataAdapter(query, sqlConnection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count < 0)
                {
                    table = dataTable;
                }
                else
                {
                    table = dataTable;
                }
                ConClose();
            }
            catch (Exception ex)
            {

            }

            return table;

        }
       
        public DataSet SelectOneColumn(string query)
        {
            ConOpen();
            adapter = new SqlDataAdapter(query, sqlConnection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataTable = dataSet.Tables[0];

            return dataSet;

        }

        public Boolean SelectOneRow(string query,ref DataRow dataRow)
        {
            Boolean hasData = false;
            try
            {
                ConOpen();
                dataTable = new DataTable();
                adapter = new SqlDataAdapter(query, sqlConnection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                dataRow = dataTable.Rows[0];

                if (dataTable.Rows.Count <= 0)
                {
                    hasData = false;
                }
                else
                {
                    hasData = true;
                }
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                ConClose();
            }
            return hasData;

        }
        #endregion

        public Boolean checkDuplicate(string query)
        {
            Boolean hasData = false;
           
            ConOpen();
            sqlCommand = new SqlCommand(query, sqlConnection);
            try
            {
                ConOpen();
                adapter = new SqlDataAdapter(query, sqlConnection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                if (dataTable.Rows.Count == 0)
                {
                    hasData = true;
                }
                else
                {
                    hasData = false;
                }
                ConClose();
            }
            catch (Exception ex)
            {

            }

            return hasData;
        }
    }
}
