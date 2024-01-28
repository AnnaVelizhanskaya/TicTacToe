using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursaaaaash
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void button_log_in_Click(object sender, EventArgs e)
        {

            string login = textBox_login.Text.Trim();
            string password = textBox_password.Text.Trim();

            // Создание подключения
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NDUSLI0\SQLEXPRESS;Initial Catalog=tictactoe;Integrated Security=True"))
            {
                // Открытие подключения
                con.Open();

                // Создание команды SQL для выборки пользователя с указанным логином и паролем
                using (SqlCommand command = new SqlCommand("select count(*) from [dbo].[reg] where lower(login) = lower(@Login) and pass = @Pass COLLATE SQL_Latin1_General_CP1_CS_AS", con))
                {
                    command.Parameters.Add("@Login", SqlDbType.VarChar).Value = login;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;

                    int userCount = (int)command.ExecuteScalar(); // Получаем количество записей, соответствующих указанному логину и паролю

                    if (userCount > 0) // Если найдено совпадение
                    {
                        // Дать доступ к форме tictactoe
                        Form frm = new TicTacToe();
                        frm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // Вывести сообщение о неверном логине или пароле
                        MessageBox.Show("Неверный логин или пароль", "Ошибка");
                    }
                }
            }

        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        public void button_registration_Click(object sender, EventArgs e)
        {
            Registration frm_sign = new Registration();
            frm_sign.Show();
            this.Hide();
        }

    }
}