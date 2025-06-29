using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp.model
{
    class all_Values
    {
        public static string label_word { get; set; }
        public static string translate_word { get; set; }
        public static string lbl_word { get; set; }
        public static string inp_word { get; set; }
        public static Dictionary<string,string> current_word = new Dictionary<string,string>();

        public static List<string> language_list = new List<string> { "rus" , "eng"} ;

        public static bool isEnglish { get; set; }

        public static string errorMessage_connectionDb { get; set; }
     
        public static Dictionary<int, Dictionary<string,string>> words = new Dictionary<int, Dictionary<string,string>>();
    }
}
