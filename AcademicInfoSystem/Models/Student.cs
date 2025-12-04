using AcademicInfoSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AcademicInfoSystem.Models
{
    internal class Student
    {
        public bool AddStudent(string firstName, string lastName, int groupId, string studentGroupName)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // Step 1: Create USER
                    MySqlCommand userCmd = new MySqlCommand(
                        "INSERT INTO user (FirstName, LastName, Login, Password, Role) " +
                        "VALUES (@Fname, @Lname, @Login, @Pass, 'student')",
                        connection);

                    userCmd.Parameters.AddWithValue("@Fname", firstName);
                    userCmd.Parameters.AddWithValue("@Lname", lastName);
                    userCmd.Parameters.AddWithValue("@Login", firstName.ToLower());
                    userCmd.Parameters.AddWithValue("@Pass", lastName.ToLower());

                    userCmd.ExecuteNonQuery();

                    int newUserId = (int)userCmd.LastInsertedId;

                    // Step 2: Create STUDENT linked to the user
                    MySqlCommand studentCmd = new MySqlCommand(
                        "INSERT INTO student (FirstName, LastName, UserId, GroupId, StudentGroup) VALUES (@Fname, @Lname, @UsrId, @GrpId, @StdGroup)",
                        connection);
                     studentCmd.Parameters.AddWithValue("@Fname", firstName);
                    studentCmd.Parameters.AddWithValue("@Lname", lastName);
                    studentCmd.Parameters.AddWithValue("@UsrId", newUserId);
                    studentCmd.Parameters.AddWithValue("@GrpId", groupId);
                    studentCmd.Parameters.AddWithValue("@StdGroup", studentGroupName);

                    int result = studentCmd.ExecuteNonQuery();

                    return result == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }


        public DataTable GetStudentList(MySqlCommand command)
        {
            try
            {
                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    command.Connection = connection;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new DataTable();
            }
        }

        public bool UpdateStudentList(int StudentId, string firstName, string lastName, int GroupId, string StudentGroup)
        {
            try
            {
                // FIXED: Use DatabaseConnection.GetConnection() instead of hardcoded string
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(
                        "UPDATE student SET FirstName = @fname, LastName = @lname, GroupId = @gid, StudentGroup = @Stdg WHERE StudentId = @stdid",
                        connection);

                    command.Parameters.AddWithValue("@stdid", StudentId);
                    command.Parameters.AddWithValue("@fname", firstName);
                    command.Parameters.AddWithValue("@lname", lastName);
                    command.Parameters.AddWithValue("@gid", GroupId);
                    command.Parameters.AddWithValue("@Stdg", StudentGroup);

                    int result = command.ExecuteNonQuery();
                    return result == 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return false;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    // 1️⃣ First, get UserId from Student table
                    MySqlCommand getUserCmd = new MySqlCommand(
                        "SELECT UserId FROM student WHERE StudentId=@stdid",
                        connection);
                    getUserCmd.Parameters.AddWithValue("@stdid", studentId);

                    object resultObj = getUserCmd.ExecuteScalar();
                    if (resultObj == null)
                    {
                        MessageBox.Show("Student not found.");
                        return false;
                    }

                    int userId = Convert.ToInt32(resultObj);

                    // 2️⃣ Delete FROM user → CASCADE removes student
                    MySqlCommand deleteUserCmd = new MySqlCommand(
                        "DELETE FROM user WHERE UserId=@uid",
                        connection);
                    deleteUserCmd.Parameters.AddWithValue("@uid", userId);

                    int deleted = deleteUserCmd.ExecuteNonQuery();
                    return deleted == 1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}");
                return false;
            }
        }

    }
}