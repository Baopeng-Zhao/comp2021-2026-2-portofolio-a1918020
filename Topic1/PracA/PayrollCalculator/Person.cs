public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    
    {
        if (firstName == "" || lastName == "")
        {
            throw new ArgumentException("Name cannot be empty");
        }

        if (age < 0)
        {
            throw new ArgumentException("Age cannot be negative");
        }

        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FullName()
    {
        return LastName + "" + FirstName;
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}