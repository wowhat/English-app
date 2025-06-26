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

                string str_1 = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                return str_1;
            }
            catch
            {
                return reading_env();
            }
        }
        public string reading_env()
        {
            Env.Load();

            string host = Env.GetString("MYSQL_HOST");
            string port = Env.GetString("MYSQL_PORT");
            string password = Env.GetString("MYSQL_PASSWORD");
            string user = Env.GetString("MYSQL_USER");
            string db_name = Env.GetString("MYSQL_DATABASE");

            
           return $"Server={host};Port={port};Database={db_name};User={user};Password={password}; ";
        }
        public bool Connection_db(out string error_message)
        {

            string connection_string = check_connection();

            using (var connection = new MySqlConnection(connection_string))
            {

                try
                {
                    connection.Open();
                    error_message = "succes";
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

        // выбор языка устарело
        /* public void choosing_lang()
         {
             string[] arr_lang = { "rus", "eng" };

             foreach (string item in arr_lang)
             {
                 all_values.language_list.Add(item);
             }
         }*/
}
