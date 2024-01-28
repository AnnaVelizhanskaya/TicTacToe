using NUnit.Framework;
using System;
using NUnit.Framework;
using Moq;
using System.Data;
using System.Data.SqlClient;
using kursaaaaash;
using System.Windows.Forms;

namespace RegistrationTest
{
    namespace AuthorizationTests
    {
        [TestFixture]
        public class AuthorizationTests
        {
            private const string connectionString = "Data Source=DESKTOP-NDUSLI0\\SQLEXPRESS;Initial Catalog=tictactoe;Integrated Security=True";

            [Test]
            public void test1()
            {
                string login = "admin";
                string password = "admin";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM [dbo].[reg] WHERE login = '{login}' AND pass = '{password}'", connection);
                    int count = (int)command.ExecuteScalar();
                    Assert.AreEqual(0, count);
                }
            }

            [Test]
            public void test2()
            {
                string Login = "468";
                string Pass = "468";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO [dbo].[reg] (login, pass) VALUES (@Login, @Pass)", connection);
                    command.Parameters.AddWithValue("@Login", Login);
                    command.Parameters.AddWithValue("@Pass", Pass);

                    int count = command.ExecuteNonQuery();
                    Assert.AreEqual(1, count);
                }
            }

            [Test]
            public void test3()
            {
                // Arrange
                var form = new TicTacToe();
                var button = new Button();

                // Act
                form.Button11_Click(button, EventArgs.Empty);

                // Assert
                Assert.That(Application.MessageLoop, Is.False);
            }
        }
    }
}