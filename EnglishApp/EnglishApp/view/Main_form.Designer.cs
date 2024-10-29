namespace EnglishApp.view
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_word = new Label();
            textBox1 = new TextBox();
            btn_next_word = new Button();
            btn_add_new_list = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Font = new Font("Segoe UI", 40F);
            lbl_word.Location = new Point(304, 27);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(172, 72);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            // 
            // btn_next_word
            // 
            btn_next_word.Location = new Point(411, 219);
            btn_next_word.Name = "btn_next_word";
            btn_next_word.Size = new Size(75, 23);
            btn_next_word.TabIndex = 2;
            btn_next_word.Text = "next";
            btn_next_word.UseVisualStyleBackColor = true;
            btn_next_word.Click += btn_next_Click;
            // 
            // btn_add_new_list
            // 
            btn_add_new_list.Location = new Point(286, 219);
            btn_add_new_list.Name = "btn_add_new_list";
            btn_add_new_list.Size = new Size(75, 23);
            btn_add_new_list.TabIndex = 3;
            btn_add_new_list.Text = "add in new list";
            btn_add_new_list.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(23, 18);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(82, 22);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_exit);
            Controls.Add(btn_add_new_list);
            Controls.Add(btn_next_word);
            Controls.Add(textBox1);
            Controls.Add(lbl_word);
            Name = "Main_form";
            Text = "Main_form";
            Load += Main_form_load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Bnt_next_word_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbl_word;
        private TextBox textBox1;
        private Button btn_next_word;
        private Button btn_add_new_list;
        private Button btn_exit;
    }
}