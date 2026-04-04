
int hour = 10;
bool isGoldCustomer = true;
float price = isGoldCustomer ? 19.95f : 29.95f;
if (hour > 0 && hour < 12)
{
  Console.WriteLine("It's morning");
}
else if (hour >= 12 && hour < 18)
{
  Console.WriteLine("It's afternoon");
}
else
{
  Console.WriteLine("It's evening.");
}

Console.WriteLine(price);

var season = Season.Autumn;
switch (season)
{
  case Season.Autumn:
    Console.WriteLine("It's autumn and a beautiful season");
    break;
  case Season.Summer:
    Console.WriteLine("It's perfect to go to beach");
    break;
  default:
    Console.WriteLine("Unknown Season");
    break;
}


for (var i = 1; i <= 10; i++)
{
  if (i % 2 == 0)
    Console.WriteLine(i);
}

for (var i = 10; i >= 1; i--)
{
  Console.WriteLine(i);
}

var name = "John Smith";
for (var i = 0; i < name.Length; i++)
{
  System.Console.WriteLine(name[i]);
}

foreach (var character in name)
{
  Console.WriteLine(character);
}

var numbers = new int[] { 1, 2, 3, 4 };
foreach (var number in numbers)
{
  Console.WriteLine(number);
}

var y = 0;
while (y <= 10)
{
  if (y % 2 == 0)
    break;
  Console.WriteLine(y);
}

while (true)
{
  Console.WriteLine("Type your name");
  var input = Console.ReadLine();
  if (!String.IsNullOrWhiteSpace(input))
    continue;
  Console.WriteLine("@Echo:", input);
  break;
}
