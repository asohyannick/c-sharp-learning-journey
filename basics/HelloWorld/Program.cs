var firstName = "Asoh";
var lastName = "Yannick";
var fullName = firstName + " " + lastName;

var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

var names = new string[3] {"John", "Jack", "Mary"};
var formattedNames = string.Join(",", names);
Console.WriteLine(formattedNames.ToLower());

