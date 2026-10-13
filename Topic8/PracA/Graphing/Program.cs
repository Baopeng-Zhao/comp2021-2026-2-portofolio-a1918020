using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using ScottPlot;

int iterations = 20;
List<double> appendElapsedList = new List<double>();
List<double> builderElapsedList = new List<double>();
Stopwatch WatchAppend = new Stopwatch();
WatchAppend.Start();
for (int pass = 1; pass <= iterations; pass++)
{
    string aOutput = "";
    WatchAppend.Restart();
    for(int i = 0; i < pass*10000; i++)
    {
        aOutput += "z";
    }
    WatchAppend.Stop();
    appendElapsedList.Add(WatchAppend.Elapsed.TotalSeconds);
}

Stopwatch WatchBuild = new Stopwatch();
for (int pass = 1; pass <= iterations; pass++)
{
    StringBuilder bOutput = new StringBuilder();
    WatchBuild.Restart();
    for(int i = 0; i < pass*10000; i++)
    {
        bOutput.Append("z");
    }
    WatchBuild.Stop();
    builderElapsedList.Add(WatchBuild.Elapsed.TotalSeconds);
}

ScottPlot.Plot appendPlot = new();
appendPlot.Add.Bars(appendElapsedList.ToArray());

appendPlot.Title("Append Performance");
appendPlot.XLabel("Pass");
appendPlot.YLabel("Elapsed Time (Seconds)");

appendPlot.SavePng("appendPlot.png", 800, 600);
ScottPlot.Plot builderPlot = new();

builderPlot.Add.Bars(builderElapsedList.ToArray());

builderPlot.Title("StringBuilder Performance");
builderPlot.XLabel("Pass");
builderPlot.YLabel("Elapsed Time (Seconds)");

builderPlot.SavePng("buildPlot.png", 800, 600);