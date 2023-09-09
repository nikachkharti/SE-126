using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Service.Interfaces;
using System.Data;

namespace Movie.Service
{
    public class CountryRepository : ICountryRepository
    {
        public void AddCountry(Country country)
        {
            const string sqlExpression = "sp_addCountry";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("countryName", country.Name);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.CloseAsync();
                }
            }

        }

        public void DeleteCountry(int id)
        {
            throw new NotImplementedException();
        }

        public List<Country> GetAllCountries()
        {
            List<Country> result = new();
            const string sqlExpression = "sp_getAllCountries";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
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
                    connection.Close();
                }

                return result;
            }

        }


        public Country GetCountry(int id)
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

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
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
                    connection.Close();
                }

                return result;
            }
        }

        public void UpdateCountry(Country country)
        {
            throw new NotImplementedException();
        }
    }
}
