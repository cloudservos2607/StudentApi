namespace StudentApi.Models
{
    public class Student
    {
        public int Id { get; set; } // Make sure this property exists
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double Percent { get; set; }
        public string Qualification { get; set; }
        public int YearPassed { get; set; }
    }
}

