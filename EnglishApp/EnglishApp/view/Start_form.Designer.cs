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
            btn_start = new Button();
            error_connection_message = new Label();
            more_detailed = new Label();
            show_more_detailed = new TextBox();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Franklin Gothic Medium", 14F);
            btn_start.Location = new Point(646, 299);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(225, 86);
            btn_start.TabIndex = 6;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            // 
            // error_connection_message
            // 
            error_connection_message.AutoSize = true;
            error_connection_message.BackColor = Color.Transparent;
            error_connection_message.Font = new Font("Segoe UI", 12F);
            error_connection_message.ForeColor = Color.Red;
            error_connection_message.Location = new Point(28, 43);
            error_connection_message.Name = "error_connection_message";
            error_connection_message.Size = new Size(351, 28);
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
            more_detailed.Size = new Size(99, 23);
            more_detailed.TabIndex = 8;
            more_detailed.Text = "Подробнее";
            more_detailed.Visible = false;
            more_detailed.Click += lbl_more_detailed_click;
            // 
            // show_more_detailed
            // 
            show_more_detailed.BackColor = SystemColors.InactiveBorder;
            show_more_detailed.BorderStyle = BorderStyle.FixedSingle;
            show_more_detailed.Location = new Point(29, 136);
            show_more_detailed.Multiline = true;
            show_more_detailed.Name = "show_more_detailed";
            show_more_detailed.ReadOnly = true;
            show_more_detailed.Size = new Size(344, 98);
            show_more_detailed.TabIndex = 9;
            show_more_detailed.Visible = false;
            // 
            // Start_form
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(922, 597);
            Controls.Add(show_more_detailed);
            Controls.Add(more_detailed);
            Controls.Add(error_connection_message);
            Controls.Add(btn_start);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(940, 644);
            MinimumSize = new Size(940, 644);
            Name = "Start_form";
            StartPosition = FormStartPosition.CenterParent;
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
        private Button btn_start;
        private Label error_connection_message;
        private Label more_detailed;
        private TextBox show_more_detailed;
    }
}