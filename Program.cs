using Microsoft.Data.SqlClient;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TCPServerConsole
{
    class Program
    {
        private static TcpListener listener;
        private static string connectionString = @"Data Source=FINN\SQLEXPRESSS;Initial Catalog=Exercise3;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

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
                    messageBuilder.Append(Encoding.ASCII.GetString(buffer, 0, bytesRead));
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
                        byte[] response = Encoding.ASCII.GetBytes("Invalid command");
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
                response = Encoding.ASCII.GetBytes("Login successful");
            }
            else
            {
                response = Encoding.ASCII.GetBytes("Login failed");
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
                ? Encoding.ASCII.GetBytes("Register successful")
                : Encoding.ASCII.GetBytes("Register failed");

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
                ? Encoding.ASCII.GetBytes("Username existed")
                : Encoding.ASCII.GetBytes("Username does not exist");

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
                ? Encoding.ASCII.GetBytes("Email existed")
                : Encoding.ASCII.GetBytes("Email does not exist");

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
                response = Encoding.ASCII.GetBytes(info);
            }
            else
            {
                response = Encoding.ASCII.GetBytes("User not found");
            }

            await stream.WriteAsync(response, 0, response.Length);
        }
    }
}
