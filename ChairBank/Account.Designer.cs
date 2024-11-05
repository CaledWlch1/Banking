
namespace ChairBank
{
    partial class Account
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            search_box = new TextBox();
            search = new Button();
            panel3 = new Panel();
            menu = new Button();
            save = new Button();
            add = new Button();
            update = new Button();
            delete = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 440);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 129);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 65);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(347, 18);
            label6.Name = "label6";
            label6.Size = new Size(147, 35);
            label6.TabIndex = 7;
            label6.Text = "Account";
            label6.Click += label6_Click;
            // 
            // search_box
            // 
            search_box.Location = new Point(12, 71);
            search_box.Name = "search_box";
            search_box.Size = new Size(724, 27);
            search_box.TabIndex = 3;
            search_box.TextChanged += search_box_TextChanged;
            // 
            // search
            // 
            search.Location = new Point(742, 71);
            search.Name = "search";
            search.Size = new Size(130, 29);
            search.TabIndex = 4;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
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
            panel3.Location = new Point(656, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 328);
            panel3.TabIndex = 6;
            // 
            // menu
            // 
            menu.BackColor = Color.IndianRed;
            menu.BackgroundImageLayout = ImageLayout.Center;
            menu.FlatStyle = FlatStyle.Popup;
            menu.Font = new Font("Stencil", 12F);
            menu.ForeColor = Color.White;
            menu.Location = new Point(46, 233);
            menu.Name = "menu";
            menu.Size = new Size(139, 51);
            menu.TabIndex = 7;
            menu.Text = "Menu";
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
            save.Location = new Point(46, 25);
            save.Name = "save";
            save.Size = new Size(139, 46);
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
            add.Location = new Point(46, 77);
            add.Name = "add";
            add.Size = new Size(139, 46);
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
            update.Location = new Point(46, 129);
            update.Name = "update";
            update.Size = new Size(139, 46);
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
            delete.Location = new Point(46, 181);
            delete.Name = "delete";
            delete.Size = new Size(139, 46);
            delete.TabIndex = 6;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox5);
            panel2.Location = new Point(12, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(638, 328);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(199, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(399, 27);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(302, 13);
            label7.Name = "label7";
            label7.Size = new Size(55, 24);
            label7.TabIndex = 8;
            label7.Text = "Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 10.8F);
            label5.Location = new Point(16, 115);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 13;
            label5.Text = "Account Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.8F);
            label1.Location = new Point(16, 62);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 3;
            label1.Text = "Account ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 10.8F);
            label2.Location = new Point(16, 274);
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
            label3.Size = new Size(88, 21);
            label3.TabIndex = 5;
            label3.Text = "Balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 10.8F);
            label4.Location = new Point(16, 218);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 6;
            label4.Text = "Date Opened";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 268);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(399, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(884, 581);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(search);
            Controls.Add(search_box);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Account";
            Text = "Account";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox search_box;
        private Button search;
        private Panel panel3;
        private Button save;
        private Button add;
        private Button update;
        private Button delete;
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
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Button menu;
    }
}