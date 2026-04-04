var numbers = new int[] {3, 2, 1, 14, 7, 10};
// Array methods
// length
System.Console.WriteLine(numbers.Length);
// index
var index = Array.IndexOf(numbers, 14);
System.Console.WriteLine(index);
// clear 
Array.Clear(numbers, 0, 2);
foreach(var num in numbers) 
System.Console.WriteLine(num);

// copy()
int[] anotherCopy = new int[3];
Array.Copy(numbers, anotherCopy, 3);

// sort
Array.Sort(numbers);

// Reverse

