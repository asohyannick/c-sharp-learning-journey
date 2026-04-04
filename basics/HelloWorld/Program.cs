
var fullName = "Asoh Yannick    ";
System.Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
System.Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());
var index = fullName.IndexOf(" ");
var firstName = fullName.Substring(0, index);
var lastName = fullName.Substring(index + 1);
System.Console.WriteLine("FirstName: " + firstName);
System.Console.WriteLine("LastName: " + lastName);
var names = fullName.Split(' ');
System.Console.WriteLine("FirstName: " + names[0]);
System.Console.WriteLine("LastName: " + names[1]);
fullName.Replace("Mosh", "Peace");
fullName.Replace("0", "1");
System.Console.WriteLine(fullName.Replace("Mosh", "Joy"));

if (String.IsNullOrWhiteSpace("") || String.IsNullOrEmpty(""))
{
  Console.WriteLine("Invalid");
}

var str = "25";
var resultStr = Convert.ToByte(str);
System.Console.WriteLine(resultStr);
float price = 29.95f;
System.Console.WriteLine();;