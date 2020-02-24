using System;
namespace WeedenAssignment4Iterator
{
    public class Person
    {
        //Specify types of Persons (employees)
        public enum TypeEnum { PartTime, FullTime }

        //public attributes of person
        public string Name { get; set; }
        public int Number { get; set; }
        public TypeEnum Type { get; set; }
    }
}
