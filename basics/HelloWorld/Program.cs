var path = @"c:\somefile.jpg";
File.Copy("c:\\myfile.jpg", "d:\\temp\\myfile.jpg", true);
File.Delete(path);
if(File.Exists(path))
{
    //
}

var content = File.ReadAllText(path);
var fileInfo = new FileInfo(path);
fileInfo.CopyTo("...");
fileInfo.Delete();

if(fileInfo.Exists)
{
    // 
}

fileInfo.Read