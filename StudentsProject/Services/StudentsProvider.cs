using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class StudentsProvider
    {
        private SqlConnection _connection;

        public StudentsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Student> GetAllWichGroups()
        {
            var result = new List<Student>();

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(
                    @"
                        SELECT 
                            [Students].[id], 
                            [Students].[name], 
                            [Students].[surname], 
                            [Students].[group_id], 
                            [Groups].[id], 
                            [Groups].[name], 
                            [Groups].[year],
                            [Groups].[speciality_id]
                        FROM
                            [Students]
                        LEFT JOIN
                            [Groups]
                        ON [Students].[group_id] = [Groups].[id]  
                    ",
                    _connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var students = new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2),
                            GroupId = reader.GetInt32(3)
                        };
                        var group = new StudentGroup
                        {
                            // UNKNOWN ERROR 
                            Id = reader.GetInt32(4),
                            Name = reader.GetString(5),
                            YearCreation = reader.GetInt32(6),
                            SpecialtyId = reader.GetInt32(7)
                        };
                        students.Group = group;
                        

                        result.Add(students);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }
            return result;

        }

        public bool Add(Student data)
        {
            bool ok;
            try
            {
                _connection.Open();

                var cmd = new SqlCommand(
                                            @"
                                                INSERT INTO [Groups]
                                                    (Students)
                                                VALUES
                                                    (@Id, @Name, @Surname, @GroupId)
                                            ", _connection);
                cmd.Parameters.AddWithValue("@Id", data.Id);
                cmd.Parameters.AddWithValue("@Name", data.Name);
                cmd.Parameters.AddWithValue("@Year", data.Surname);
                cmd.Parameters.AddWithValue("@Speciality_id", data.GroupId);
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return ok;
        }

        public bool Update(int id, Student newData)
        {
            bool ok;
            try
            {
                _connection.Open();

                var cmd = new SqlCommand(
                                            @"
                                                UPDATE [Students]
                                                SET
                                                    [name] = @Name,
                                                    [surname] = @Surname,
                                                    [group_id] = @Group_id
                                                WHERE
                                                    [id] = @Id
                                            ", _connection);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", newData.Name);
                cmd.Parameters.AddWithValue("@Surname", newData.Surname);
                cmd.Parameters.AddWithValue("@Group_id", newData.GroupId);

                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return ok;
        }

        
    }
}
