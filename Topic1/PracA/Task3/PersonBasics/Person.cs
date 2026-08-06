class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public bool IsAdult()
    {
        if (Age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}