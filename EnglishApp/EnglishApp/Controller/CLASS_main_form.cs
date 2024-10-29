using EnglishApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp.Controller
{
    class CLASS_main_form
    {

        public void changing_the_word()
        {
            main_form_model main_Form_Model = new main_form_model();
            
            switch (all_values.choosed_lang)
            {
                case "eng":
                    all_values.isEnglish = true;
                    break;

                case "rus":
                    all_values.isEnglish = false;
                    break;
            }
        }
    }
}
