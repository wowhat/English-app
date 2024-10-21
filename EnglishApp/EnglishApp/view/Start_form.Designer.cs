namespace EnglishApp.view
{
    partial class Start_form
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
            lbl_start = new Label();
            btn_open_file = new Button();
            cmb_choosing_name_list = new ComboBox();
            cmb_choosing_lang = new ComboBox();
            SuspendLayout();
            // 
            // lbl_start
            // 
            lbl_start.AutoSize = true;
            lbl_start.Font = new Font("Segoe UI", 35F);
            lbl_start.Location = new Point(371, 60);
            lbl_start.Name = "lbl_start";
            lbl_start.Size = new Size(153, 78);
            lbl_start.TabIndex = 0;
            lbl_start.Text = "Start";
            // 
            // btn_open_file
            // 
            btn_open_file.Location = new Point(351, 196);
            btn_open_file.Margin = new Padding(3, 4, 3, 4);
            btn_open_file.Name = "btn_open_file";
            btn_open_file.Size = new Size(182, 45);
            btn_open_file.TabIndex = 1;
            btn_open_file.Text = "Open File";
            btn_open_file.UseVisualStyleBackColor = true;
            btn_open_file.Click += btn_open_file_Click;
            // 
            // cmb_choosing_name_list
            // 
            cmb_choosing_name_list.FormattingEnabled = true;
            cmb_choosing_name_list.Location = new Point(352, 271);
            cmb_choosing_name_list.Margin = new Padding(3, 4, 3, 4);
            cmb_choosing_name_list.Name = "cmb_choosing_name_list";
            cmb_choosing_name_list.Size = new Size(181, 28);
            cmb_choosing_name_list.TabIndex = 2;
            // 
            // cmb_choosing_lang
            // 
            cmb_choosing_lang.FormattingEnabled = true;
            cmb_choosing_lang.Location = new Point(352, 328);
            cmb_choosing_lang.Margin = new Padding(3, 4, 3, 4);
            cmb_choosing_lang.Name = "cmb_choosing_lang";
            cmb_choosing_lang.Size = new Size(181, 28);
            cmb_choosing_lang.TabIndex = 3;
            cmb_choosing_lang.SelectedIndexChanged += cmb_choosing_lang_SelectedIndexChanged;
            // 
            // Start_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cmb_choosing_lang);
            Controls.Add(cmb_choosing_name_list);
            Controls.Add(btn_open_file);
            Controls.Add(lbl_start);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Start_form";
            Text = "Start_form";
            Load += Start_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_start;
        private Button btn_open_file;
        private ComboBox cmb_choosing_name_list;
        private ComboBox cmb_choosing_lang;
    }
}