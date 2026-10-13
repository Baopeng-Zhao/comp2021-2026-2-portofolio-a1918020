using System.Diagnostics;
using System.Text;

Stopwatch Append = new Stopwatch();
string aOutput = "";
Append.Start();
for(int i = 0; i < 100000; i++)
{
    aOutput += "z";
}
Append.Stop();
Console.WriteLine($"Total time is: {Append.Elapsed.TotalSeconds} seconds");

Stopwatch Build = new Stopwatch();
StringBuilder bOutput = new StringBuilder();
Build.Start();
for(int i = 0; i < 100000; i++)
{
    bOutput.Append("z");
}
Build.Stop();
Console.WriteLine($"Total time is: {Build.Elapsed.TotalSeconds} seconds");