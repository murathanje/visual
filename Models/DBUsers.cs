using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class DBUsers
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "Server=127.0.0.1;Database=qfit;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(sql);

            try
            {
                connection.Open();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata:" + ex);
            }
            return connection;
        }

        public static void AddUser(Users std)
        {
            string sql = "INSERT INTO users (first_name, last_name, email, age, height, weight, phone, started_at, ended_at) VALUES (@FirstName, @LastName, @Email, @Age, @Height, @Weight, @Phone, @StartedAt, @EndedAt)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = std.FirstName;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = std.LastName;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@Age", MySqlDbType.Int32).Value = std.Age; // Age is an integer
            cmd.Parameters.Add("@Height", MySqlDbType.Int32).Value = std.Height; // Height is an integer
            cmd.Parameters.Add("@Weight", MySqlDbType.Int32).Value = std.Weight; // Weight is an integer
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = std.Phone;
            cmd.Parameters.Add("@StartedAt", MySqlDbType.Timestamp).Value = std.StartedAt; // StartedAt is a timestamp
            cmd.Parameters.Add("@EndedAt", MySqlDbType.Timestamp).Value = std.EndedAt; // EndedAt is a timestamp

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oldu");
            }
            catch(Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }

        public static void UpdateUser(Users std, string id)
        {
            string sql = "UPDATE Users SET first_name = @FirstName, last_name = @LastName, email = @Email, age = @Age, height = @Height, weight = @Weight, phone = @Phone, started_at = @StartedAt, ended_at = @EndedAt WHERE id = @Id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = std.FirstName;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = std.LastName;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = std.Email;
            cmd.Parameters.Add("@Age", MySqlDbType.Int32).Value = std.Age; // Age is an integer
            cmd.Parameters.Add("@Height", MySqlDbType.Int32).Value = std.Height; // Height is an integer
            cmd.Parameters.Add("@Weight", MySqlDbType.Int32).Value = std.Weight; // Weight is an integer
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = std.Phone;
            cmd.Parameters.Add("@StartedAt", MySqlDbType.Timestamp).Value = std.StartedAt; // StartedAt is a timestamp
            cmd.Parameters.Add("@EndedAt", MySqlDbType.Timestamp).Value = std.EndedAt; // EndedAt is a timestamp

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Oldu");
            }
            catch
            {
                MessageBox.Show("Olmadı");
            }
            connection.Close();
        }

        public static void DeleteUser(string id)
        {
            string sql = "DELETE FROM Users WHERE id = @Id";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silindi");
            }
            catch
            {
                MessageBox.Show("Silinemedi");
            }
            connection.Close();
        }

    }
}
