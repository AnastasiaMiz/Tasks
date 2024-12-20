using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Tasks
{
    public partial class Form4 : Form
    {
        private DB db = new DB();
        private MySqlDataAdapter adapter;
        private DataTable table;

        public Form4()
        {
            InitializeComponent();
            db.openConnection();
            adapter = new MySqlDataAdapter("SELECT * FROM `tasks`", db.GetConnection());
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            int id;

            // Проверка на корректность ввода
            if (int.TryParse(textBox7.Text, out id))
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("DELETE FROM `tasks` WHERE `id` = @id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                // Обновляем данные в DataGridView
                table.Clear();
                adapter.Fill(table);
            }
            else
            {
                MessageBox.Show("Введите корректный ID для удаления.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value1 = textBox1.Text;
            string value2 = textBox3.Text;

            using (var connection = db.GetConnection())
            {
                

                // Устанавливаем значение текущей даты и времени
                MySqlCommand command = new MySqlCommand("INSERT INTO `tasks` (`project_name`, `task_description`, `creation_date`) VALUES (@val1, @val2, NOW())", connection);
                command.Parameters.AddWithValue("@val1", value1);
                command.Parameters.AddWithValue("@val2", value2);

                command.ExecuteNonQuery();
            }

           
        // Обновляем данные в DataGridView
        table.Clear();
            adapter.Fill(table);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Получаем данные из TextBox
            string value1 = textBox2.Text;
            int id;

            // Проверка на корректность ввода
            if (int.TryParse(textBox7.Text, out id))
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();

                    // Обновляем запись в базе данных
                    MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `project_name` = @val1 WHERE `id` = @id", connection);
                    command.Parameters.AddWithValue("@val1", value1);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                // Обновляем данные в DataGridView
                table.Clear();
                adapter.Fill(table);
            }
            else
            {
                MessageBox.Show("Введите корректный ID для обновления.");
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрываем соединение с базой данных при закрытии формы
            db.closeConnection();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}

