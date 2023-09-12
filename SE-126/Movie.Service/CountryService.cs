using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Service.Interfaces;
using System.Data;

namespace Movie.Service
{
    public class CountryService : ICountryService
    {
        public async Task AddCountry(Country country)
        {
            const string sqlExpression = "sp_addCountry";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("countryName", country.Name);

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

        public async Task DeleteCountry(int id)
        {
            const string sqlExpression = "sp_deleteCountry";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("countryId", id);

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

        public async Task<List<Country>> GetAllCountries()
        {
            List<Country> result = new();
            const string sqlExpression = "sp_getAllCountries";

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
                            result.Add(new Country
                            {
                                CountryId = reader.GetInt32(0),
                                Name = reader.GetString(1)
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

        public async Task<Country> GetCountry(int id)
        {
            Country result = new();
            const string sqlExpression = "sp_getSingleCountry";

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
                            result.CountryId = reader.GetInt32(0);
                            result.Name = reader.GetString(1);
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

        public async Task UpdateCountry(Country country)
        {
            const string sqlExpression = "sp_updateCountry";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("countryId", country.CountryId);
                    command.Parameters.AddWithValue("countryName", country.Name);

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
