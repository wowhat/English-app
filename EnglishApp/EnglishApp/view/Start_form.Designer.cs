﻿namespace EnglishApp.view
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
            SuspendLayout();
            // 
            // lbl_start
            // 
            lbl_start.AutoSize = true;
            lbl_start.Font = new Font("Segoe UI", 35F);
            lbl_start.Location = new Point(325, 45);
            lbl_start.Name = "lbl_start";
            lbl_start.Size = new Size(122, 62);
            lbl_start.TabIndex = 0;
            lbl_start.Text = "Start";
            // 
            // btn_open_file
            // 
            btn_open_file.Location = new Point(307, 147);
            btn_open_file.Name = "btn_open_file";
            btn_open_file.Size = new Size(159, 34);
            btn_open_file.TabIndex = 1;
            btn_open_file.Text = "Open File";
            btn_open_file.UseVisualStyleBackColor = true;
            btn_open_file.Click += btn_open_file_Click;
            // 
            // cmb_choosing_name_list
            // 
            cmb_choosing_name_list.FormattingEnabled = true;
            cmb_choosing_name_list.Location = new Point(307, 214);
            cmb_choosing_name_list.Name = "cmb_choosing_name_list";
            cmb_choosing_name_list.Size = new Size(159, 23);
            cmb_choosing_name_list.TabIndex = 2;
            cmb_choosing_name_list.SelectedIndexChanged += cmb_choosing_name_list_SelectedIndexChanged;
            // 
            // Start_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb_choosing_name_list);
            Controls.Add(btn_open_file);
            Controls.Add(lbl_start);
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
    }
}