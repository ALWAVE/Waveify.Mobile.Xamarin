using System;
using System.Threading.Tasks;
using Npgsql;

namespace WaveifyMobileXamarinApplication.Services
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Добавьте другие поля, если необходимо
    }
    public class DatabaseServices
    {
        //private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=558899ASE2005;Database=mytestdb;Pooling=true;";
        private string connectionString = "Host=10.0.2.2;Port=5432;Username=postgres;Password=558899ASE2005;Database=mytestdb;Pooling=true;";

        public async Task<bool> ValidateUser(string email, string password)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Используем параметризованный запрос для избежания SQL-инъекций
                using (var command = new NpgsqlCommand("SELECT COUNT(*) FROM \"Users\" WHERE \"UserName\" = @email AND \"PasswordHash\" = @password", connection))

                {
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("password", password); // Убедитесь, что пароли хранятся в безопасном виде

                    var result = (long)await command.ExecuteScalarAsync();
                    return result > 0; // Если найден хотя бы один пользователь, возвращаем true
                }
            }
        }


        public async Task<bool> TestConnection()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    return true; // Подключение успешно
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine($"Ошибка подключения: {ex.Message}"); // Выводим сообщение об ошибке
                    return false; // Ошибка подключения
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Общая ошибка: {ex.Message}"); // Общая ошибка
                    return false;
                }
            }
        }

    }
}
