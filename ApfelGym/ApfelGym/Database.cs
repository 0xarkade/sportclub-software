using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace ApfelGym
{
    public class Database
    {
        private const string dbFilePath = "SportClubx.mdb";
        private const string connectionStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=False";
        private OleDbConnection connection;
        private OleDbCommand command;

        public Database()
        {
            Setup();
        }

        /// <summary>
        /// Path to database file
        /// </summary>
        /// <param name="dbFile"></param>
        public Database(string dbFile)
        {
            Setup(dbFile);
        }

        protected void Setup()
        {
            connection = new OleDbConnection(string.Format(connectionStr, dbFilePath));
            command = connection.CreateCommand();
        }

        protected void Setup(string dbFile)
        {
            connection = new OleDbConnection(string.Format(connectionStr, dbFile));
            command = connection.CreateCommand();
        }

        public bool ExecNoResult(string SQL)
        {
            try
            {
                connection.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(command.CommandText, connection);

                command.CommandText = SQL;
                command.ExecuteNonQuery();

                
                connection.Close();

                return true;
            }
            catch (OleDbException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public DataTable GetDataTable(string SQL)
        {
            try
            {
                connection.Open();

                command.CommandText = SQL;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command.CommandText, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();

                return dt;
            }
            catch (OleDbException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public long GetDecimalQuery(string SQL)
        {
            long value = 0;

            try
            {
                connection.Open();

                command.CommandText = SQL;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command.CommandText, connection);
                OleDbDataReader reader = adapter.SelectCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    Int64.TryParse(reader[0].ToString(), out value);
                }

                connection.Close();

                return value;
            }
            catch (OleDbException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return value;
        }

        public double GetDoubleQuery(string SQL)
        {
            double value = 0;

            try
            {
                connection.Open();

                command.CommandText = SQL;

                OleDbDataAdapter adapter = new OleDbDataAdapter(command.CommandText, connection);
                OleDbDataReader reader = adapter.SelectCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    double.TryParse(reader[0].ToString(), out value);
                }

                connection.Close();

                return value;
            }
            catch (OleDbException ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return value;
        }


        public static bool dbFileExists()
        {
            if (System.IO.File.Exists(dbFilePath)) return true;
            return false;
        }

        public static string FilterParam(string param)
        {
            //Very simple sql injection filter, of course should not be used in real world scenario.
            return param.Replace("'", "").Replace("\"", "");
        }



    }
}
