namespace ConsoleSampleApps1.Net6.ComparingClassProperties
{
    public class Pet
    {
        public string FirstName { get; set; }
        public string Species { get; set; }
        public DateOnly BirthDate { get; set; }
        public List<Pet> Children { get; set; }
    }
}
