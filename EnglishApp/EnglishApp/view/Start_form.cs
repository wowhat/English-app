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
using Microsoft.Extensions.FileProviders;

namespace EnglishApp.view
{
    public partial class Start_form : Form
    {
        CLASS_start_form class_btn_open_file = new CLASS_start_form();

        public Start_form()
        {
            InitializeComponent();
        }


        public void Start_form_Load(object send, EventArgs e)
        {

        }


        public void bnt_open_file()
        {
            class_btn_open_file.open_file();
        } 
        public void choose_name_list() 
        {

            class_btn_open_file.choosing_name_list();

            foreach (var item in all_values.sheet_names)
            {
                cmb_choosing_name_list.Items.Add(item);
            }
        }
        public void choose_language()
        {

            class_btn_open_file.choosing_lang();

            foreach (var item in all_values.language_list)
            {
                cmb_choosing_lang.Items.Add(item);
            }
        }

        private void clearing_all_virable()
        {
            cmb_choosing_name_list.Items.Clear();
            all_values.sheet_names.Clear();
            all_values.language_list.Clear();
        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {

            clearing_all_virable();
            bnt_open_file(); // open file 
            choose_name_list(); // выбор названия страцицы
            choose_language(); // выбор языкa
        }

        private void btn_start_is_enabled()
        {
            if (all_values.choosed_lang != null && all_values.choosed_list != null)
            {
                btn_start.Enabled = true;
            }
        }
        private void btn_start_click(object sender, EventArgs e) 
        {
            Main_form main_form = new Main_form();

            main_form.Show();
        }
        private void cmb_choosing_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            all_values.choosed_list = Convert.ToString(cmb_choosing_name_list.SelectedItem);
            btn_start_is_enabled();
        }

        private void cmb_choosing_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            all_values.choosed_lang = Convert.ToString(cmb_choosing_lang.SelectedItem);
            btn_start_is_enabled();
        }

    }
}
