namespace MSG91
{
    partial class SendSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendSMS));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.to_textbox = new DevExpress.XtraEditors.TextEdit();
            this.msg_textbox = new DevExpress.XtraEditors.MemoEdit();
            this.word_count = new System.Windows.Forms.Label();
            this.reset_button = new DevExpress.XtraEditors.SimpleButton();
            this.schedule_button = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sender_id = new DevExpress.XtraEditors.ComboBoxEdit();
            this.route = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.schedule_date = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.schedule_time = new DevExpress.XtraEditors.TimeEdit();
            this.send_button = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.to_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msg_textbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sender_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_time.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.schedule_time);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.schedule_date);
            this.groupControl1.Controls.Add(this.route);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.sender_id);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.schedule_button);
            this.groupControl1.Controls.Add(this.send_button);
            this.groupControl1.Controls.Add(this.reset_button);
            this.groupControl1.Controls.Add(this.word_count);
            this.groupControl1.Controls.Add(this.msg_textbox);
            this.groupControl1.Controls.Add(this.to_textbox);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(25, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(386, 361);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Message Information Detail";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(12, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "To";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Message";
            // 
            // to_textbox
            // 
            this.to_textbox.Location = new System.Drawing.Point(29, 47);
            this.to_textbox.Name = "to_textbox";
            this.to_textbox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.to_textbox.Properties.NullText = "Enter your Contact Numbers here";
            this.to_textbox.Size = new System.Drawing.Size(319, 20);
            this.to_textbox.TabIndex = 2;
            // 
            // msg_textbox
            // 
            this.msg_textbox.Location = new System.Drawing.Point(29, 88);
            this.msg_textbox.Name = "msg_textbox";
            this.msg_textbox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.msg_textbox.Properties.MaxLength = 1000;
            this.msg_textbox.Properties.NullText = "Enter your message here";
            this.msg_textbox.Size = new System.Drawing.Size(319, 61);
            this.msg_textbox.TabIndex = 3;
            this.msg_textbox.TextChanged += new System.EventHandler(this.msg_textbox_TextChanged);
            // 
            // word_count
            // 
            this.word_count.Location = new System.Drawing.Point(248, 152);
            this.word_count.Name = "word_count";
            this.word_count.Size = new System.Drawing.Size(100, 16);
            this.word_count.TabIndex = 4;
            this.word_count.Text = "0/0";
            this.word_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(29, 311);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(98, 29);
            this.reset_button.TabIndex = 5;
            this.reset_button.Text = "Reset All";
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // schedule_button
            // 
            this.schedule_button.Location = new System.Drawing.Point(141, 311);
            this.schedule_button.Name = "schedule_button";
            this.schedule_button.Size = new System.Drawing.Size(98, 29);
            this.schedule_button.TabIndex = 7;
            this.schedule_button.Text = "Schedule SMS";
            this.schedule_button.Click += new System.EventHandler(this.schedule_button_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 159);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Sender ID";
            // 
            // sender_id
            // 
            this.sender_id.EditValue = "MARUAT";
            this.sender_id.Location = new System.Drawing.Point(29, 175);
            this.sender_id.Name = "sender_id";
            this.sender_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.sender_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sender_id.Properties.MaxLength = 6;
            this.sender_id.Size = new System.Drawing.Size(319, 20);
            this.sender_id.TabIndex = 9;
            // 
            // route
            // 
            this.route.EditValue = "4";
            this.route.Location = new System.Drawing.Point(29, 219);
            this.route.Name = "route";
            this.route.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.route.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.route.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.route.Size = new System.Drawing.Size(319, 20);
            this.route.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 202);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Route";
            // 
            // schedule_date
            // 
            this.schedule_date.EditValue = null;
            this.schedule_date.Enabled = false;
            this.schedule_date.Location = new System.Drawing.Point(27, 265);
            this.schedule_date.Name = "schedule_date";
            this.schedule_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.schedule_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.schedule_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.schedule_date.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.schedule_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.schedule_date.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.schedule_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.schedule_date.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.schedule_date.Size = new System.Drawing.Size(168, 20);
            this.schedule_date.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 246);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Schedule Time";
            // 
            // schedule_time
            // 
            this.schedule_time.EditValue = null;
            this.schedule_time.Enabled = false;
            this.schedule_time.Location = new System.Drawing.Point(199, 265);
            this.schedule_time.Name = "schedule_time";
            this.schedule_time.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.schedule_time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.schedule_time.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.schedule_time.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.schedule_time.Properties.Mask.EditMask = "HH:mm:ss";
            this.schedule_time.Size = new System.Drawing.Size(149, 20);
            this.schedule_time.TabIndex = 14;
            // 
            // send_button
            // 
            this.send_button.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.send_button.Location = new System.Drawing.Point(250, 311);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(98, 29);
            this.send_button.TabIndex = 6;
            this.send_button.Text = "Send";
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // SendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 418);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send SMS - MSG91";
            this.Load += new System.EventHandler(this.SendSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.to_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msg_textbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sender_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedule_time.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit to_textbox;
        private DevExpress.XtraEditors.MemoEdit msg_textbox;
        private System.Windows.Forms.Label word_count;
        private DevExpress.XtraEditors.SimpleButton reset_button;
        private DevExpress.XtraEditors.SimpleButton send_button;
        private DevExpress.XtraEditors.SimpleButton schedule_button;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit sender_id;
        private DevExpress.XtraEditors.ComboBoxEdit route;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit schedule_date;
        private DevExpress.XtraEditors.TimeEdit schedule_time;
    }
}