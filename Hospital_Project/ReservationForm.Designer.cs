namespace Hospital_Project
{
    partial class ReservationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DocBox = new System.Windows.Forms.ComboBox();
            this.PacientBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.doctorRes = new System.Windows.Forms.Label();
            this.pacientRes = new System.Windows.Forms.Label();
            this.Datee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.DocBox);
            this.panel1.Controls.Add(this.PacientBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.doctorRes);
            this.panel1.Controls.Add(this.pacientRes);
            this.panel1.Controls.Add(this.Datee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 313);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd hh:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(96, 48);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // DocBox
            // 
            this.DocBox.FormattingEnabled = true;
            this.DocBox.Location = new System.Drawing.Point(96, 100);
            this.DocBox.Name = "DocBox";
            this.DocBox.Size = new System.Drawing.Size(122, 21);
            this.DocBox.TabIndex = 13;
            // 
            // PacientBox
            // 
            this.PacientBox.FormattingEnabled = true;
            this.PacientBox.Location = new System.Drawing.Point(96, 74);
            this.PacientBox.Name = "PacientBox";
            this.PacientBox.Size = new System.Drawing.Size(122, 21);
            this.PacientBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(106, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctorRes
            // 
            this.doctorRes.AutoSize = true;
            this.doctorRes.Location = new System.Drawing.Point(51, 103);
            this.doctorRes.Name = "doctorRes";
            this.doctorRes.Size = new System.Drawing.Size(39, 13);
            this.doctorRes.TabIndex = 4;
            this.doctorRes.Text = "Doctor";
            // 
            // pacientRes
            // 
            this.pacientRes.AutoSize = true;
            this.pacientRes.Location = new System.Drawing.Point(49, 77);
            this.pacientRes.Name = "pacientRes";
            this.pacientRes.Size = new System.Drawing.Size(43, 13);
            this.pacientRes.TabIndex = 3;
            this.pacientRes.Text = "Pacient";
            // 
            // Datee
            // 
            this.Datee.AutoSize = true;
            this.Datee.Location = new System.Drawing.Point(55, 51);
            this.Datee.Name = "Datee";
            this.Datee.Size = new System.Drawing.Size(30, 13);
            this.Datee.TabIndex = 2;
            this.Datee.Text = "Date";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 313);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label doctorRes;
        private System.Windows.Forms.Label pacientRes;
        private System.Windows.Forms.Label Datee;
        private System.Windows.Forms.ComboBox PacientBox;
        private System.Windows.Forms.ComboBox DocBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}