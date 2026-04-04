
var dateTime = new DateTime(2026, 1, 1);
var now = DateTime.Now;
var today = DateTime.Today;
Console.WriteLine("Hour" + now.Hour);
Console.WriteLine("Minute" + now.Minute);

var tommorrow = now.AddDays(1);
var yesterday = now.AddDays(-1);

System.Console.WriteLine(now.ToLongDateString());
System.Console.WriteLine(now.ToShortDateString());
System.Console.WriteLine(now.ToString());
System.Console.WriteLine(now.ToLongTimeString());
System.Console.WriteLine(now.ToString("yyyyy-mm-dd HH-mm"));

var start = DateTime.Now;
var timeSpan = new TimeSpan(1, 2, 3);
var timeSpan1 = new TimeSpan(1, 0, 0);
var timeSpan3 = TimeSpan.FromHours(1);
var end = DateTime.Now.AddMinutes(2);
var duration = end - start;
// Properties
System.Console.WriteLine("Duration:" + duration);
System.Console.WriteLine("Minutes:" + timeSpan.Minutes);
System.Console.WriteLine("Total Minutes" + timeSpan.TotalMinutes);

// Add 
System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
System.Console.WriteLine("Substract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));
// ToString
System.Console.WriteLine("ToString:" + timeSpan.ToString());


// Parse
System.Console.WriteLine("Parse"  + TimeSpan.Parse("01:02:03"));