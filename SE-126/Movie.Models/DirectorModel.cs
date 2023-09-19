namespace Movie.Models
{
    public class DirectorModel
    {
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string FullName { get; set; }
        public DateTime? DoB { get; set; }
        public DateTime? DoD { get; set; }
        public string Gender { get; set; }
    }
}
