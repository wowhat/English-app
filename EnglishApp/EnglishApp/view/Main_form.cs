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
using OfficeOpenXml.Drawing.Slicer.Style;


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


        main_form_model main_Form_model = new main_form_model();

        public void Main_form_load(Object sender, EventArgs e)
        {

            main_Form_model.reading_words();
            CLASS_main_form class_main_form = new CLASS_main_form();
            class_main_form.changing_the_word();
            main_Form_model.check_if_english();
            lbl_word.Text = all_values.label_word;

        }

        public void btn_next_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower().Trim() == all_values.input_word.ToLower().Trim())
            {
                textBox1.Clear();
                main_Form_model.btn_next();

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

        public void show_the_additionaly_button()
        {
            btn_add_in_new_list.Enabled = false;
            btn_start_additionaly_form.Visible = true;
        }

        public void btn_addintionaly_form_Click(object sender, EventArgs e)
        {
            main_Form_model.opening_additionaly_form(this);
        } // открытие дополнительной формы


        private void btn_add_new_list_Click(object sender, EventArgs e)
        {

            main_Form_model.adding_words_to_new_list();
            lbl_word.Text = all_values.label_word;
            Check();
        }
        
        public void Check()
        {
            if (lbl_word.Text == "the end" && all_values.additionaly_words.Count != 0)
            {
                btn_next_word.Enabled = false;
                btn_add_in_new_list.Enabled = false;
                show_the_additionaly_button();
            }
            else if(lbl_word.Text == "the end")
            {
                btn_next_word.Enabled = false;
                btn_add_in_new_list.Enabled = false;
            }
        }

    }
}
