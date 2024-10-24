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
            bnt_next_word = new Button();
            btn_add_new_list = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Font = new Font("Segoe UI", 40F);
            lbl_word.Location = new Point(347, 36);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(214, 89);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(327, 184);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 1;
            // 
            // bnt_next_word
            // 
            bnt_next_word.Location = new Point(470, 292);
            bnt_next_word.Margin = new Padding(3, 4, 3, 4);
            bnt_next_word.Name = "bnt_next_word";
            bnt_next_word.Size = new Size(86, 31);
            bnt_next_word.TabIndex = 2;
            bnt_next_word.Text = "next";
            bnt_next_word.UseVisualStyleBackColor = true;
            // 
            // btn_add_new_list
            // 
            btn_add_new_list.Location = new Point(327, 292);
            btn_add_new_list.Margin = new Padding(3, 4, 3, 4);
            btn_add_new_list.Name = "btn_add_new_list";
            btn_add_new_list.Size = new Size(86, 31);
            btn_add_new_list.TabIndex = 3;
            btn_add_new_list.Text = "add in new list";
            btn_add_new_list.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(26, 24);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "exit";
            btn_exit.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_exit);
            Controls.Add(btn_add_new_list);
            Controls.Add(bnt_next_word);
            Controls.Add(textBox1);
            Controls.Add(lbl_word);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main_form";
            Text = "Main_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_word;
        private TextBox textBox1;
        private Button bnt_next_word;
        private Button btn_add_new_list;
        private Button btn_exit;
    }
}