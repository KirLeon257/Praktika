using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Note;

namespace praktika
{

    public enum EditFormMode
    {
        Create = 1,
        Edit = 2
    }


    public partial class RegistrationForm : Form
    {
        SqlConnection sqlConnection;
        SqlCommand command;
        AuthorizationForm authorization;
        public string login;
        public string pwd;
        public RegistrationForm(AuthorizationForm authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
            sqlConnection = authorization.sqlConnection;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoginTextBox.Text = authorization.LoginTextBox.Text != "" ? authorization.LoginTextBox.Text : "";
            PwdTextBox.Text = authorization.PwdTextBox.Text != "" ? authorization.PwdTextBox.Text : "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValidation())
                {
                    throw new FormatException("Введите корректные данные!");
                }
                if (RegistrationeUser())
                {
                    this.Hide();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool RegistrationeUser()
        {
            try
            {
                command = new SqlCommand("INSERT INTO [newusers]([login],[pwd]) VALUES (@login,@pwd)", sqlConnection);
                command.Parameters.AddWithValue("login", LoginTextBox.Text);
                command.Parameters.AddWithValue("pwd", PwdTextBox.Text);
                if (command.ExecuteNonQuery() == 1)
                {
                    login = LoginTextBox.Text;
                    pwd = PwdTextBox.Text;
                    return true;
                }

                return false;
            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == -2146232060)
                {
                    MessageBox.Show("Такой пользоваель уже существует! Используйте другой логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        bool CheckValidation()
        {
            if (LoginTextBox.Text == "" || PwdTextBox.Text == "" || PwdTextBox.Text.Length < 6)
            {
                return false;
            }

            return true;
        }
    }
}
