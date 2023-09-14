using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Repository;
using Movie.Service.Interfaces;
using System.Data;
using System.Diagnostics.Metrics;
using System.IO;

namespace Movie.Service
{
    public class DirectorService : IDirectorService
    {
        public async Task AddDirector(Director director)
        {
            const string sqlExpression = "sp_addDirector";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("firstName", director.FirstName);
                    command.Parameters.AddWithValue("familyName", director.FamilyName);
                    command.Parameters.AddWithValue("dob", director.DateOfBirth.HasValue ? director.DateOfBirth : DBNull.Value);
                    command.Parameters.AddWithValue("dod", director.DateOfDeath.HasValue ? director.DateOfDeath : DBNull.Value);
                    command.Parameters.AddWithValue("gender", director.Gender);

                    await connection.OpenAsync();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
        }
        public async Task DeleteDirector(int id)
        {
            const string sqlExpression = "sp_deleteDirector";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id", id);

                    await connection.OpenAsync();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
        }
        public async Task<List<Director>> GetAllDirectors()
        {
            List<Director> result = new();
            const string sqlExpression = "sp_getAllDirectors";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(new Director
                            {
                                DirectorId = reader.GetInt32(0),
                                FirstName = !reader.IsDBNull(1) ? reader.GetString(1) : null,
                                FamilyName = !reader.IsDBNull(2) ? reader.GetString(2) : null,
                                FullName = !reader.IsDBNull(3) ? reader.GetString(3) : null,
                                DateOfBirth = !reader.IsDBNull(4) ? reader.GetDateTime(4) : null,
                                DateOfDeath = !reader.IsDBNull(5) ? reader.GetDateTime(5) : null,
                                Gender = !reader.IsDBNull(6) ? reader.GetString(6) : null
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }

                return result;
            }

        }
        public async Task<Director> GetDirector(int id)
        {
            Director result = new();
            const string sqlExpression = "sp_getSingleDirector";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);

                    await connection.OpenAsync();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {

                            result.DirectorId = reader.GetInt32(0);
                            result.FirstName = !reader.IsDBNull(1) ? reader.GetString(1) : null;
                            result.FamilyName = !reader.IsDBNull(2) ? reader.GetString(2) : null;
                            result.FullName = !reader.IsDBNull(3) ? reader.GetString(3) : null;
                            result.DateOfBirth = !reader.IsDBNull(4) ? reader.GetDateTime(4) : null;
                            result.DateOfDeath = !reader.IsDBNull(5) ? reader.GetDateTime(5) : null;
                            result.Gender = !reader.IsDBNull(6) ? reader.GetString(6) : null;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }

                return result;
            }





        }
        public async Task UpdateDirector(Director director)
        {
            const string sqlExpression = "sp_updateDirector";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("id", director.DirectorId);
                    command.Parameters.AddWithValue("firstName", director.FirstName);
                    command.Parameters.AddWithValue("familyName", director.FamilyName);
                    command.Parameters.AddWithValue("dob", director.DateOfBirth.HasValue ? director.DateOfBirth : DBNull.Value);
                    command.Parameters.AddWithValue("dod", director.DateOfDeath.HasValue ? director.DateOfDeath : DBNull.Value);
                    command.Parameters.AddWithValue("gender", director.Gender);

                    await connection.OpenAsync();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }



        }
    }
}