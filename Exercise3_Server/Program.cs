using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServerConsole
{
    class Program
    {
        private static TcpListener listener;
        private static string connectionString = @"Data Source=FINN\SQLEXPRESSS;Initial Catalog=Exercise3;Integrated Security=True";

        static async Task Main(string[] args)
        {
            listener = new TcpListener(IPAddress.Any, 3080);
            listener.Start();
            Console.WriteLine("Server is listening on port 3080");

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();
                HandleClient(client);
            }
        }

        private static async void HandleClient(TcpClient client)
        {
            try
            {
                using NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                StringBuilder messageBuilder = new StringBuilder();
                int bytesRead;

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    messageBuilder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                    string message = messageBuilder.ToString();
                    string[] parts = message.Split('|');

                    if (parts[0] == "LOGIN")
                    {
                        await HandleLogin(parts, stream);
                    }
                    else if (parts[0] == "REGISTER")
                    {
                        await HandleRegister(parts, stream);
                    }
                    else if (parts[0] == "CHECKUSERNAME")
                    {
                        await HandleCheckUsername(parts, stream);
                    }
                    else if (parts[0] == "CHECKEMAIL")
                    {
                        await HandleCheckEmail(parts, stream);
                    }
                    else if (parts[0] == "GETINFO")
                    {
                        await HandleGetInfo(parts, stream);
                    }
                    else
                    {
                        byte[] response = Encoding.UTF8.GetBytes("Invalid command");
                        await stream.WriteAsync(response, 0, response.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                client.Close();
                Console.WriteLine("Connection closed.");
            }
        }

        private static async Task HandleLogin(string[] parts, NetworkStream stream)
        {
            using SqlConnection connection = new(connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new("SELECT * FROM Users WHERE Username = @Username AND HashedPass = @Password", connection);
            command.Parameters.AddWithValue("@Username", parts[1]);
            command.Parameters.AddWithValue("@Password", parts[2]);

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            byte[] response;
            if (reader.HasRows)
            {
                response = Encoding.UTF8.GetBytes("Login successful");
            }
            else
            {
                response = Encoding.UTF8.GetBytes("Login failed");
            }

            await stream.WriteAsync(response, 0, response.Length);
        }

        private static async Task HandleRegister(string[] parts, NetworkStream stream)
        {
            using SqlConnection connection = new(connectionString);
            await connection.OpenAsync();
            string userId = Guid.NewGuid().ToString();

            using SqlCommand command = new("INSERT INTO Users (UserID, Fullname, Username, Email, Birthday, HashedPass) VALUES (@UserID, @Fullname, @Username, @Email, @Birthday, @HashedPass)", connection);
            command.Parameters.AddWithValue("@UserID", userId);
            command.Parameters.AddWithValue("@Fullname", parts[1]);
            command.Parameters.AddWithValue("@Username", parts[2]);
            command.Parameters.AddWithValue("@Email", parts[3]);
            command.Parameters.AddWithValue("@Birthday", parts[4]);
            command.Parameters.AddWithValue("@HashedPass", parts[5]);

            int rowsAffected = await command.ExecuteNonQueryAsync();
            byte[] response = rowsAffected > 0
                ? Encoding.UTF8.GetBytes("Register successful")
                : Encoding.UTF8.GetBytes("Register failed");

            await stream.WriteAsync(response, 0, response.Length);
        }

        private static async Task HandleCheckUsername(string[] parts, NetworkStream stream)
        {
            using SqlConnection connection = new(connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new("SELECT * FROM Users WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", parts[1]);

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            byte[] response = reader.HasRows
                ? Encoding.UTF8.GetBytes("Username existed")
                : Encoding.UTF8.GetBytes("Username does not exist");

            await stream.WriteAsync(response, 0, response.Length);
        }

        private static async Task HandleCheckEmail(string[] parts, NetworkStream stream)
        {
            using SqlConnection connection = new(connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new("SELECT * FROM Users WHERE Email = @Email", connection);
            command.Parameters.AddWithValue("@Email", parts[1]);

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            byte[] response = reader.HasRows
                ? Encoding.UTF8.GetBytes("Email existed")
                : Encoding.UTF8.GetBytes("Email does not exist");

            await stream.WriteAsync(response, 0, response.Length);
        }

        private static async Task HandleGetInfo(string[] parts, NetworkStream stream)
        {
            using SqlConnection connection = new(connectionString);
            await connection.OpenAsync();
            using SqlCommand command = new("SELECT Fullname, Username, Email, Birthday FROM Users WHERE Username = @Username", connection);
            command.Parameters.AddWithValue("@Username", parts[1]);

            using SqlDataReader reader = await command.ExecuteReaderAsync();
            byte[] response;
            if (reader.Read())
            {
                string info = $"{reader["Fullname"]}|{reader["Username"]}|{reader["Email"]}|{reader["Birthday"]}";
                response = Encoding.UTF8.GetBytes(info);
            }
            else
            {
                response = Encoding.UTF8.GetBytes("User not found");
            }

            await stream.WriteAsync(response, 0, response.Length);
        }
    }
}
