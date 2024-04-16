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
        SqlConnection sqlConnection;
        SqlCommand command;
        SqlDataAdapter sqlData;
        DataTable users;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["praktika.Properties.Settings.DigitalBookConnectionString"].ConnectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString());
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

                if (!LoginUser())
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox2.Text.Length < 8)
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox2.Text.Length < 8)
            {
                return;
            }

            //RegistrationeUser();
        }

        void RegistrationeUser()
        {
            try
            {
                command = new SqlCommand("");
            }
            catch (Exception)
            {

                throw;
            }
        }

        bool LoginUser()
        {
            try
            {
                command = new SqlCommand("SELECT [id] FROM [users] WHERE [login]=@login and [pwd]=@pwd", sqlConnection);
                command.Parameters.AddWithValue("login", textBox1.Text);
                command.Parameters.AddWithValue("pwd", textBox2.Text);
                sqlData = new SqlDataAdapter(command);
                users = new DataTable();
                sqlData.Fill(users);

                if (users.Rows.Count != 1)
                {
                    return false;
                }

                MainForm mainForm = new MainForm();
                mainForm.id_user = (int)users.Rows[0]["id"];
                mainForm.Show();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
