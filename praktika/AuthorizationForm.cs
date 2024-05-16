using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace praktika
{
    public partial class AuthorizationForm : Form
    {
        public readonly SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["praktika.Properties.Settings.DigitalBookConnectionString"].ConnectionString);
        SqlCommand command;
        SqlDataAdapter sqlData;
        DataTable users;
        public AuthorizationForm()
        {
            InitializeComponent();
            sqlData = new SqlDataAdapter();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Упс... Нет подключения... Я так не могу работать =(");
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidation())
                {
                    throw new FormatException("Введите корректные данные!");
                }

                if (!LoginUser(LoginTextBox.Text, PwdTextBox.Text))
                {
                    MessageBox.Show("Неверный логин и/или пароль!");
                    return;
                }

                this.Hide();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool CheckValidation()
        {
            if (LoginTextBox.Text == "" || PwdTextBox.Text == "" || PwdTextBox.Text.Length < 6)
            {
                return false;
            }

            return true;
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm(this);
            Hide();
            DialogResult result = registration.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (LoginUser(registration.login, registration.pwd)){
                    this.Hide();
                }
            }
            else if (result == DialogResult.Cancel)
            {
                registration.Dispose();
                this.Show();
            }
        }



        bool LoginUser(string login, string pwd)
        {
            try
            {
                command = new SqlCommand("SELECT * FROM [newusers] WHERE [login]=@login and [pwd]=@pwd", sqlConnection);
                command.Parameters.AddWithValue("login", login);
                command.Parameters.AddWithValue("pwd", pwd);
                sqlData = new SqlDataAdapter(command);
                users = new DataTable();
                sqlData.Fill(users);

                if (users.Rows.Count != 1)
                {
                    return false;
                }

                MainForm mainForm = new MainForm();
                mainForm.id_user = (int)users.Rows[0]["id"];
                mainForm.UserLogin = (string)users.Rows[0]["login"];
                mainForm.Show();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void LoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PwdTextBox.Focus();
            }
        }

        private void PwdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
