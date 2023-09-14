using Microsoft.Data.SqlClient;
using System.Data;

namespace Movie.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        public async Task<List<T>> GETAllAsync(string procedureName)
        {
            List<T> result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;


                    await connection.OpenAsync();
                    var reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        var properties = typeof(T).GetProperties();

                        while (await reader.ReadAsync())
                        {
                            T item = new();

                            foreach (var property in properties)
                            {
                                var value = reader[property.Name];
                                property.SetValue(item, value);
                            }

                            result.Add(item);
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
            }

            return result;
        }
    }
}
