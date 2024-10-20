using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishApp.Controller;
using EnglishApp.model;

namespace EnglishApp.view
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
        }









        public void Start_form_Load(object send, EventArgs e)
        {

        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            CLASS_btn_open_file class_btn_open_file = new CLASS_btn_open_file();
            class_btn_open_file.open_file();

            CLASS_choosing_name_list class_choosing_name_list = new CLASS_choosing_name_list();
            class_choosing_name_list.choosing_name_list();
          

            foreach (var item in all_values.sheet_names)
            {
                cmb_choosing_name_list.Items.Add(item);
            }
        }

        private void cmb_choosing_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
