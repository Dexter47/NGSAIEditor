using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace NGSAIWriter
{
    class DatabaseHandler
    {
        private string host, user, password, database, exceptionMessage;
        private int port;

        public string Host { get => host; set => host = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Database { get => database; set => database = value; }
        public string ExceptionMessage { get => exceptionMessage; set => exceptionMessage = value; }
        public int Port { get => port; set => port = value; }

        public MySqlConnection DatabaseConnection()
        {
            string connectiongString = "Server={0};Uid={1};Pwd={2};Port={3};Database={4}";
            connectiongString = string.Format(connectiongString, host, user, password, port, database);
            MySqlConnection con = new MySqlConnection(connectiongString);
            return con;
        }

        public bool TestDatabaseConnection()
        {
            MySqlConnection connection = DatabaseConnection();
            return ExecuteNonQuery(string.Format("SELECT 1 FROM {0}.creature_template;", database));
        }

        public bool ExecuteNonQuery(string sql)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection())
                {
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                ExceptionMessage = e.Message;
                return false;
            }
        }

        public string PrintExceptionMessage()
        {
            string message = exceptionMessage;
            exceptionMessage = "";
            return message;
        }

        public int GetSAICounter(int entry)
        {
            using (MySqlConnection con = DatabaseConnection())
            {
                string query = "SELECT COUNT(entryorguid) FROM smart_scripts WHERE entryorguid = @entry AND source_type = 0";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@entry", entry);
                con.Open();
                int counter = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return counter;
            }
        }

        public DataTable GetSAIForCreature(int entry)
        {
            using (MySqlConnection con = DatabaseConnection())
            {
                string query = "SELECT * FROM smart_scripts WHERE entryorguid = @entry AND source_type = 0";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue("@entry", entry);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTableSchema(string tablename)
        {
            using (MySqlConnection con = DatabaseConnection())
            {
                string[] restrictions = new string[4];
                restrictions[2] = tablename;
                DataTable dt = new DataTable();
                con.Open();
                dt = con.GetSchema("Columns", restrictions);
                con.Close();
                return dt;
            }
        }

        public CreatureData FetchCreature(int entry)
        {
            try
            {
                CreatureData data = new CreatureData();

                using (MySqlConnection con = DatabaseConnection())
                {
                    string query = "SELECT entry, name, AIName FROM creature_template WHERE entry = @entry;";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@entry", entry);
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Entry = reader.GetInt32(0);
                        data.Name = reader.GetString(1);

                        if (reader.GetString(2).Equals("SmartAI"))
                        {
                            data.SaiEnabled = true;
                            data.SaiCount = GetSAICounter(entry);
                        }

                    }

                    con.Close();
                }

                return data;

            } catch (Exception ex)
            {
                return null;
            }
        }
    }
}
