namespace Movie.Service
{
    public static class HelperConfig
    {
        public static string ConnectionString { get; } = @"Server=DESKTOP-SCSHELD\SQLEXPRESS;Database=Movies;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
    }
}
