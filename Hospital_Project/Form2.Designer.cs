namespace Hospital_Project
{
    partial class Form2
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
            this.ReservButton = new System.Windows.Forms.Button();
            this.WorkerButton = new System.Windows.Forms.Button();
            this.PacientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReservButton
            // 
            this.ReservButton.Location = new System.Drawing.Point(-1, 260);
            this.ReservButton.Name = "ReservButton";
            this.ReservButton.Size = new System.Drawing.Size(132, 103);
            this.ReservButton.TabIndex = 5;
            this.ReservButton.Text = "Reservation";
            this.ReservButton.UseVisualStyleBackColor = true;
            // 
            // WorkerButton
            // 
            this.WorkerButton.Location = new System.Drawing.Point(-1, 128);
            this.WorkerButton.Name = "WorkerButton";
            this.WorkerButton.Size = new System.Drawing.Size(132, 103);
            this.WorkerButton.TabIndex = 4;
            this.WorkerButton.Text = "Worker";
            this.WorkerButton.UseVisualStyleBackColor = true;
            // 
            // PacientButton
            // 
            this.PacientButton.Location = new System.Drawing.Point(-1, 0);
            this.PacientButton.Name = "PacientButton";
            this.PacientButton.Size = new System.Drawing.Size(132, 103);
            this.PacientButton.TabIndex = 3;
            this.PacientButton.Text = "Pacient";
            this.PacientButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReservButton);
            this.Controls.Add(this.WorkerButton);
            this.Controls.Add(this.PacientButton);
            this.Name = "Form2";
            this.Text = "Pacient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReservButton;
        private System.Windows.Forms.Button WorkerButton;
        private System.Windows.Forms.Button PacientButton;
    }
}