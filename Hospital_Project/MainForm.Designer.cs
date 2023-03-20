namespace Hospital_Project
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pacientbtn = new System.Windows.Forms.Button();
            this.Workerbtn = new System.Windows.Forms.Button();
            this.Reservbtn = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 390);
            this.panel2.TabIndex = 3;
            // 
            // Pacientbtn
            // 
            this.Pacientbtn.AutoSize = true;
            this.Pacientbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pacientbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pacientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pacientbtn.Location = new System.Drawing.Point(0, 0);
            this.Pacientbtn.Name = "Pacientbtn";
            this.Pacientbtn.Size = new System.Drawing.Size(200, 78);
            this.Pacientbtn.TabIndex = 3;
            this.Pacientbtn.Text = "Pacient";
            this.Pacientbtn.UseVisualStyleBackColor = false;
            this.Pacientbtn.Click += new System.EventHandler(this.Pacientbtn_Click);
            // 
            // Workerbtn
            // 
            this.Workerbtn.AutoSize = true;
            this.Workerbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Workerbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Workerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Workerbtn.Location = new System.Drawing.Point(0, 78);
            this.Workerbtn.Name = "Workerbtn";
            this.Workerbtn.Size = new System.Drawing.Size(200, 78);
            this.Workerbtn.TabIndex = 4;
            this.Workerbtn.Text = "Worker";
            this.Workerbtn.UseVisualStyleBackColor = false;
            this.Workerbtn.Click += new System.EventHandler(this.Workerbtn_Click);
            // 
            // Reservbtn
            // 
            this.Reservbtn.AutoSize = true;
            this.Reservbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Reservbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reservbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservbtn.Location = new System.Drawing.Point(0, 156);
            this.Reservbtn.Name = "Reservbtn";
            this.Reservbtn.Size = new System.Drawing.Size(200, 78);
            this.Reservbtn.TabIndex = 5;
            this.Reservbtn.Text = "Reservation";
            this.Reservbtn.UseVisualStyleBackColor = false;
            this.Reservbtn.Click += new System.EventHandler(this.Reservbtn_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.AutoSize = true;
            this.Printbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Printbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Printbtn.Location = new System.Drawing.Point(0, 234);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(200, 76);
            this.Printbtn.TabIndex = 6;
            this.Printbtn.Text = "Output Data";
            this.Printbtn.UseVisualStyleBackColor = false;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Printbtn);
            this.panel1.Controls.Add(this.Reservbtn);
            this.panel1.Controls.Add(this.Workerbtn);
            this.panel1.Controls.Add(this.Pacientbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 390);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pacientbtn;
        private System.Windows.Forms.Button Workerbtn;
        private System.Windows.Forms.Button Reservbtn;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Panel panel1;
    }
}

