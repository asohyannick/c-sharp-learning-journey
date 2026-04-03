try
{
   var str = "true";
   bool b = Convert.ToBoolean(str);
   System.Console.WriteLine(b);
}
catch (System.Exception)
{
     System.Console.WriteLine("The num could not be converted to a byte.");
}