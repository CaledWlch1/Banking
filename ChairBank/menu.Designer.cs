namespace ChairBank
{
    partial class menu
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            customer = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1937, 169);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(272, 44);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(707, 71);
            label1.TabIndex = 3;
            label1.Text = "Chair National Bank";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(customer);
            panel2.Location = new Point(0, 166);
            panel2.Margin = new Padding(5, 4, 5, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(393, 741);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 224, 192);
            button4.Location = new Point(70, 478);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(212, 54);
            button4.TabIndex = 6;
            button4.Text = "EXIT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 224, 192);
            button3.Location = new Point(70, 332);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(212, 54);
            button3.TabIndex = 5;
            button3.Text = "Transaction";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(70, 188);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(212, 54);
            button1.TabIndex = 3;
            button1.Text = "Account";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // customer
            // 
            customer.BackColor = Color.FromArgb(255, 224, 192);
            customer.Location = new Point(70, 46);
            customer.Margin = new Padding(5, 4, 5, 4);
            customer.Name = "customer";
            customer.Size = new Size(212, 54);
            customer.TabIndex = 2;
            customer.Text = "Customer";
            customer.UseVisualStyleBackColor = false;
            customer.Click += customer_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1138, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "menu";
            Text = "menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button customer;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
    }
}