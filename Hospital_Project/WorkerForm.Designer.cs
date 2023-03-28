namespace Hospital_Project
{
    partial class WorkerForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NameOfWorker = new System.Windows.Forms.Label();
            this.SalaryTextBoxW = new System.Windows.Forms.TextBox();
            this.EmailTextBoxW = new System.Windows.Forms.TextBox();
            this.PhoneTextBoxW = new System.Windows.Forms.TextBox();
            this.NameTextBoxW = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.PositionTextBoxW = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PositionTextBoxW);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NameOfWorker);
            this.panel1.Controls.Add(this.SalaryTextBoxW);
            this.panel1.Controls.Add(this.EmailTextBoxW);
            this.panel1.Controls.Add(this.PhoneTextBoxW);
            this.panel1.Controls.Add(this.NameTextBoxW);
            this.panel1.Controls.Add(this.Salary);
            this.panel1.Controls.Add(this.Position);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 350);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(87, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Position";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(87, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameOfWorker
            // 
            this.NameOfWorker.AutoSize = true;
            this.NameOfWorker.Location = new System.Drawing.Point(46, 37);
            this.NameOfWorker.Name = "NameOfWorker";
            this.NameOfWorker.Size = new System.Drawing.Size(35, 13);
            this.NameOfWorker.TabIndex = 10;
            this.NameOfWorker.Text = "Name";
            // 
            // SalaryTextBoxW
            // 
            this.SalaryTextBoxW.Location = new System.Drawing.Point(87, 138);
            this.SalaryTextBoxW.Name = "SalaryTextBoxW";
            this.SalaryTextBoxW.Size = new System.Drawing.Size(100, 20);
            this.SalaryTextBoxW.TabIndex = 9;
            // 
            // EmailTextBoxW
            // 
            this.EmailTextBoxW.Location = new System.Drawing.Point(87, 86);
            this.EmailTextBoxW.Name = "EmailTextBoxW";
            this.EmailTextBoxW.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBoxW.TabIndex = 7;
            // 
            // PhoneTextBoxW
            // 
            this.PhoneTextBoxW.Location = new System.Drawing.Point(87, 60);
            this.PhoneTextBoxW.Name = "PhoneTextBoxW";
            this.PhoneTextBoxW.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBoxW.TabIndex = 6;
            // 
            // NameTextBoxW
            // 
            this.NameTextBoxW.Location = new System.Drawing.Point(87, 34);
            this.NameTextBoxW.Name = "NameTextBoxW";
            this.NameTextBoxW.Size = new System.Drawing.Size(100, 20);
            this.NameTextBoxW.TabIndex = 5;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Location = new System.Drawing.Point(46, 141);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(36, 13);
            this.Salary.TabIndex = 4;
            this.Salary.Text = "Salary";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(40, 115);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(44, 13);
            this.Position.TabIndex = 3;
            this.Position.Text = "Position";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(46, 89);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(33, 13);
            this.email.TabIndex = 2;
            this.email.Text = "Gmail";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(46, 63);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 1;
            this.Phone.Text = "Phone";
            // 
            // PositionTextBoxW
            // 
            this.PositionTextBoxW.FormattingEnabled = true;
            this.PositionTextBoxW.Location = new System.Drawing.Point(87, 112);
            this.PositionTextBoxW.Name = "PositionTextBoxW";
            this.PositionTextBoxW.Size = new System.Drawing.Size(100, 21);
            this.PositionTextBoxW.TabIndex = 13;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.panel1);
            this.Name = "WorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SalaryTextBoxW;
        private System.Windows.Forms.TextBox EmailTextBoxW;
        private System.Windows.Forms.TextBox PhoneTextBoxW;
        private System.Windows.Forms.TextBox NameTextBoxW;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label NameOfWorker;
        private System.Windows.Forms.ComboBox PositionTextBoxW;
    }
}