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
            error_message_connectionDB = new TextBox();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Location = new Point(646, 298);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(225, 86);
            btn_start.TabIndex = 6;
            btn_start.Text = "button1";
            btn_start.UseVisualStyleBackColor = true;
            // 
            // error_message_connectionDB
            // 
            error_message_connectionDB.Location = new Point(591, 447);
            error_message_connectionDB.Name = "error_message_connectionDB";
            error_message_connectionDB.Size = new Size(280, 27);
            error_message_connectionDB.TabIndex = 7;
            // 
            // Start_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(922, 597);
            Controls.Add(error_message_connectionDB);
            Controls.Add(btn_start);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox error_message_connectionDB;
    }
}