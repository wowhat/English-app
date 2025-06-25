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
using ZstdSharp.Unsafe;

namespace EnglishApp.view
{
    public partial class Start_form : Form
    {

        public Start_form()
        {
            InitializeComponent();
        }

        public void Start_form_load(object sender, EventArgs e)
        {
            start_form_model Start_form_model = new start_form_model();

            if(!Start_form_model.Connection_db(out string error))
            {
                error_connection_message.Visible = true;
                more_detailed.Visible = true;
                show_more_detailed.Text = error;
            }
        }

        /* public void bnt_open_file()
         {
             class_btn_open_file.open_file();
         } */ // для старой версии с excel
        /*public void choose_name_list() 
        {

            class_btn_open_file.choosing_name_list();

            foreach (var item in all_values.sheet_names)
            {
                cmb_choosing_name_list.Items.Add(item);
            }
        }*/ // для старой версии с excel
        /*public void choose_language()
        {

            class_btn_open_file.choosing_lang();

            foreach (var item in all_values.language_list)
            {
                cmb_choosing_lang.Items.Add(item);
            }
        }*/ // тут нужно подумать как выбирать язык

        /*private void clearing_all_virable()
        {
            cmb_choosing_name_list.Items.Clear();
            all_values.sheet_names.Clear();
            all_values.language_list.Clear();
            cmb_choosing_lang.Items.Clear();
        }*/ // тоже нужно подумать как очищать переменные

        /*private void btn_open_file_Click(object sender, EventArgs e)
        {

            clearing_all_virable(); // destroy data 
            bnt_open_file(); // open file 
            choose_name_list(); // выбор названия страцицы
            choose_language(); // выбор языкa
        }*/ // кнопка открытия файла не нужна (для старой версии с excel)

        private void btn_start_is_enabled()
        {
            if (all_values.choosed_lang != null && all_values.choosed_list != null)
            {
                btn_start.Enabled = true;
            }
        } // метод проверки параметров для запуска main_form

        // метод для запуска main_form 
        private void btn_start_click(object sender, EventArgs e)
        {
            Main_form main_form = new Main_form();
            this.Hide();
            main_form.Show();
        }
        private void lbl_more_detailed_click(object sender, EventArgs e)
        {

            if (show_more_detailed.Visible == true)
            {
                more_detailed.Text = "Подробнее";
                show_more_detailed.Visible = false;
            }
            else if (show_more_detailed.Visible == false)
            {
                show_more_detailed.Visible = true;
                more_detailed.Text = "Скрыть";
            }
        }

    


        // метод для установки значения в глобальную переменную "имя листа" устарело...
        /* private void cmb_choosing_name_list_SelectedIndexChanged(object sender, EventArgs e)
         {
             all_values.choosed_list = Convert.ToString(cmb_choosing_name_list.SelectedItem);
             btn_start_is_enabled();
         }*/

        // я пока не придумал как выбирать язык, пока устарело
        /*  private void cmb_choosing_lang_SelectedIndexChanged(object sender, EventArgs e)
          {
              all_values.choosed_lang = Convert.ToString(cmb_choosing_lang.SelectedItem);
              btn_start_is_enabled();
          }*/

    }
}
