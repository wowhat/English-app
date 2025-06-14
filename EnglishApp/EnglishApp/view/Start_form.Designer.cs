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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_form));
            btn_open_file = new Button();
            cmb_choosing_name_list = new ComboBox();
            cmb_choosing_lang = new ComboBox();
            btn_start = new Button();
            SuspendLayout();
            // 
            // btn_open_file
            // 
            btn_open_file.BackColor = Color.PaleTurquoise;
            btn_open_file.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_open_file.ForeColor = Color.Black;
            btn_open_file.Location = new Point(685, 217);
            btn_open_file.Name = "btn_open_file";
            btn_open_file.Size = new Size(183, 39);
            btn_open_file.TabIndex = 1;
            btn_open_file.Text = "Open Files";
            btn_open_file.UseVisualStyleBackColor = false;
            btn_open_file.Click += btn_open_file_Click;
            // 
            // cmb_choosing_name_list
            // 
            cmb_choosing_name_list.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmb_choosing_name_list.FormattingEnabled = true;
            cmb_choosing_name_list.Location = new Point(685, 305);
            cmb_choosing_name_list.Name = "cmb_choosing_name_list";
            cmb_choosing_name_list.Size = new Size(183, 24);
            cmb_choosing_name_list.TabIndex = 2;
            cmb_choosing_name_list.SelectedIndexChanged += cmb_choosing_name_list_SelectedIndexChanged;
            // 
            // cmb_choosing_lang
            // 
            cmb_choosing_lang.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmb_choosing_lang.FormattingEnabled = true;
            cmb_choosing_lang.Location = new Point(685, 369);
            cmb_choosing_lang.Name = "cmb_choosing_lang";
            cmb_choosing_lang.Size = new Size(183, 24);
            cmb_choosing_lang.TabIndex = 3;
            cmb_choosing_lang.SelectedIndexChanged += cmb_choosing_lang_SelectedIndexChanged;
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.Aquamarine;
            btn_start.BackgroundImageLayout = ImageLayout.Stretch;
            btn_start.Enabled = false;
            btn_start.FlatStyle = FlatStyle.System;
            btn_start.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_start.ForeColor = Color.AntiqueWhite;
            btn_start.Location = new Point(685, 440);
            btn_start.Margin = new Padding(3, 2, 3, 2);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(183, 43);
            btn_start.TabIndex = 4;
            btn_start.Text = "start";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_click;
            // 
            // Start_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(933, 609);
            Controls.Add(btn_start);
            Controls.Add(cmb_choosing_lang);
            Controls.Add(cmb_choosing_name_list);
            Controls.Add(btn_open_file);
            Name = "Start_form";
            Text = " ";
            Load += Start_form_Load;
            ResumeLayout(false);
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btn_open_file;
        private ComboBox cmb_choosing_name_list;
        private ComboBox cmb_choosing_lang;
        private Button btn_start;
    }
}