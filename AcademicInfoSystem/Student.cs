using AcademicInfoSystem.Database;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicInfoSystem
{
    internal class Student
    {
        // i need to access the database connection here
        // make command to insert student data into the database


        public  bool AddStudent(string firstName, string lastName, int UserId, int GroupId, string StudentGroup)
        {
            
            try
            {

                MySqlConnection connection = DatabaseConnection.GetConnection();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                } 

                    MySqlCommand command = new MySqlCommand("INSERT INTO student (FirstName, LastName,  UserId,  GroupId, StudentGroup) VALUES (@fname, @lname, @uid, @gid, @Stdg)", connection);
                    command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstName;
                    command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastName;
                    command.Parameters.Add("@uid", MySqlDbType.Int32).Value = UserId;
                    command.Parameters.Add("@gid", MySqlDbType.Int32).Value = GroupId;
                    command.Parameters.Add("@Stdg", MySqlDbType.VarChar).Value = StudentGroup;

                    
                    int result = command.ExecuteNonQuery();

                    if (connection.State == ConnectionState.Open) { 
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
            command.Connection = DatabaseConnection.GetConnection();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
            
        }

    }
}
