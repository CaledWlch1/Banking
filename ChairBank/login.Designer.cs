
namespace ChairBank
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            login_button = new Button();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 125);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 37);
            label3.Name = "label3";
            label3.Size = new Size(134, 47);
            label3.TabIndex = 11;
            label3.Text = "Login";
            // 
            // login_button
            // 
            login_button.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button.Location = new Point(158, 355);
            login_button.Name = "login_button";
            login_button.Size = new Size(136, 51);
            login_button.TabIndex = 6;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(54, 190);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(361, 27);
            txtusername.TabIndex = 7;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(54, 282);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(361, 27);
            txtpassword.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F);
            label1.Location = new Point(181, 151);
            label1.Name = "label1";
            label1.Size = new Size(114, 24);
            label1.TabIndex = 9;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F);
            label2.Location = new Point(181, 255);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 10;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(465, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(login_button);
            Controls.Add(panel1);
            Name = "login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Button login_button;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
