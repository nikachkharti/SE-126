namespace Movie.Service
{
    public static class HelperConfig
    {
        public static string ConnectionString { get; } = @"Server=T-25-01\SQLEXPRESS;Database=Movies;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
    }
}
