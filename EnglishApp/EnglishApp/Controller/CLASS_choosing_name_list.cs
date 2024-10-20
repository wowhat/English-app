using EnglishApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp.Controller
{
    class CLASS_choosing_name_list
    {
        public void choosing_name_list()
        {
            if (Path.GetExtension(all_values.File_path) == ".xlsx")
            {
                start_form_model start_Form_Model = new start_form_model();
                start_Form_Model.Reading_names();
            }
        }
    }
}
