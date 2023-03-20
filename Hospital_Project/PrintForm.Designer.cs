namespace Hospital_Project
{
    partial class PrintForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrintPacBtn = new System.Windows.Forms.Button();
            this.PrintWorBtn = new System.Windows.Forms.Button();
            this.PrintDocBtn = new System.Windows.Forms.Button();
            this.PrintParBtn = new System.Windows.Forms.Button();
            this.PrintPosBtn = new System.Windows.Forms.Button();
            this.PrintResBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrintResBtn);
            this.panel1.Controls.Add(this.PrintPosBtn);
            this.panel1.Controls.Add(this.PrintParBtn);
            this.panel1.Controls.Add(this.PrintDocBtn);
            this.panel1.Controls.Add(this.PrintWorBtn);
            this.panel1.Controls.Add(this.PrintPacBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 324);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // PrintPacBtn
            // 
            this.PrintPacBtn.Location = new System.Drawing.Point(12, 12);
            this.PrintPacBtn.Name = "PrintPacBtn";
            this.PrintPacBtn.Size = new System.Drawing.Size(77, 42);
            this.PrintPacBtn.TabIndex = 1;
            this.PrintPacBtn.Text = "Pacients";
            this.PrintPacBtn.UseVisualStyleBackColor = true;
            this.PrintPacBtn.Click += new System.EventHandler(this.PrintPacBtn_Click);
            // 
            // PrintWorBtn
            // 
            this.PrintWorBtn.Location = new System.Drawing.Point(107, 12);
            this.PrintWorBtn.Name = "PrintWorBtn";
            this.PrintWorBtn.Size = new System.Drawing.Size(77, 42);
            this.PrintWorBtn.TabIndex = 2;
            this.PrintWorBtn.Text = "Workers";
            this.PrintWorBtn.UseVisualStyleBackColor = true;
            // 
            // PrintDocBtn
            // 
            this.PrintDocBtn.Location = new System.Drawing.Point(206, 12);
            this.PrintDocBtn.Name = "PrintDocBtn";
            this.PrintDocBtn.Size = new System.Drawing.Size(77, 42);
            this.PrintDocBtn.TabIndex = 3;
            this.PrintDocBtn.Text = "Doctors";
            this.PrintDocBtn.UseVisualStyleBackColor = true;
            // 
            // PrintParBtn
            // 
            this.PrintParBtn.Location = new System.Drawing.Point(12, 87);
            this.PrintParBtn.Name = "PrintParBtn";
            this.PrintParBtn.Size = new System.Drawing.Size(77, 42);
            this.PrintParBtn.TabIndex = 4;
            this.PrintParBtn.Text = "Parents";
            this.PrintParBtn.UseVisualStyleBackColor = true;
            // 
            // PrintPosBtn
            // 
            this.PrintPosBtn.Location = new System.Drawing.Point(107, 87);
            this.PrintPosBtn.Name = "PrintPosBtn";
            this.PrintPosBtn.Size = new System.Drawing.Size(77, 42);
            this.PrintPosBtn.TabIndex = 5;
            this.PrintPosBtn.Text = "Positions";
            this.PrintPosBtn.UseVisualStyleBackColor = true;
            // 
            // PrintResBtn
            // 
            this.PrintResBtn.Location = new System.Drawing.Point(206, 87);
            this.PrintResBtn.Name = "PrintResBtn";
            this.PrintResBtn.Size = new System.Drawing.Size(77, 42);
            this.PrintResBtn.TabIndex = 6;
            this.PrintResBtn.Text = "Reservations";
            this.PrintResBtn.UseVisualStyleBackColor = true;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(340, 324);
            this.Controls.Add(this.panel1);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrintResBtn;
        private System.Windows.Forms.Button PrintPosBtn;
        private System.Windows.Forms.Button PrintParBtn;
        private System.Windows.Forms.Button PrintDocBtn;
        private System.Windows.Forms.Button PrintWorBtn;
        private System.Windows.Forms.Button PrintPacBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}