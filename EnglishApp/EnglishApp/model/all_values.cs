using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp.model
{
    class all_values
    {
        public static string File_path { get; set; }
        public static List<string> sheet_names = new List<string>();
        public static KeyValuePair<string, string> the_word { get; set; }

        public static List<string> language_list = new List<string>();
        public static string choosed_lang { get; set; }

        public static string choosed_list { get; set; }


    }
}
