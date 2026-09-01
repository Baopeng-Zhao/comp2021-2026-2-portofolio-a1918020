List<string> names = new List<string>();
int index = 0;
int sumLength = 0;
string[] arrayNames = new string[10]{"Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Henry", "Ivy", "Jack"};
List<string> arrayListNames = new List<string>();
names.Add("Michael");

names.AddRange(new string[] {"Sophie", "Lucas", "Grace", "Nathan", "Chloe", "Ethan", "Victoria", "Ryan", "Jessica", "IAN"});

names.Remove("IAN");

names.Insert(names.Count/2, "IAN");

for(int i = 0; i < names.Count; i++)
{
    if(names[i] == "IAN")
    {
        index = i;
    }
}

Console.Write("Here is the index of IAN: ");
Console.WriteLine(index);

Console.Write("Here is the list of names which contains 'B': ");

for (int i = 0; i < names.Count; i++)
{
    if(names[i].Contains("C"))
    {
        Console.WriteLine(names[i]);
    }
}

for(int i = 0; i < names.Count; i++)
{
    sumLength += names[i].Length;
}
Console.Write("Here is the sum of the lengths of all names: ");
Console.WriteLine(sumLength);

for (int i = 0; i < arrayNames.Length; i++)
{
    arrayListNames.Add(arrayNames[i]);
}

names.AddRange(arrayListNames);

Console.Write("Here is the list of names after adding the array: ");

for(int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}