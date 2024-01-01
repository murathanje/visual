using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    internal class DBExercise
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

        // AddExercise Metodu
        public static void AddExercise(Exercises exercise)
        {
            string sql = "INSERT INTO exercises (title, set_times, rep_times, day, work_desc, workout_place, user_id) VALUES (@Title, @SetTimes, @RepTimes, @Day, @WorkDesc, @WorkoutPlace, @UserId)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Title", exercise.Title);
            cmd.Parameters.AddWithValue("@SetTimes", exercise.Set);
            cmd.Parameters.AddWithValue("@RepTimes", exercise.Rep);
            cmd.Parameters.AddWithValue("@Day", exercise.Day);
            cmd.Parameters.AddWithValue("@WorkDesc", exercise.Desc);
            cmd.Parameters.AddWithValue("@WorkoutPlace", exercise.WorkoutPlace);
            cmd.Parameters.AddWithValue("@UserId", exercise.UserId);

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

        // UpdateExercise Metodu
        public static void UpdateExercise(Exercises exercise, string id)
        {
            string sql = "UPDATE exercises SET title=@Title, set_times=@SetTimes, rep_times=@RepTimes, day=@Day, work_desc=@WorkDesc, workout_place=@WorkoutPlace WHERE user_id=@UserId";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Title", exercise.Title);
            cmd.Parameters.AddWithValue("@SetTimes", exercise.Set);
            cmd.Parameters.AddWithValue("@RepTimes", exercise.Rep);
            cmd.Parameters.AddWithValue("@Day", exercise.Day);
            cmd.Parameters.AddWithValue("@WorkDesc", exercise.Desc);
            cmd.Parameters.AddWithValue("@WorkoutPlace", exercise.WorkoutPlace);
            cmd.Parameters.AddWithValue("@UserId", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme başarılı");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }

        // DeleteExercise Metodu
        public static void DeleteExercise(string id)
        {
            string sql = "DELETE FROM exercises WHERE user_id = @UserId";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserId", id);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme başarılı");
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hata:" + exe);
            }
            connection.Close();
        }


    }
}
