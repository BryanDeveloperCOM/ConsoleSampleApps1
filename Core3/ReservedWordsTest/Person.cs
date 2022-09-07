namespace ConsoleSampleApps1.Core3.ReservedWordsTest
{
    //public class Person
    //{
    //    public string? firstname { get; set; }
    //    public string? lastname { get; set; }
    //    public bool public { get; set; } //Error CS1585: Member modifer 'public' must precede the member type and name
    //    public string? class { get; set; } //Error CS1519: Invalid token 'class' in class, record, struct, or interface member declaration
    //    public int int { get; set; } //Error CS1519: Invalid token 'int' in class, record, struct, or interface member declaration
    //}

    public class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public bool @public { get; set; }
        public string @class { get; set; }
        public int @int { get; set; }
    }
}
