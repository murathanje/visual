using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class DBLogs
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "Server=127.0.0.1;Database=qfit;Uid=root;Pwd=;";
            MySqlConnection connection = new MySqlConnection(sql);

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex);
            }
            return connection;
        }

        public static void AddLog(Logs log)
        {
            string sql = "INSERT INTO logs (entered_at, exited_at, user_id) VALUES (@Enter, @Exit, @UserId)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Enter", MySqlDbType.DateTime).Value = log.Enter;
            cmd.Parameters.Add("@Exit", MySqlDbType.DateTime).Value = log.Exit;
            cmd.Parameters.Add("@UserId", MySqlDbType.Int32).Value = log.UserId;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ekleme başarılı");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }

    }
}
