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
        private Start_form form; //Стартовая форма 
        private Random random = new Random();
        
        public Main_form(Start_form start_Form)
        {
            InitializeComponent();
            this.AcceptButton = btn_next_word; // при нажатии на enter срабатывает кнопка 
            this.CancelButton = btn_exit; // при нажаии на esc срабатывает кнопка
            form = start_Form; // в стартовую форму передается ссылочное значение
            set_next_word();
        }

        private void set_next_word()
        {
            lbl_translate.Text = string.Empty;
            tb_input_word.Text = string.Empty;
            set_word();
        }

     

        private async void btn_idk_click(object sender, EventArgs e)
        {
            lbl_translate.Text = all_Values.current_word[all_Values.translate_word].ToString();
            await Task.Delay(2000);
            set_next_word();
        }
        private void btn_next_click(object sender, EventArgs e)
        {
            if(all_Values.current_word[all_Values.translate_word].ToString().ToLower().Trim() == tb_input_word.Text.ToLower().Trim())
            {
                
                set_next_word();
               
            }
        }
        private void set_word()
        {
            int rand_count = random.Next(1, all_Values.words.Count); // создание случайного числа
            all_Values.current_word = all_Values.words[rand_count]; // присваивание случайного слова переменной из всех слов с помощью случайного числа
            lbl_word.Text = all_Values.current_word[all_Values.label_word].ToString();
            lbl_example.Text = all_Values.current_word["example"].ToString(); 
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            form.Show(); // стартовая форма показывается 
            this.Close(); // мейн форма полностью закрывается
        } // working

    }
}
