using EnglishApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishApp.Controller
{
    class CLASS_btn_open_file
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
    }
}
