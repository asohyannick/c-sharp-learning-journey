
var numbers = new List<int>
{
    1,
    2,
    3,
    4,
    1
};
numbers.AddRange([5, 6, 7]);
foreach (var number in numbers)
  Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine("Last index of 1:" + numbers.IndexOf(1));
Console.WriteLine("Last Index of 1" + numbers.LastIndexOf(1));

Console.WriteLine("Count:" + numbers.Count());

foreach (var num in numbers)
{
  if (num == 1)
    numbers.Remove(num);
}

foreach (var number in numbers)
{
  Console.WriteLine(number);
  numbers.Clear();
}