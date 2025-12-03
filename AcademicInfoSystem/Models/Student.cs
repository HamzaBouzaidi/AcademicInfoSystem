using AcademicInfoSystem.Database;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcademicInfoSystem.Models
{
    internal class Student
    {
        // i need to access the database connection here
        // make command to insert student data into the database


        public bool AddStudent(string FirstName, string LastName, int UserId, int GroupId, string StudentGroup)
        {

            try
            {
                string connString = "server=localhost;database=academicsystem;uid=root;pwd=Iloveshelly123?;";

               using  MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); 
                }

                MySqlCommand command = new MySqlCommand("INSERT INTO student (FirstName, LastName,  UserId,  GroupId, StudentGroup) VALUES (@fname, @lname, @uid, @gid, @Stdg)", connection);
                command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = FirstName;
                command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = LastName;
                command.Parameters.Add("@uid", MySqlDbType.Int32).Value = UserId;
                command.Parameters.Add("@gid", MySqlDbType.Int32).Value = GroupId;
                command.Parameters.Add("@Stdg", MySqlDbType.VarChar).Value = StudentGroup;


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


        public DataTable GetStudentList(MySqlCommand command)
        {
            try
            {
                string connString = "server=localhost;database=academicsystem;uid=root;pwd=Iloveshelly123?;";
                using (MySqlConnection connection = new MySqlConnection(connString))
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
                string connString = "server=localhost;database=academicsystem;uid=root;pwd=Iloveshelly123?;";
                using (MySqlConnection connection = new MySqlConnection(connString))
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

        public bool DeleteStudent(int StudentId)
        {
            try
            {
                string connString = "server=localhost;database=academicsystem;uid=root;pwd=Iloveshelly123?;";
                using (MySqlConnection connection = new MySqlConnection(connString))
                {
                    connection.Open();

                    MySqlCommand command = new MySqlCommand(
                        "DELETE FROM student WHERE StudentId = @stdid",
                        connection);

                    command.Parameters.AddWithValue("@stdid", StudentId);

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


    }
}

        
    
