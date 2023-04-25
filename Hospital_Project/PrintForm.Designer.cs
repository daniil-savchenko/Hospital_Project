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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PrintPacBtn = new System.Windows.Forms.Button();
            this.PrintWorBtn = new System.Windows.Forms.Button();
            this.PrintDocBtn = new System.Windows.Forms.Button();
            this.PrintParBtn = new System.Windows.Forms.Button();
            this.PrintPosBtn = new System.Windows.Forms.Button();
            this.PrintResBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 135);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(352, 123);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // PrintPacBtn
            // 
            this.PrintPacBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintPacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPacBtn.Location = new System.Drawing.Point(30, 12);
            this.PrintPacBtn.Name = "PrintPacBtn";
            this.PrintPacBtn.Size = new System.Drawing.Size(91, 42);
            this.PrintPacBtn.TabIndex = 1;
            this.PrintPacBtn.Text = "Pacients";
            this.PrintPacBtn.UseVisualStyleBackColor = false;
            this.PrintPacBtn.Click += new System.EventHandler(this.PrintPacBtn_Click);
            // 
            // PrintWorBtn
            // 
            this.PrintWorBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintWorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintWorBtn.Location = new System.Drawing.Point(137, 12);
            this.PrintWorBtn.Name = "PrintWorBtn";
            this.PrintWorBtn.Size = new System.Drawing.Size(91, 42);
            this.PrintWorBtn.TabIndex = 2;
            this.PrintWorBtn.Text = "Workers";
            this.PrintWorBtn.UseVisualStyleBackColor = false;
            this.PrintWorBtn.Click += new System.EventHandler(this.PrintWorBtn_Click);
            // 
            // PrintDocBtn
            // 
            this.PrintDocBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintDocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintDocBtn.Location = new System.Drawing.Point(249, 12);
            this.PrintDocBtn.Name = "PrintDocBtn";
            this.PrintDocBtn.Size = new System.Drawing.Size(91, 42);
            this.PrintDocBtn.TabIndex = 3;
            this.PrintDocBtn.Text = "Doctors";
            this.PrintDocBtn.UseVisualStyleBackColor = false;
            this.PrintDocBtn.Click += new System.EventHandler(this.PrintDocBtn_Click);
            // 
            // PrintParBtn
            // 
            this.PrintParBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintParBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintParBtn.Location = new System.Drawing.Point(30, 87);
            this.PrintParBtn.Name = "PrintParBtn";
            this.PrintParBtn.Size = new System.Drawing.Size(91, 42);
            this.PrintParBtn.TabIndex = 4;
            this.PrintParBtn.Text = "Parents";
            this.PrintParBtn.UseVisualStyleBackColor = false;
            this.PrintParBtn.Click += new System.EventHandler(this.PrintParBtn_Click);
            // 
            // PrintPosBtn
            // 
            this.PrintPosBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintPosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintPosBtn.Location = new System.Drawing.Point(137, 87);
            this.PrintPosBtn.Name = "PrintPosBtn";
            this.PrintPosBtn.Size = new System.Drawing.Size(91, 42);
            this.PrintPosBtn.TabIndex = 5;
            this.PrintPosBtn.Text = "Positions";
            this.PrintPosBtn.UseVisualStyleBackColor = false;
            this.PrintPosBtn.Click += new System.EventHandler(this.PrintPosBtn_Click);
            // 
            // PrintResBtn
            // 
            this.PrintResBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrintResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintResBtn.Location = new System.Drawing.Point(249, 87);
            this.PrintResBtn.Name = "PrintResBtn";
            this.PrintResBtn.Size = new System.Drawing.Size(91, 42);
            this.PrintResBtn.TabIndex = 6;
            this.PrintResBtn.Text = "Reservations";
            this.PrintResBtn.UseVisualStyleBackColor = false;
            this.PrintResBtn.Click += new System.EventHandler(this.PrintResBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(101, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PrintResBtn);
            this.panel1.Controls.Add(this.PrintPosBtn);
            this.panel1.Controls.Add(this.PrintParBtn);
            this.panel1.Controls.Add(this.PrintDocBtn);
            this.panel1.Controls.Add(this.PrintWorBtn);
            this.panel1.Controls.Add(this.PrintPacBtn);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 324);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(389, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 324);
            this.panel2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 324);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 324);
            this.Controls.Add(this.panel1);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button PrintPacBtn;
        private System.Windows.Forms.Button PrintWorBtn;
        private System.Windows.Forms.Button PrintDocBtn;
        private System.Windows.Forms.Button PrintParBtn;
        private System.Windows.Forms.Button PrintPosBtn;
        private System.Windows.Forms.Button PrintResBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}