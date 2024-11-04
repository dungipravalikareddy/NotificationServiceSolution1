using EmployeeService.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService.Implementation
{
    public class ServiceImplementation
    {

        private readonly string _connectionString;


        public ServiceImplementation(string connectionString)
        {
            _connectionString = connectionString;
        }


        public List<Employment> GetAllEmployements()
        {
            var employments = new List<Employment>();


            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id as Id, name as Name FROM Employments;", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employments.Add(new Employment
                            {
                                Id = reader.GetGuid(0),
                                Name = reader.GetString(1),

                            }); 
                        }
                    }
                }
            }
            return employments;
        }

        public List<User> GetUsersByEmploymentType(Schema payload)
        {
            var users = new List<User>();


            using (var conn = new NpgsqlConnection(_connectionString))
            {
                conn.Open();
                var query = @"SELECT id as Id, display_name as DisplayName, email_id as EmailId, employment_id as EmploymentId FROM users WHERE employment_id = @employmentId AND is_deleted = false";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("employmentId", payload.employmentId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Id = reader.GetGuid(0),
                                DisplayName = reader.GetString(1),
                                EmailId =reader.GetString(2),
                                EmploymentId = reader.GetGuid(3)
                             
                            });
                        }
                    }
                }
            }
            return users;
        }

    }
}
