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
            btn_idk = new Button();
            btn_exit = new Button();
            lbl_dop_word = new Label();
            btn_start_additionaly_form = new Button();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.Font = new Font("Segoe UI", 40F);
            lbl_word.Location = new Point(342, 37);
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
            // btn_next_word
            // 
            btn_next_word.Location = new Point(470, 319);
            btn_next_word.Margin = new Padding(3, 4, 3, 4);
            btn_next_word.Name = "btn_next_word";
            btn_next_word.Size = new Size(86, 31);
            btn_next_word.TabIndex = 2;
            btn_next_word.Text = "next";
            btn_next_word.UseVisualStyleBackColor = true;
            btn_next_word.Click += btn_next_Click;
            // 
            // btn_idk
            // 
            btn_idk.Location = new Point(299, 319);
            btn_idk.Margin = new Padding(3, 4, 3, 4);
            btn_idk.Name = "btn_idk";
            btn_idk.Size = new Size(106, 31);
            btn_idk.TabIndex = 3;
            btn_idk.Text = "idk";
            btn_idk.UseVisualStyleBackColor = true;
            btn_idk.Click += btn_idk_click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(26, 24);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_dop_word
            // 
            lbl_dop_word.AutoSize = true;
            lbl_dop_word.Font = new Font("Segoe UI", 20F);
            lbl_dop_word.Location = new Point(407, 237);
            lbl_dop_word.Name = "lbl_dop_word";
            lbl_dop_word.Size = new Size(0, 46);
            lbl_dop_word.TabIndex = 5;
            // 
            // btn_start_additionaly_form
            // 
            btn_start_additionaly_form.Location = new Point(470, 319);
            btn_start_additionaly_form.Margin = new Padding(3, 4, 3, 4);
            btn_start_additionaly_form.Name = "btn_start_additionaly_form";
            btn_start_additionaly_form.Size = new Size(86, 31);
            btn_start_additionaly_form.TabIndex = 6;
            btn_start_additionaly_form.Text = "start";
            btn_start_additionaly_form.UseVisualStyleBackColor = true;
            btn_start_additionaly_form.Visible = false;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_start_additionaly_form);
            Controls.Add(lbl_dop_word);
            Controls.Add(btn_exit);
            Controls.Add(btn_idk);
            Controls.Add(btn_next_word);
            Controls.Add(textBox1);
            Controls.Add(lbl_word);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btn_idk;
        private Button btn_exit;
        private Label lbl_dop_word;
        private Button btn_start_additionaly_form;
    }
}