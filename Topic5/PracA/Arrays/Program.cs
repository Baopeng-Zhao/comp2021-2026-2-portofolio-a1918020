string[] Array = new string[10];
string[] names = new string[10]{"Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Henry", "Ivy", "Jack"};
string longestName = names[1];
string shortestName = names[1];
string[] sortedArray = names;
string[] reversedArray = new string[10];
Array.Sort(sortedArray);

for (int i = 0; i<Array.Length; i++)
{
    Array[i]=names[i];
    Console.WriteLine(Array[i]);
}
Console.Write("Here is a the longest name: ");

for(int i = 0; i<Array.Length; i++)
{
    if(Array[i].Length>longestName.Length)
    {
        longestName = Array[i];
    }
}

Console.WriteLine(longestName);
Console.Write("Here is a the shortest name: ");

for(int i = 0; i<Array.Length; i++)
{
    if(Array[i].Length<shortestName.Length)
    {
        shortestName = Array[i];
    }
}
Console.WriteLine(shortestName);

Console.Write("Here is the orignal array: ");

for(int i = 0; i<Array.Length; i++)
{
    Console.WriteLine(Array[i]);
}

Console.Write("Here is the sorted array: ");

for(int i = 0; i<sortedArray.Length; i++)
{
    Console.WriteLine(sortedArray[i]);
}

for(int i = 0; i<Array.Length; i++)
{
    reversedArray[i] = Array[Array.Length -1 -i];
}

Console.Write("Here is the reversed array: ");

for(int i = 0; i<reversedArray.Length; i++)
{
    Console.WriteLine(reversedArray[i]);
}
