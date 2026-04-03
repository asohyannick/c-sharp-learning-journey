
var numbers = new int[3];
numbers[0] = 1;
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

var flags = new bool[3];
flags[0] = true;
Console.WriteLine(flags[0]);
Console.WriteLine(flags[1]);
Console.WriteLine(flags[2]);

var persons = new string[3] {"John", "Paul", "Peter"};
Console.WriteLine(string.Join(", ", persons));

for(int i = 0; i < persons.Length; i++)
{
  Console.WriteLine(persons[i]);
}

foreach(var person in persons)
{
  Console.WriteLine(person);
}