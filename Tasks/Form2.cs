using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Введите имя";
            textBox1.ForeColor = Color.Gray;

            //textBox3.Text = "Введите фамилию";
            //textBox3.ForeColor = Color.Gray;

            textBox4.Text = "Введите логин";
            textBox4.ForeColor = Color.Gray;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите имя";
                textBox1.ForeColor = Color.Gray;
            }

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            //if (textBox3.Text == "Введите фамилию")
            //{
            //    textBox3.Text = "";
            //    textBox3.ForeColor = Color.Black;
            //}
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            //if (textBox3.Text == "")
            //{
            //    textBox3.Text = "Введите фамилию";
            //    textBox3.ForeColor = Color.Gray;
            //}
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Введите логин")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Введите логин";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            //if (textBox3.Text == "Введите фамилию")
            //{
            //    MessageBox.Show("Введите фамилию");
            //    return;
            //}

            if (textBox4.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`) VALUES (@login, @password, @name);", db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox1.Text;
           // command.Parameters.Add("@surename", MySqlDbType.VarChar).Value = textBox3.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не создан");

            db.closeConnection();

        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = textBox4.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот логин уже существует");
                return true;
            }

            else
                return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
