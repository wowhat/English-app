using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishApp.model;
using Org.BouncyCastle.Bcpg.OpenPgp;
using ZstdSharp.Unsafe;

namespace EnglishApp.view
{
    public partial class Start_form : Form
    {

        private Main_form main_form;
        public Start_form()
        {
            InitializeComponent();
        }

        public void Start_form_load(object sender, EventArgs e)
        {
            start_form_model Start_form_model = new start_form_model();

            if (!Start_form_model.Connection_db(out string error))
            {
                error_connection_message.Visible = true;
                more_detailed.Visible = true;
                show_more_detailed.Text = error;
            }
            adding_lang();// добавление языков в combobox на стартовой странице
            btn_start_is_enabled();
        }

        public void adding_lang()
        {
            foreach (var item in all_Values.language_list)
            {
                cb_selection_lang.Items.Add(item);
            }
        } // добавление языка в combobox на стартовой странице

        // метод проверки параметров для запуска main_form
        private void btn_start_is_enabled()
        {
            btn_start.Enabled = show_more_detailed.Text == string.Empty && cb_selection_lang.Text != string.Empty;
        }

        // метод для запуска main_form 
        private void btn_start_click(object sender, EventArgs e)
        {
            if (main_form == null || main_form.IsDisposed)
            {
                main_form = new Main_form(this);
            }
            main_form.Show();
            this.Hide();
        }

        // метод для показа подробности ошибки
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

        //метод для изменения значения в combobox
        private void cb_selection_lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_start_is_enabled(); // доступность нажатия кнопки
            set_lang(); // установка языка
        }

        // метод для установки языка
        private void set_lang()
        {
            if (cb_selection_lang.SelectedItem == "eng")
            {
                all_Values.label_word = "word";
                all_Values.translate_word = "translate";
            }
            else
            {
                all_Values.label_word = "translate";
                all_Values.translate_word = "word";
            }
        }
    }
}
