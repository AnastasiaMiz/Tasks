namespace Tasks
{
    partial class Form4
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
            label10 = new Label();
            label9 = new Label();
            button8 = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            label8 = new Label();
            button7 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            task_id = new DataGridViewTextBoxColumn();
            project_name = new DataGridViewTextBoxColumn();
            task_description = new DataGridViewTextBoxColumn();
            task_priority = new DataGridViewTextBoxColumn();
            creation_date = new DataGridViewTextBoxColumn();
            assignee_id = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Teal;
            label10.Font = new Font("Sitka Subheading", 31.8F, FontStyle.Bold);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(74, 462);
            label10.TabIndex = 28;
            label10.Text = "З\r\nА\r\nД\r\nА\r\nЧ\r\nИ\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label9.Location = new Point(884, 429);
            label9.Name = "label9";
            label9.Size = new Size(210, 20);
            label9.TabIndex = 27;
            label9.Text = "Для удаления введите его ID ";
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Location = new Point(1224, 420);
            button8.Name = "button8";
            button8.Size = new Size(74, 29);
            button8.TabIndex = 26;
            button8.Text = "Назад";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.Location = new Point(1299, -1);
            label3.Name = "label3";
            label3.Size = new Size(22, 22);
            label3.TabIndex = 25;
            label3.Text = "Х";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(1092, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(206, 241);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Редактирование";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(8, 56);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(173, 27);
            textBox7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 33);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 12;
            label8.Text = "Введите id";
            // 
            // button7
            // 
            button7.BackColor = Color.WhiteSmoke;
            button7.Location = new Point(8, 203);
            button7.Name = "button7";
            button7.Size = new Size(173, 29);
            button7.TabIndex = 4;
            button7.Text = "Отмена";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.WhiteSmoke;
            button6.Location = new Point(8, 168);
            button6.Name = "button6";
            button6.Size = new Size(173, 29);
            button6.TabIndex = 3;
            button6.Text = "Редактировать";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 100);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите текст";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 27);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 89);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 4;
            label4.Text = "Введите текст задачи";
            // 
            // button5
            // 
            button5.BackColor = Color.WhiteSmoke;
            button5.Location = new Point(6, 192);
            button5.Name = "button5";
            button5.Size = new Size(173, 29);
            button5.TabIndex = 3;
            button5.Text = "Отмена";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.WhiteSmoke;
            button4.Location = new Point(6, 157);
            button4.Name = "button4";
            button4.Size = new Size(173, 29);
            button4.TabIndex = 2;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите название ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(884, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 241);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(168, 197, 195);
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button3.Location = new Point(884, 386);
            button3.Name = "button3";
            button3.Size = new Size(179, 33);
            button3.TabIndex = 22;
            button3.Text = "Удалить задачу";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(168, 197, 195);
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button2.Location = new Point(1092, 11);
            button2.Name = "button2";
            button2.Size = new Size(179, 30);
            button2.TabIndex = 21;
            button2.Text = "Изменить задачу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(168, 197, 195);
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button1.Location = new Point(884, 11);
            button1.Name = "button1";
            button1.Size = new Size(179, 30);
            button1.TabIndex = 20;
            button1.Text = "Добавить задачу";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { task_id, project_name, task_description, task_priority, creation_date, assignee_id, status });
            dataGridView1.Location = new Point(96, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 430);
            dataGridView1.TabIndex = 19;
            // 
            // task_id
            // 
            task_id.DataPropertyName = "task_id";
            task_id.HeaderText = "task_id";
            task_id.MinimumWidth = 6;
            task_id.Name = "task_id";
            task_id.ReadOnly = true;
            task_id.Width = 125;
            // 
            // project_name
            // 
            project_name.DataPropertyName = "project_name";
            project_name.HeaderText = "project_name";
            project_name.MinimumWidth = 6;
            project_name.Name = "project_name";
            project_name.ReadOnly = true;
            project_name.Width = 125;
            // 
            // task_description
            // 
            task_description.DataPropertyName = "task_description";
            task_description.HeaderText = "task_description";
            task_description.MinimumWidth = 6;
            task_description.Name = "task_description";
            task_description.ReadOnly = true;
            task_description.Width = 125;
            // 
            // task_priority
            // 
            task_priority.HeaderText = "task_priority";
            task_priority.MinimumWidth = 6;
            task_priority.Name = "task_priority";
            task_priority.ReadOnly = true;
            task_priority.Visible = false;
            task_priority.Width = 125;
            // 
            // creation_date
            // 
            creation_date.HeaderText = "creation_date";
            creation_date.MinimumWidth = 6;
            creation_date.Name = "creation_date";
            creation_date.ReadOnly = true;
            creation_date.Visible = false;
            creation_date.Width = 125;
            // 
            // assignee_id
            // 
            assignee_id.HeaderText = "assignee_id";
            assignee_id.MinimumWidth = 6;
            assignee_id.Name = "assignee_id";
            assignee_id.ReadOnly = true;
            assignee_id.Visible = false;
            assignee_id.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Visible = false;
            status.Width = 125;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 461);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button8);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Задачи";
            Load += Form4_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label9;
        private Button button8;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox textBox7;
        private Label label8;
        private Button button7;
        private Button button6;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private Button button5;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn task_id;
        private DataGridViewTextBoxColumn project_name;
        private DataGridViewTextBoxColumn task_description;
        private DataGridViewTextBoxColumn task_priority;
        private DataGridViewTextBoxColumn creation_date;
        private DataGridViewTextBoxColumn assignee_id;
        private DataGridViewTextBoxColumn status;
    }
}