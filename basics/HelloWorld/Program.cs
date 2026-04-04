Directory.CreateDirectory(@"c:\\projects\Csharp");
var files = Directory.GetFiles(@"c:\\projects\Csharp", ", ", SearchOption.AllDirectories);
foreach(var file in files) 
System.Console.WriteLine(file);

var directories = Directory.GetDirectories(@"c:\\projects\C#", ",*", SearchOption.AllDirectories);
foreach(var directory in directories)
System.Console.WriteLine(directory);

Directory.Exists("...");
var directoryInfo = DirectoryInfo("...");
directoryInfo.GetFiles();
directoryInfo.GetDirectory();

var path = @"c:\Projects\C#\helloworld";
var dotIndex = path.IndexOf(',');
var extension = path.Substring(dotIndex);
System.Console.WriteLine("Extension:" + Path.GetExtension(path));
System.Console.WriteLine("File Name: " + Path.GetFileName(path));
System.Console.WriteLine("File Name with Extension:" + Path.GetFileNameWithoutExtension(path));
System.Console.WriteLine("Directory Name:" + Path.GetDirectoryName(path));
