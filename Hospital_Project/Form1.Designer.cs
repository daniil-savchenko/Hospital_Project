﻿namespace Hospital_Project
{
    partial class Form1
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
            this.PacientButton = new System.Windows.Forms.Button();
            this.WorkerButton = new System.Windows.Forms.Button();
            this.ReservButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PacientButton
            // 
            this.PacientButton.Location = new System.Drawing.Point(0, 0);
            this.PacientButton.Name = "PacientButton";
            this.PacientButton.Size = new System.Drawing.Size(132, 103);
            this.PacientButton.TabIndex = 0;
            this.PacientButton.Text = "Pacient";
            this.PacientButton.UseVisualStyleBackColor = true;
            // 
            // WorkerButton
            // 
            this.WorkerButton.Location = new System.Drawing.Point(0, 128);
            this.WorkerButton.Name = "WorkerButton";
            this.WorkerButton.Size = new System.Drawing.Size(132, 103);
            this.WorkerButton.TabIndex = 1;
            this.WorkerButton.Text = "Worker";
            this.WorkerButton.UseVisualStyleBackColor = true;
            // 
            // ReservButton
            // 
            this.ReservButton.Location = new System.Drawing.Point(0, 260);
            this.ReservButton.Name = "ReservButton";
            this.ReservButton.Size = new System.Drawing.Size(132, 103);
            this.ReservButton.TabIndex = 2;
            this.ReservButton.Text = "Reservation";
            this.ReservButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReservButton);
            this.Controls.Add(this.WorkerButton);
            this.Controls.Add(this.PacientButton);
            this.Name = "Form1";
            this.Text = "main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PacientButton;
        private System.Windows.Forms.Button WorkerButton;
        private System.Windows.Forms.Button ReservButton;
    }
}
