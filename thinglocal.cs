using System;
using System.IO;

Console.WriteLine("No need to connect because we are using local version");
Console.WriteLine("Reading script");
string text = System.IO.File.ReadAllText(@"piss.txt");
string[] readText = File.ReadAllLines("piss.txt");
var i = 0;
foreach (string s in readText)
{
    Console.Title = "Reading line " + i + "/293";
    Console.WriteLine(s);
    Thread.Sleep(500);
    i++;
}
Console.WriteLine("Wrote 293 lines");
System.Console.ReadKey();
