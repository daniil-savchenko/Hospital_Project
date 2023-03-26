namespace Hospital_Project
{
    partial class PacientForm
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
            this.NameTextDoctorP = new System.Windows.Forms.ComboBox();
            this.NameTextParentP = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.NameOfPacient = new System.Windows.Forms.Label();
            this.egnTextBoxP = new System.Windows.Forms.TextBox();
            this.phoneTextBoxP = new System.Windows.Forms.TextBox();
            this.nameTextBoxP = new System.Windows.Forms.TextBox();
            this.doctorPac = new System.Windows.Forms.Label();
            this.parentPac = new System.Windows.Forms.Label();
            this.egnPac = new System.Windows.Forms.Label();
            this.PhonePac = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameTextDoctorP);
            this.panel1.Controls.Add(this.NameTextParentP);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Submitbtn);
            this.panel1.Controls.Add(this.NameOfPacient);
            this.panel1.Controls.Add(this.egnTextBoxP);
            this.panel1.Controls.Add(this.phoneTextBoxP);
            this.panel1.Controls.Add(this.nameTextBoxP);
            this.panel1.Controls.Add(this.doctorPac);
            this.panel1.Controls.Add(this.parentPac);
            this.panel1.Controls.Add(this.egnPac);
            this.panel1.Controls.Add(this.PhonePac);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 350);
            this.panel1.TabIndex = 1;
            // 
            // NameTextDoctorP
            // 
            this.NameTextDoctorP.FormattingEnabled = true;
            this.NameTextDoctorP.Location = new System.Drawing.Point(87, 138);
            this.NameTextDoctorP.Name = "NameTextDoctorP";
            this.NameTextDoctorP.Size = new System.Drawing.Size(100, 21);
            this.NameTextDoctorP.TabIndex = 14;
            // 
            // NameTextParentP
            // 
            this.NameTextParentP.FormattingEnabled = true;
            this.NameTextParentP.Location = new System.Drawing.Point(87, 112);
            this.NameTextParentP.Name = "NameTextParentP";
            this.NameTextParentP.Size = new System.Drawing.Size(100, 21);
            this.NameTextParentP.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(87, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add parent";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Submitbtn
            // 
            this.Submitbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submitbtn.Location = new System.Drawing.Point(87, 164);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(100, 29);
            this.Submitbtn.TabIndex = 11;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // NameOfPacient
            // 
            this.NameOfPacient.AutoSize = true;
            this.NameOfPacient.Location = new System.Drawing.Point(46, 37);
            this.NameOfPacient.Name = "NameOfPacient";
            this.NameOfPacient.Size = new System.Drawing.Size(35, 13);
            this.NameOfPacient.TabIndex = 10;
            this.NameOfPacient.Text = "Name";
            // 
            // egnTextBoxP
            // 
            this.egnTextBoxP.Location = new System.Drawing.Point(87, 86);
            this.egnTextBoxP.Name = "egnTextBoxP";
            this.egnTextBoxP.Size = new System.Drawing.Size(100, 20);
            this.egnTextBoxP.TabIndex = 7;
            // 
            // phoneTextBoxP
            // 
            this.phoneTextBoxP.Location = new System.Drawing.Point(87, 60);
            this.phoneTextBoxP.Name = "phoneTextBoxP";
            this.phoneTextBoxP.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBoxP.TabIndex = 6;
            // 
            // nameTextBoxP
            // 
            this.nameTextBoxP.Location = new System.Drawing.Point(87, 34);
            this.nameTextBoxP.Name = "nameTextBoxP";
            this.nameTextBoxP.Size = new System.Drawing.Size(100, 20);
            this.nameTextBoxP.TabIndex = 5;
            // 
            // doctorPac
            // 
            this.doctorPac.AutoSize = true;
            this.doctorPac.Location = new System.Drawing.Point(42, 141);
            this.doctorPac.Name = "doctorPac";
            this.doctorPac.Size = new System.Drawing.Size(39, 13);
            this.doctorPac.TabIndex = 4;
            this.doctorPac.Text = "Doctor";
            // 
            // parentPac
            // 
            this.parentPac.AutoSize = true;
            this.parentPac.Location = new System.Drawing.Point(40, 115);
            this.parentPac.Name = "parentPac";
            this.parentPac.Size = new System.Drawing.Size(38, 13);
            this.parentPac.TabIndex = 3;
            this.parentPac.Text = "Parent";
            // 
            // egnPac
            // 
            this.egnPac.AutoSize = true;
            this.egnPac.Location = new System.Drawing.Point(46, 89);
            this.egnPac.Name = "egnPac";
            this.egnPac.Size = new System.Drawing.Size(30, 13);
            this.egnPac.TabIndex = 2;
            this.egnPac.Text = "EGN";
            // 
            // PhonePac
            // 
            this.PhonePac.AutoSize = true;
            this.PhonePac.Location = new System.Drawing.Point(46, 63);
            this.PhonePac.Name = "PhonePac";
            this.PhonePac.Size = new System.Drawing.Size(38, 13);
            this.PhonePac.TabIndex = 1;
            this.PhonePac.Text = "Phone";
            // 
            // PacientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.panel1);
            this.Name = "PacientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacient";
            this.Load += new System.EventHandler(this.PacientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label NameOfPacient;
        private System.Windows.Forms.TextBox egnTextBoxP;
        private System.Windows.Forms.TextBox phoneTextBoxP;
        private System.Windows.Forms.TextBox nameTextBoxP;
        private System.Windows.Forms.Label doctorPac;
        private System.Windows.Forms.Label parentPac;
        private System.Windows.Forms.Label egnPac;
        private System.Windows.Forms.Label PhonePac;
        private System.Windows.Forms.ComboBox NameTextParentP;
        private System.Windows.Forms.ComboBox NameTextDoctorP;
    }
}