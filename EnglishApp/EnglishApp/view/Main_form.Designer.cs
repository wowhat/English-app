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
            tb_input_word = new TextBox();
            btn_next_word = new Button();
            btn_idk = new Button();
            btn_exit = new Button();
            lbl_dop_word = new Label();
            label1 = new Label();
            lbl_count_words = new Label();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Font = new Font("Segoe UI", 25F);
            lbl_word.Location = new Point(231, 51);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(109, 46);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "label1";
            // 
            // tb_input_word
            // 
            tb_input_word.Font = new Font("Segoe UI", 15F);
            tb_input_word.Location = new Point(231, 151);
            tb_input_word.Name = "tb_input_word";
            tb_input_word.Size = new Size(270, 34);
            tb_input_word.TabIndex = 1;
            // 
            // btn_next_word
            // 
            btn_next_word.BackColor = Color.Transparent;
            btn_next_word.Location = new Point(378, 258);
            btn_next_word.Name = "btn_next_word";
            btn_next_word.Size = new Size(123, 35);
            btn_next_word.TabIndex = 2;
            btn_next_word.Text = "next";
            btn_next_word.UseVisualStyleBackColor = false;
            btn_next_word.Click += btn_next_Click;
            // 
            // btn_idk
            // 
            btn_idk.Location = new Point(231, 258);
            btn_idk.Name = "btn_idk";
            btn_idk.Size = new Size(123, 35);
            btn_idk.TabIndex = 3;
            btn_idk.Text = "idk";
            btn_idk.UseVisualStyleBackColor = true;
            btn_idk.Click += btn_idk_click;
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
            // lbl_dop_word
            // 
            lbl_dop_word.AutoSize = true;
            lbl_dop_word.BackColor = Color.White;
            lbl_dop_word.Font = new Font("Segoe UI", 13F);
            lbl_dop_word.Location = new Point(231, 207);
            lbl_dop_word.Name = "lbl_dop_word";
            lbl_dop_word.Size = new Size(0, 25);
            lbl_dop_word.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(623, 28);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 6;
            label1.Text = "count words";
            // 
            // lbl_count_words
            // 
            lbl_count_words.AutoSize = true;
            lbl_count_words.Location = new Point(702, 28);
            lbl_count_words.Name = "lbl_count_words";
            lbl_count_words.Size = new Size(0, 15);
            lbl_count_words.TabIndex = 7;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_count_words);
            Controls.Add(label1);
            Controls.Add(lbl_dop_word);
            Controls.Add(btn_exit);
            Controls.Add(btn_idk);
            Controls.Add(btn_next_word);
            Controls.Add(tb_input_word);
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
        private TextBox tb_input_word;
        private Button btn_next_word;
        private Button btn_idk;
        private Button btn_exit;
        private Label lbl_dop_word;
        private Button btn_start_additionaly_form;
        private Label label1;
        private Label lbl_count_words;
    }
}