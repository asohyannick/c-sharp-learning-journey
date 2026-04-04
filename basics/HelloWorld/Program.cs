using System.Text;
var sentence = "This is going to be a really really really really long text";
var summary = StringUtility.SummarizeText(sentence);
System.Console.WriteLine(summary);
var builder = new StringBuilder("Hello World");
builder
.Append('-', 10)
.AppendLine()
.Append("Header")
.Replace('_', '+')
.Remove(0, 10)
.Insert(0, new string('-', 10));
Console.WriteLine("First Char" + builder[0]);
System.Console.WriteLine(builder);