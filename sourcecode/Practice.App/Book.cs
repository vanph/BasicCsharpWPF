namespace Practice.App
{
    public class Book
    {
        public string Name { get; set; }

        public int Grade { get; set; }

        public Book(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
