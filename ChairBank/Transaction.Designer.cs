
namespace ChairBank
{
    partial class Transaction
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
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            menu = new Button();
            save = new Button();
            add = new Button();
            update = new Button();
            delete = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(12, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(512, 287);
            panel2.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(199, 183);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(269, 27);
            dateTimePicker2.TabIndex = 14;
            dateTimePicker2.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker2.KeyDown += dateTimePicker2_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 10.8F);
            label5.Location = new Point(16, 80);
            label5.Name = "label5";
            label5.Size = new Size(179, 21);
            label5.TabIndex = 13;
            label5.Text = "Transaction Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.8F);
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 3;
            label1.Text = "Transaction ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.8F);
            label2.Location = new Point(16, 239);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 4;
            label2.Text = "Account ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 236);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(269, 27);
            textBox5.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.8F);
            label3.Location = new Point(16, 132);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 10.8F);
            label4.Location = new Point(16, 183);
            label4.Name = "label4";
            label4.Size = new Size(180, 21);
            label4.TabIndex = 6;
            label4.Text = "Transaction Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 27);
            textBox3.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 68);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(232, 20);
            label6.Name = "label6";
            label6.Size = new Size(233, 35);
            label6.TabIndex = 7;
            label6.Text = "Transactions";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 388);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(688, 184);
            dataGridView1.TabIndex = 9;
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
            panel3.Location = new Point(530, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(157, 287);
            panel3.TabIndex = 10;
            // 
            // menu
            // 
            menu.BackColor = Color.IndianRed;
            menu.BackgroundImageLayout = ImageLayout.Center;
            menu.FlatStyle = FlatStyle.Popup;
            menu.Font = new Font("Stencil", 12F);
            menu.ForeColor = Color.White;
            menu.Location = new Point(29, 236);
            menu.Name = "menu";
            menu.Size = new Size(98, 32);
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
            save.Location = new Point(29, 12);
            save.Name = "save";
            save.Size = new Size(98, 32);
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
            add.Location = new Point(29, 69);
            add.Name = "add";
            add.Size = new Size(98, 32);
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
            update.Location = new Point(29, 126);
            update.Name = "update";
            update.Size = new Size(98, 32);
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
            delete.Location = new Point(29, 183);
            delete.Name = "delete";
            delete.Size = new Size(98, 32);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(699, 584);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel2;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Panel panel1;
        private Label label6;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker2;
        private Panel panel3;
        private Button save;
        private Button add;
        private Button update;
        private Button delete;
        private Button menu;
    }
}