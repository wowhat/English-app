using EnglishApp.Controller;
using EnglishApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;


namespace EnglishApp.view
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            this.AcceptButton = btn_next_word; // при нажатии на enter срабатывает кнопка 
            this.CancelButton = btn_exit; // при нажаии на esc срабатывает кнопка
        }


        /*main_form_model main_Form_model = new main_form_model();*/

/*        public void Main_form_load(Object sender, EventArgs e)
        {*/
/*
            main_Form_model.reading_words();
            controller_main_form class_main_form = new controller_main_form();
            class_main_form.changing_the_word();
            main_Form_model.check_if_english();
            lbl_word.Text = all_values.label_word;
            lbl_count_words.Text = all_values.all_words.Count.ToString();

        }

        public void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_input_word.Text.ToLower().Trim() == all_values.input_word.ToLower().Trim())
            {
                tb_input_word.Clear();
                main_Form_model.btn_next();
                lbl_count_words.Text = all_values.all_words.Count.ToString();

            }
            lbl_word.Text = all_values.label_word;

            if (lbl_word.Text == "the end")
            {

                Check();
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Start_form start_form = new Start_form();
            start_form.Show();
            this.Hide();
        } // working

        private async void btn_idk_click(object sender, EventArgs e)
        {

            lbl_dop_word.Text = all_values.input_word;
            await Task.Delay(all_values.Delay);
            lbl_dop_word.Text = "";
            tb_input_word.Text = "";
            main_Form_model.check_if_english();
            lbl_word.Text = all_values.label_word;

        }

        public void Check()
        {
            if (lbl_word.Text == "the end")
            {
                btn_next_word.Enabled = false;
                btn_idk.Enabled = false;
            }
        }

        private void tb_input_word_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
