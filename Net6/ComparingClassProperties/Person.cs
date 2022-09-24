namespace ConsoleSampleApps1.Net6.ComparingClassProperties
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public List<Person> Children { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
