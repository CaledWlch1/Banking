namespace ChairBank
{
    partial class Customer
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
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel3 = new Panel();
            menu = new Button();
            save = new Button();
            add = new Button();
            update = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 102);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(239, 27);
            label6.Name = "label6";
            label6.Size = new Size(223, 47);
            label6.TabIndex = 4;
            label6.Text = "Customer";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox5);
            panel2.Location = new Point(12, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 335);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 10.8F);
            label5.Location = new Point(16, 264);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 13;
            label5.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.8F);
            label1.Location = new Point(16, 62);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 3;
            label1.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.8F);
            label2.Location = new Point(16, 115);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 4;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.8F);
            label3.Location = new Point(16, 167);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 10.8F);
            label4.Location = new Point(16, 218);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(253, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 215);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(253, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(176, 261);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(253, 27);
            textBox5.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(menu);
            panel3.Controls.Add(save);
            panel3.Controls.Add(add);
            panel3.Controls.Add(update);
            panel3.Controls.Add(delete);
            panel3.Location = new Point(479, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 335);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // menu
            // 
            menu.BackColor = Color.IndianRed;
            menu.BackgroundImageLayout = ImageLayout.Center;
            menu.FlatStyle = FlatStyle.Popup;
            menu.Font = new Font("Stencil", 12F);
            menu.ForeColor = Color.White;
            menu.Location = new Point(46, 264);
            menu.Name = "menu";
            menu.Size = new Size(129, 40);
            menu.TabIndex = 7;
            menu.Text = "menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // save
            // 
            save.BackColor = Color.IndianRed;
            save.BackgroundImageLayout = ImageLayout.Center;
            save.FlatStyle = FlatStyle.Popup;
            save.Font = new Font("Stencil", 12F);
            save.ForeColor = Color.White;
            save.Location = new Point(46, 31);
            save.Name = "save";
            save.Size = new Size(129, 40);
            save.TabIndex = 3;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // add
            // 
            add.BackColor = Color.IndianRed;
            add.BackgroundImageLayout = ImageLayout.Center;
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Stencil", 12F);
            add.ForeColor = Color.White;
            add.Location = new Point(46, 87);
            add.Name = "add";
            add.Size = new Size(129, 40);
            add.TabIndex = 4;
            add.Text = "load";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // update
            // 
            update.BackColor = Color.IndianRed;
            update.BackgroundImageLayout = ImageLayout.Center;
            update.FlatStyle = FlatStyle.Popup;
            update.Font = new Font("Stencil", 12F);
            update.ForeColor = Color.White;
            update.Location = new Point(46, 148);
            update.Name = "update";
            update.Size = new Size(129, 40);
            update.TabIndex = 5;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.IndianRed;
            delete.BackgroundImageLayout = ImageLayout.Center;
            delete.FlatStyle = FlatStyle.Popup;
            delete.Font = new Font("Stencil", 12F);
            delete.ForeColor = Color.White;
            delete.Location = new Point(46, 208);
            delete.Name = "delete";
            delete.Size = new Size(129, 40);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 473);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(697, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(721, 635);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button save;
        private Button add;
        private Button update;
        private Button delete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private Button menu;
    }
}