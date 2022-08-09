namespace MSG91
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.api_textbox = new DevExpress.XtraEditors.TextEdit();
            this.clear_button = new DevExpress.XtraEditors.SimpleButton();
            this.Login_button = new DevExpress.XtraEditors.SimpleButton();
            this.show_char = new DevExpress.XtraEditors.CheckEdit();
            this.status_text = new DevExpress.XtraEditors.LabelControl();
            this.Close_Button = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.api_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_char.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Enter your API Key";
            // 
            // api_textbox
            // 
            this.api_textbox.Location = new System.Drawing.Point(24, 48);
            this.api_textbox.Name = "api_textbox";
            this.api_textbox.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.api_textbox.Properties.Appearance.Options.UseFont = true;
            this.api_textbox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.api_textbox.Properties.PasswordChar = '●';
            this.api_textbox.Size = new System.Drawing.Size(301, 22);
            this.api_textbox.TabIndex = 1;
            this.api_textbox.TextChanged += new System.EventHandler(this.api_textbox_TextChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(24, 115);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(133, 28);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "Reset";
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(192, 115);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(133, 28);
            this.Login_button.TabIndex = 3;
            this.Login_button.Text = "Verify and Save";
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // show_char
            // 
            this.show_char.Location = new System.Drawing.Point(24, 83);
            this.show_char.Name = "show_char";
            this.show_char.Properties.Caption = "Show Character";
            this.show_char.Size = new System.Drawing.Size(301, 19);
            this.show_char.TabIndex = 4;
            this.show_char.CheckedChanged += new System.EventHandler(this.show_char_CheckedChanged);
            // 
            // status_text
            // 
            this.status_text.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.status_text.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.status_text.Location = new System.Drawing.Point(12, 170);
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(0, 13);
            this.status_text.TabIndex = 5;
            // 
            // Close_Button
            // 
            this.Close_Button.AutoSize = true;
            this.Close_Button.Location = new System.Drawing.Point(318, 2);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(33, 13);
            this.Close_Button.TabIndex = 6;
            this.Close_Button.TabStop = true;
            this.Close_Button.Text = "Close";
            this.Close_Button.Visible = false;
            this.Close_Button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Close_Button_LinkClicked);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 175);
            this.ControlBox = false;
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.status_text);
            this.Controls.Add(this.show_char);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.api_textbox);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.api_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_char.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit api_textbox;
        private DevExpress.XtraEditors.SimpleButton clear_button;
        private DevExpress.XtraEditors.SimpleButton Login_button;
        private DevExpress.XtraEditors.CheckEdit show_char;
        private DevExpress.XtraEditors.LabelControl status_text;
        private System.Windows.Forms.LinkLabel Close_Button;
    }
}