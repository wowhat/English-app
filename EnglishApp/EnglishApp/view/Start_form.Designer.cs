using System.Drawing.Drawing2D;
using System.Net.NetworkInformation;
using EnglishApp.model;

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
            error_connection_message = new Label();
            more_detailed = new Label();
            show_more_detailed = new TextBox();
            btn_start = new Button();
            cb_selection_lang = new ComboBox();
            SuspendLayout();
            // 
            // error_connection_message
            // 
            error_connection_message.AutoSize = true;
            error_connection_message.BackColor = Color.Transparent;
            error_connection_message.Font = new Font("Segoe UI", 12F);
            error_connection_message.ForeColor = Color.Red;
            error_connection_message.Location = new Point(28, 43);
            error_connection_message.Name = "error_connection_message";
            error_connection_message.Size = new Size(274, 21);
            error_connection_message.TabIndex = 7;
            error_connection_message.Text = "Подключение к базе не определено ";
            error_connection_message.Visible = false;
            // 
            // more_detailed
            // 
            more_detailed.AutoSize = true;
            more_detailed.BackColor = Color.Transparent;
            more_detailed.Font = new Font("Segoe UI", 10F);
            more_detailed.Location = new Point(260, 84);
            more_detailed.Name = "more_detailed";
            more_detailed.Size = new Size(81, 19);
            more_detailed.TabIndex = 8;
            more_detailed.Text = "Подробнее";
            more_detailed.Visible = false;
            more_detailed.Click += lbl_more_detailed_click;
            // 
            // show_more_detailed
            // 
            show_more_detailed.BackColor = SystemColors.InactiveBorder;
            show_more_detailed.BorderStyle = BorderStyle.FixedSingle;
            show_more_detailed.Location = new Point(28, 130);
            show_more_detailed.Multiline = true;
            show_more_detailed.Name = "show_more_detailed";
            show_more_detailed.ReadOnly = true;
            show_more_detailed.Size = new Size(344, 98);
            show_more_detailed.TabIndex = 9;
            show_more_detailed.Visible = false;
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.Transparent;
            btn_start.Cursor = Cursors.Hand;
            btn_start.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            btn_start.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_start.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Location = new Point(402, 287);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(216, 50);
            btn_start.TabIndex = 10;
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_click;
            // 
            // cb_selection_lang
            // 
            cb_selection_lang.FormattingEnabled = true;
            cb_selection_lang.Location = new Point(437, 381);
            cb_selection_lang.Name = "cb_selection_lang";
            cb_selection_lang.Size = new Size(149, 23);
            cb_selection_lang.TabIndex = 11;
            cb_selection_lang.SelectedIndexChanged += cb_selection_lang_SelectedIndexChanged;
            // 
            // Start_form
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(940, 601);
            Controls.Add(cb_selection_lang);
            Controls.Add(show_more_detailed);
            Controls.Add(more_detailed);
            Controls.Add(error_connection_message);
            Controls.Add(btn_start);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(956, 640);
            MinimumSize = new Size(956, 640);
            Name = "Start_form";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Start_form_load;
            ResumeLayout(false);
            PerformLayout();
        }


        private void Btn_start(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion
        private Label error_connection_message;
        private Label more_detailed;
        private TextBox show_more_detailed;
        private Button btn_start;
        private ComboBox cb_selection_lang;
    }
}