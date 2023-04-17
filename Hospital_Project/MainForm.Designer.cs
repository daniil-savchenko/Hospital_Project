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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pacientbtn = new System.Windows.Forms.Button();
            this.Workerbtn = new System.Windows.Forms.Button();
            this.Reservbtn = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 402);
            this.panel2.TabIndex = 3;
            // 
            // Pacientbtn
            // 
            this.Pacientbtn.AutoSize = true;
            this.Pacientbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pacientbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Pacientbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pacientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pacientbtn.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.Pacientbtn.Location = new System.Drawing.Point(0, 0);
            this.Pacientbtn.Name = "Pacientbtn";
            this.Pacientbtn.Size = new System.Drawing.Size(194, 78);
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
            this.Workerbtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workerbtn.Location = new System.Drawing.Point(0, 78);
            this.Workerbtn.Name = "Workerbtn";
            this.Workerbtn.Size = new System.Drawing.Size(194, 78);
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
            this.Reservbtn.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.Reservbtn.Location = new System.Drawing.Point(0, 156);
            this.Reservbtn.Name = "Reservbtn";
            this.Reservbtn.Size = new System.Drawing.Size(194, 78);
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
            this.Printbtn.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.Printbtn.Location = new System.Drawing.Point(0, 234);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(194, 76);
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
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 402);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 47);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(750, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(766, 488);
            this.MinimumSize = new System.Drawing.Size(766, 488);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pacientbtn;
        private System.Windows.Forms.Button Workerbtn;
        private System.Windows.Forms.Button Reservbtn;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

