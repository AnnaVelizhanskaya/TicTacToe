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

namespace kursaaaaash
{
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void button_to_registrat_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-NDUSLI0\SQLEXPRESS;Initial Catalog=tictactoe;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the login already exists in the database
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [dbo].[reg] WHERE login = @Login", con);
                checkCommand.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBox1.Text;

                int existingUserCount = (int)checkCommand.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("Этот пользователь уже существует.", "Ошибка");
                }
                else
                {
                    // Insert the new login and password into the database
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO [dbo].[reg] (login, pass) VALUES (@Login, @Pass)", con);
                    insertCommand.Parameters.Add("@Login", SqlDbType.VarChar).Value = textBox1.Text;
                    insertCommand.Parameters.Add("@Pass", SqlDbType.VarChar).Value = textBox2.Text;
                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Аккаунт успешно зарегистрирован!", "Успешно");
                    Form frm = new Authorization();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
            }
        }
    }
}