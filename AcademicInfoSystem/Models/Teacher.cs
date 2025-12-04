using AcademicInfoSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem.Models
{
    internal class Teacher
    {

        public bool AddTeacher(string firstName, string lastName)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Step 1: Create User
                    MySqlCommand userCmd = new MySqlCommand(
                        "INSERT INTO user (FirstName, LastName, Login, Password, Role) " +
                        "VALUES (@Fname, @Lname, @Login, @Pass, 'teacher')",
                        connection);

                    userCmd.Parameters.AddWithValue("@Fname", firstName);
                    userCmd.Parameters.AddWithValue("@Lname", lastName);
                    userCmd.Parameters.AddWithValue("@Login", firstName.ToLower());
                    userCmd.Parameters.AddWithValue("@Pass", lastName.ToLower());

                    userCmd.ExecuteNonQuery();

                    int newUserId = (int)userCmd.LastInsertedId;

                    // Step 2: Create Teacher linked to the user
                    MySqlCommand teacherCmd = new MySqlCommand(
                        "INSERT INTO teacher (UserId) VALUES (@UsrId)", connection);

                    teacherCmd.Parameters.AddWithValue("@UsrId", newUserId);
                    int result = teacherCmd.ExecuteNonQuery();

                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }


        // list subjects
        public DataTable GetTeacherList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool UpdateTeacher(int TeacherId, int UserId)
        {

            try
            {
                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySqlCommand command = new MySqlCommand("UPDATE teacher SET TeacherId=@TeaId, UserId=@UsrId WHERE TeacherId=@TeaId", connection);
                command.Parameters.Add("@TeaId", MySqlDbType.Int32).Value = TeacherId;
                command.Parameters.Add("@UsrId", MySqlDbType.Int32).Value = UserId;
                

                int result = command.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
                return result == 1;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }

        }


        public bool DeleteTeacher(int teacherId)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Step 1: Get UserId linked to this teacher
                    MySqlCommand getUserCmd = new MySqlCommand(
                        "SELECT UserId FROM teacher WHERE TeacherId=@TeaId",
                        connection);
                    getUserCmd.Parameters.AddWithValue("@TeaId", teacherId);

                    object resultObj = getUserCmd.ExecuteScalar();
                    if (resultObj == null)
                    {
                        MessageBox.Show("Teacher not found!");
                        return false;
                    }

                    int userId = Convert.ToInt32(resultObj);

                    // Step 2: Delete user
                    MySqlCommand deleteUserCmd = new MySqlCommand(
                        "DELETE FROM user WHERE UserId=@uid", connection);
                    deleteUserCmd.Parameters.AddWithValue("@uid", userId);

                    int deleted = deleteUserCmd.ExecuteNonQuery();

                    return deleted == 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }


        public DataTable GetteacherList(MySqlCommand command)
        {
            command.Connection = DatabaseConnection.GetConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }


}
