using System;
using System.Net;
using System.IO;

Console.WriteLine("Connecting to 88.111.130.77 port 83");
using (var client = new WebClient())
{
    client.DownloadFile("http://88.111.130.77:83/piss.txt", "piss.txt");

}
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
