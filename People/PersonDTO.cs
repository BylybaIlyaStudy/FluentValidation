namespace WebApplication1.People
{
    public class PersonDTO
    {
        public PersonDTO() { }

        public PersonDTO(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age { get; set; }
        public string Name { get; set; }
    }
}
