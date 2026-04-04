namespace OOP
{
    public class Person
    {
        public string Name;
        
        public Person(string name)
        {
            Name = name;
        }
        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }
}