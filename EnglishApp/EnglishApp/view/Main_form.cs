using EnglishApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishApp.view
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        public void Main_form_load(Object sender, EventArgs e)
        {
            main_form_model Main_form_model = new main_form_model();
            Main_form_model.reading_words();

            
        }

        public void btn_next_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Start_form start_form = new Start_form();
            start_form.Show();
            this.Hide();
        } // working
    }
}
