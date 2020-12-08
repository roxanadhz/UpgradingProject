namespace ProjectAfter8
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Middle { get; set; }
        public string LastName { get; set; }
        public Student(string name, string family) => (Id, Name, LastName) = (1, name, family);
        public Student(string name, string middle, string family) => (Id, Name, Middle, LastName) = (1, name, middle, family);       
           
    }
}
