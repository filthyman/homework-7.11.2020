namespace StudentsProject.Models
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearCreation { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null;

        public override string ToString()
        {
            return Name;
        }
    }
}
