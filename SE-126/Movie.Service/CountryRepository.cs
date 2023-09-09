using Microsoft.Data.SqlClient;
using Movie.Models;
using Movie.Service.Interfaces;
using System.Data;

namespace Movie.Service
{
    public class CountryRepository : ICountryRepository
    {
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
    }
}
