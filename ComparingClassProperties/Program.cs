using ConsoleSampleApps1.Net6.ComparingClassProperties;

//Get list of property names of Person class
List<string> personProperties = new Person().GetType().GetProperties().Select(p => p.Name).ToList();

//Get list of property names of Pet class
List<string> petProperties = new Pet().GetType().GetProperties().Select(p => p.Name).ToList();

//Get list of common property names from both lists
var commonProperties = petProperties.Intersect(personProperties);

foreach (string propertyName in commonProperties)
    Console.WriteLine(propertyName);
