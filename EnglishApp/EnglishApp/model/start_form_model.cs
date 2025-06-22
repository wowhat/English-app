using System;
using EnglishApp.view;
using MySql.Data.MySqlClient;
using System.Configuration;



namespace EnglishApp.model
{

    class start_form_model
    {
        Start_form start_form = new Start_form();

        public void Connection_db(TextBox lb1)
        {
            string connection_string = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (var connection = new MySqlConnection(connection_string))
            {
                
                try
                {                    
                    connection.Open();
                    lb1.Text = "succesfull";
                }
                catch (Exception ex){lb1.Text = ex.ToString(); }
                
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
}
