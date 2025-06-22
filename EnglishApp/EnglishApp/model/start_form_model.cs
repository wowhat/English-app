using System;
using EnglishApp.view;
using MySql.Data.MySqlClient;
using System.Configuration;
using DotNetEnv;



namespace EnglishApp.model
{

    class start_form_model
    {
      
        Start_form start_form = new Start_form();

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

            
            return $"Server={host};Port={port};Database={db_name};User={user};Password={password}";
        }
        public void Connection_db(TextBox lb1)
        {

            string connection_string = check_connection();

            using (var connection = new MySqlConnection(connection_string))
            {

                try
                {
                    connection.Open();
                    lb1.Text = "succesfull";
                }
                catch (Exception ex)
                {
                    lb1.Text = connection_string;
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
