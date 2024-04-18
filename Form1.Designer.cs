namespace DiscordTimestamp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IncludeDateCheckbox = new System.Windows.Forms.CheckBox();
            this.MeridianBox = new System.Windows.Forms.ComboBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.MinuteBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IncludeDateCheckbox
            // 
            this.IncludeDateCheckbox.AutoSize = true;
            this.IncludeDateCheckbox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeDateCheckbox.Location = new System.Drawing.Point(56, 48);
            this.IncludeDateCheckbox.Name = "IncludeDateCheckbox";
            this.IncludeDateCheckbox.Size = new System.Drawing.Size(117, 26);
            this.IncludeDateCheckbox.TabIndex = 3;
            this.IncludeDateCheckbox.Text = "Include Date";
            this.IncludeDateCheckbox.UseVisualStyleBackColor = true;
            this.IncludeDateCheckbox.CheckedChanged += new System.EventHandler(this.IncludeDateCheckbox_CheckedChanged);
            // 
            // MeridianBox
            // 
            this.MeridianBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MeridianBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeridianBox.FormattingEnabled = true;
            this.MeridianBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.MeridianBox.Location = new System.Drawing.Point(127, 10);
            this.MeridianBox.Name = "MeridianBox";
            this.MeridianBox.Size = new System.Drawing.Size(58, 32);
            this.MeridianBox.TabIndex = 2;
            // 
            // CopyButton
            // 
            this.CopyButton.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.Location = new System.Drawing.Point(234, 10);
            this.CopyButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(117, 58);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(12, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(339, 30);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // HourBox
            // 
            this.HourBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourBox.Location = new System.Drawing.Point(39, 10);
            this.HourBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.HourBox.MaxLength = 2;
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(31, 32);
            this.HourBox.TabIndex = 0;
            this.HourBox.TextChanged += new System.EventHandler(this.HourBox_TextChanged);
            // 
            // MinuteBox
            // 
            this.MinuteBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteBox.Location = new System.Drawing.Point(90, 10);
            this.MinuteBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MinuteBox.MaxLength = 2;
            this.MinuteBox.Name = "MinuteBox";
            this.MinuteBox.Size = new System.Drawing.Size(31, 32);
            this.MinuteBox.TabIndex = 1;
            this.MinuteBox.TextChanged += new System.EventHandler(this.MinuteBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 77);
            this.Controls.Add(this.MinuteBox);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.IncludeDateCheckbox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.MeridianBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Discord Timestamper";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IncludeDateCheckbox;
        private System.Windows.Forms.ComboBox MeridianBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.TextBox MinuteBox;
    }
}

