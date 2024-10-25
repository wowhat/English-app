using EnglishApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp.Controller
{
    class CLASS_start_form
    {
        public void open_file()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                start_form_model Start_form_model = new start_form_model();
                Start_form_model.set_file_path(openFileDialog.FileName);
            }
        }
        public void choosing_lang()
        {
            start_form_model Start_form_model = new start_form_model();
            Start_form_model.choosing_lang();
        }
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
