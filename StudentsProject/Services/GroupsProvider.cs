using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using StudentsProject.Models;

namespace StudentsProject.Services
{
    public class GroupsProvider
    {
        private SqlConnection _connection;

        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<StudentGroup> GetAllWithSpecialties()
        {
            var result = new List<StudentGroup>();

            try
            {

                _connection.Open();
                var cmd = new SqlCommand(
                    @"
                        SELECT 
                            [Groups].[id], 
                            [Groups].[name], 
                            [Groups].[year], 
                            [Groups].[speciality_id], 
                            [Specialties].[id], 
                            [Specialties].[code], 
                            [Specialties].[name]
                        FROM
                            [Groups]
                        LEFT JOIN
                            [Specialties]
                        ON [Groups].[speciality_id] = [Specialties].[id]
                    ",
                    _connection
                );
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var group = new StudentGroup
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            YearCreation = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3)
                        };
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(4),
                            Code = reader.GetString(5),
                            Name = reader.GetString(6)
                        };
                        group.Specialty = specialty;

                        result.Add(group);
                    }
                }
            }
            finally 
            {
                _connection.Close();
            }
            return result;
        }

        public bool Add(StudentGroup data)
        {
            bool ok;
            try
            {
                _connection.Open();

                var cmd = new SqlCommand(
                                            @"
                                                INSERT INTO [Groups]
                                                    (Groups)
                                                VALUES
                                                    (@Id, @Name, @Year, @Speciality_id)
                                            ",_connection);
                cmd.Parameters.AddWithValue("@Id", data.Id);
                cmd.Parameters.AddWithValue("@Name", data.Name);
                cmd.Parameters.AddWithValue("@Year", data.YearCreation);
                cmd.Parameters.AddWithValue("@Speciality_id", data.SpecialtyId);
                ok = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return ok;
        }

        public bool Update(int id, StudentGroup newData)
        {
            bool ok;
            try
            {
                _connection.Open();

                var cmd = new SqlCommand(
                                            @"
                                                UPDATE [Groups]
                                                SET
                                                    [name] = @Name,
                                                    [year] = @Year,
                                                    [speciality_id] = @Speciality_id
                                                WHERE
                                                    [id] = @Id
                                            ", _connection);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", newData.Name);
                cmd.Parameters.AddWithValue("@Year", newData.YearCreation);
                cmd.Parameters.AddWithValue("@Speciality_id", newData.SpecialtyId);

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
