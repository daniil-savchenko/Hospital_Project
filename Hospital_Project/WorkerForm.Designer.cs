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
            this.Printbtn = new System.Windows.Forms.Button();
            this.Reservbtn = new System.Windows.Forms.Button();
            this.Workerbtn = new System.Windows.Forms.Button();
            this.Pacientbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Homebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Printbtn);
            this.panel1.Controls.Add(this.Reservbtn);
            this.panel1.Controls.Add(this.Workerbtn);
            this.panel1.Controls.Add(this.Pacientbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 390);
            this.panel1.TabIndex = 6;
            // 
            // Printbtn
            // 
            this.Printbtn.AutoSize = true;
            this.Printbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Printbtn.Location = new System.Drawing.Point(0, 234);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(200, 78);
            this.Printbtn.TabIndex = 6;
            this.Printbtn.Text = "Output Data";
            this.Printbtn.UseVisualStyleBackColor = true;
            // 
            // Reservbtn
            // 
            this.Reservbtn.AutoSize = true;
            this.Reservbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reservbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservbtn.Location = new System.Drawing.Point(0, 156);
            this.Reservbtn.Name = "Reservbtn";
            this.Reservbtn.Size = new System.Drawing.Size(200, 78);
            this.Reservbtn.TabIndex = 5;
            this.Reservbtn.Text = "Reservation";
            this.Reservbtn.UseVisualStyleBackColor = true;
            // 
            // Workerbtn
            // 
            this.Workerbtn.AutoSize = true;
            this.Workerbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Workerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Workerbtn.Location = new System.Drawing.Point(0, 78);
            this.Workerbtn.Name = "Workerbtn";
            this.Workerbtn.Size = new System.Drawing.Size(200, 78);
            this.Workerbtn.TabIndex = 4;
            this.Workerbtn.Text = "Worker";
            this.Workerbtn.UseVisualStyleBackColor = true;
            // 
            // Pacientbtn
            // 
            this.Pacientbtn.AutoSize = true;
            this.Pacientbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pacientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pacientbtn.Location = new System.Drawing.Point(0, 0);
            this.Pacientbtn.Name = "Pacientbtn";
            this.Pacientbtn.Size = new System.Drawing.Size(200, 78);
            this.Pacientbtn.TabIndex = 3;
            this.Pacientbtn.Text = "Pacient";
            this.Pacientbtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Homebtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 5;
            // 
            // Homebtn
            // 
            this.Homebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Homebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Homebtn.Location = new System.Drawing.Point(0, 0);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(200, 60);
            this.Homebtn.TabIndex = 3;
            this.Homebtn.Text = "Main menu";
            this.Homebtn.UseVisualStyleBackColor = false;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "WorkerForm";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Button Reservbtn;
        private System.Windows.Forms.Button Workerbtn;
        private System.Windows.Forms.Button Pacientbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Homebtn;
    }
}