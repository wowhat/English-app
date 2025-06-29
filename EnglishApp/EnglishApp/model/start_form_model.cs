using System;
using EnglishApp.view;
using MySql.Data.MySqlClient;
using System.Configuration;
using DotNetEnv;
using K4os.Compression.LZ4.Encoders;



namespace EnglishApp.model
{

    class start_form_model
    {
        public string check_connection()
        {
            try
            {

                string str_1 = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString; // строка подключения из dll файла
                return str_1;
            }
            catch
            {
                return reading_env(); // если dll файла нет, строка подключение идет из env файла
            }
        } // чтение dll файла
        public string reading_env()
        {
            Env.Load();

            string host = Env.GetString("MYSQL_HOST");
            string port = Env.GetString("MYSQL_PORT");
            string password = Env.GetString("MYSQL_PASSWORD");
            string user = Env.GetString("MYSQL_USER");
            string db_name = Env.GetString("MYSQL_DATABASE");

            
           return $"Server={host};Port={port};Database={db_name};User={user};Password={password}; ";
        } // чтение env файла и возврат строки подключения к бд
        public bool Connection_db(out string error_message) // подключение к бд
        {

            string connection_string = check_connection();

            using (var connection = new MySqlConnection(connection_string))
            {
                try
                {

                    connection.Open();
                    error_message = "succes";
                    string query = "SELECT \r\n    w.id AS id,\r\n    w.word AS word,\r\n    t.translate AS translate,\r\n    e.example AS example\r\nFROM word w\r\nLEFT JOIN translate t ON w.id = t.id_word\r\nLEFT JOIN example e ON w.id = e.id_word\r\nORDER BY w.id;";

                    using (MySqlCommand mysql_command = new MySqlCommand(query, connection))
                    {
                        using (var reader = mysql_command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string word = reader.GetString("word");
                                string translate = reader.GetString("translate");
                                string example = reader.GetString("example");

                                if (!all_Values.words.ContainsKey(id))
                                {
                                    all_Values.words.Add(id, new Dictionary<string, string>());
                                    all_Values.words[id].Add("word", word);
                                    all_Values.words[id].Add("translate", translate);
                                    all_Values.words[id].Add("example", example);
                                }
                            }
                        }
                    }
                    return true;

                    
                }
                catch (Exception ex)
                {
                    error_message = ex.Message;
                    return false;
                }

            }

        }
    }
}
