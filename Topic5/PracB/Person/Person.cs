public class Person
{

  public string FirstName { get; private set; }
  public string LastName { get; private set; }
  public double Age { get; set
    {
      if (value <= 0.0) {
        throw new ArgumentException("Age can't be less than 0");
    } else
      {
        field = value;
      }
    }}
  public string FullName => $"{FirstName}, {LastName}";


  public Person(string firstName, string lastName, double age)
  {
    FirstName = firstName;
    LastName = lastName;
    if (age <= 0.0f)
    {
      throw new ArgumentException("Age should be greater than zero");
    }
    Age = age;
  }


  public bool IsAdult()
  {
    return Age >= 18;
  }

  public static LinkedList<Person> ToLinkedList(List<Person> people)
    {
        var LinkedList = new LinkedList<Person>();
        foreach(var person in people)
        {
            LinkedList.AddLast(person);
        }
        return LinkedList;
    }
    public static string PrintPeople(LinkedList<Person> people)
  {
      string result = "";
      foreach(var person in people)
    {
      result += person.FullName + ", " + person.Age + "\n";
    }
    return result;
  }
  public static LinkedList<Person> SortPeople(LinkedList<Person> people)
  {
    List<Person> ListsortedPeople = new List<Person>(people);
    LinkedList<Person> sortedPeople = new LinkedList<Person>();
    ListsortedPeople.Sort((p1,p2) => p1.Age.CompareTo(p2.Age));
    foreach (var person in ListsortedPeople)
    {
      sortedPeople.AddLast(person);
    }
    return sortedPeople;
  }
}