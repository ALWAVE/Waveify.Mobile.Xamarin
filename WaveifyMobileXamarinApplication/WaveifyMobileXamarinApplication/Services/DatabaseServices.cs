using System;
using System.Threading.Tasks;
using Npgsql;

namespace WaveifyMobileXamarinApplication.Services
{
    public class DatabaseServices
    {

        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=558899ASE2005;Database=mytestdb;Pooling=true;";

        public void ConnectToDatabase()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Подключение успешно установлено!");

                    // Выполнение SQL-запроса
                    using (var command = new NpgsqlCommand("SELECT * FROM Users", connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0)); // Пример чтения данных
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка подключения: {ex.Message}");
                }
            }

        }
        public async Task<bool> ValidateUser(string email, string password)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // SQL-запрос для проверки пользователя
                var sql = "SELECT COUNT(*) FROM \"Users\" WHERE \"Email\" = @Email AND \"PasswordHash\" = @PasswordHash"; // Используем правильные имена полей
                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("Email", email);
                    command.Parameters.AddWithValue("PasswordHash", password); // Убедитесь, что вы используете правильный способ проверки пароля

                    var result = await command.ExecuteScalarAsync();
                    return Convert.ToInt32(result) > 0;
                }
            }

        }
    }
}

