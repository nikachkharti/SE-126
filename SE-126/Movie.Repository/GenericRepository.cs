using Microsoft.Data.SqlClient;
using System.Data;

namespace Movie.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        public async Task<List<T>> GETAllAsyncProcedure(string procedureName, params object[] parameters)
        {
            if (string.IsNullOrWhiteSpace(procedureName))
            {
                throw new ArgumentException($"'{nameof(procedureName)}' cannot be null or whitespace.", nameof(procedureName));
            }

            List<T> result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters.Length != 0)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            string parameterName = $"param{i}";
                            command.Parameters.AddWithValue(parameterName, parameters[i]);
                        }
                    }

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
                                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                                {
                                    var value = reader[property.Name];
                                    property.SetValue(item, value);
                                }
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
        public async Task<List<T>> GETAllAsyncQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException($"'{nameof(query)}' cannot be null or whitespace.", nameof(query));
            }

            List<T> result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(query, connection);
                    command.CommandType = CommandType.Text;


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
                                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                                {
                                    var value = reader[property.Name];
                                    property.SetValue(item, value);
                                }
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

        public async Task<T> GETSingleAsyncProcedure(string procedure, params object[] parameters)
        {
            if (string.IsNullOrWhiteSpace(procedure))
            {
                throw new ArgumentException($"'{nameof(procedure)}' cannot be null or whitespace.", nameof(procedure));
            }

            T result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(procedure, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters.Length != 0)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            string parameterName = $"param{i}";
                            command.Parameters.AddWithValue(parameterName, parameters[i]);
                        }
                    }


                    await connection.OpenAsync();
                    var reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        var properties = typeof(T).GetProperties();

                        while (await reader.ReadAsync())
                        {
                            foreach (var property in properties)
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                                {
                                    var value = reader[property.Name];
                                    property.SetValue(result, value);
                                }
                            }
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

        public async Task<T> GETSingleAsyncQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException($"'{nameof(query)}' cannot be null or whitespace.", nameof(query));
            }

            T result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(query, connection);
                    command.CommandType = CommandType.Text;


                    await connection.OpenAsync();
                    var reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        var properties = typeof(T).GetProperties();

                        while (await reader.ReadAsync())
                        {
                            foreach (var property in properties)
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal(property.Name)))
                                {
                                    var value = reader[property.Name];
                                    property.SetValue(result, value);
                                }
                            }
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

        public async Task POSTProcedure(string procedure, params object[] parameters)
        {
            if (string.IsNullOrWhiteSpace(procedure))
            {
                throw new ArgumentException($"'{nameof(procedure)}' cannot be null or whitespace.", nameof(procedure));
            }

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(procedure, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters.Length != 0)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            string parameterName = $"param{i}";
                            command.Parameters.AddWithValue(parameterName, parameters[i]);
                        }
                    }

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
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

        public async Task POSTQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException($"'{nameof(query)}' cannot be null or whitespace.", nameof(query));
            }

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(query, connection);
                    command.CommandType = CommandType.Text;

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
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
