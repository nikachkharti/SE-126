namespace Movie.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string Gender { get; set; }
    }
}
