namespace WebApplication1.People
{
    public class StudentDTO
    {
        public StudentDTO() { }

        public StudentDTO(int course, double averageScore)
        {
            this.Course = course;
            this.AverageScore = averageScore;
        }

        public int Course { get; set; }
        public double AverageScore { get; set; }
    }
}
