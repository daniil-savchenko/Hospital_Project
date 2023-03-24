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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.doctorRes = new System.Windows.Forms.Label();
            this.pacientRes = new System.Windows.Forms.Label();
            this.Datee = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.doctorRes);
            this.panel1.Controls.Add(this.pacientRes);
            this.panel1.Controls.Add(this.Datee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 313);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(96, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 100);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label doctorRes;
        private System.Windows.Forms.Label pacientRes;
        private System.Windows.Forms.Label Datee;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}