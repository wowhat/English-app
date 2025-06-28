using System.Runtime.CompilerServices;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            lbl_word = new Label();
            tb_input_word = new TextBox();
            btn_next_word = new Button();
            btn_idk = new Button();
            btn_exit = new Button();
            lbl_dop_word = new Label();
            lbl_count_words = new Label();
            SuspendLayout();
            // 
            // lbl_word
            // 
            lbl_word.AutoSize = true;
            lbl_word.BackColor = Color.Transparent;
            lbl_word.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_word.Location = new Point(275, 167);
            lbl_word.Name = "lbl_word";
            lbl_word.Size = new Size(95, 35);
            lbl_word.TabIndex = 0;
            lbl_word.Text = "label1";
            // 
            // tb_input_word
            // 
            tb_input_word.BackColor = SystemColors.HighlightText;
            tb_input_word.BorderStyle = BorderStyle.FixedSingle;
            tb_input_word.Font = new Font("Segoe UI", 15F);
            tb_input_word.Location = new Point(275, 246);
            tb_input_word.Name = "tb_input_word";
            tb_input_word.Size = new Size(397, 34);
            tb_input_word.TabIndex = 1;
            // 
            // btn_next_word
            // 
            btn_next_word.BackColor = Color.Transparent;
            btn_next_word.BackgroundImageLayout = ImageLayout.None;
            btn_next_word.Cursor = Cursors.Hand;
            btn_next_word.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_next_word.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_next_word.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_next_word.FlatStyle = FlatStyle.Flat;
            btn_next_word.Location = new Point(501, 346);
            btn_next_word.Name = "btn_next_word";
            btn_next_word.Size = new Size(159, 38);
            btn_next_word.TabIndex = 2;
            btn_next_word.UseVisualStyleBackColor = false;
            // 
            // btn_idk
            // 
            btn_idk.BackColor = Color.Transparent;
            btn_idk.Cursor = Cursors.Hand;
            btn_idk.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_idk.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_idk.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_idk.FlatStyle = FlatStyle.Flat;
            btn_idk.Location = new Point(275, 347);
            btn_idk.Name = "btn_idk";
            btn_idk.Size = new Size(171, 42);
            btn_idk.TabIndex = 3;
            btn_idk.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Location = new Point(54, 49);
            btn_exit.Margin = new Padding(3, 2, 3, 2);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(106, 25);
            btn_exit.TabIndex = 4;
            btn_exit.UseVisualStyleBackColor = true;
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
            // lbl_count_words
            // 
            lbl_count_words.AutoSize = true;
            lbl_count_words.BackColor = Color.Transparent;
            lbl_count_words.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_count_words.ForeColor = SystemColors.ActiveCaption;
            lbl_count_words.Location = new Point(546, 526);
            lbl_count_words.Name = "lbl_count_words";
            lbl_count_words.Size = new Size(53, 37);
            lbl_count_words.TabIndex = 7;
            lbl_count_words.Text = "12";
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(943, 639);
            Controls.Add(lbl_count_words);
            Controls.Add(lbl_dop_word);
            Controls.Add(btn_exit);
            Controls.Add(btn_idk);
            Controls.Add(btn_next_word);
            Controls.Add(tb_input_word);
            Controls.Add(lbl_word);
            MaximumSize = new Size(959, 678);
            MinimumSize = new Size(959, 678);
            Name = "Main_form";
            Text = "Main_form";
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
        private Label lbl_count_words;
    }
}