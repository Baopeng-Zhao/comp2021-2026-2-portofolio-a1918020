using System.Collections.Generic;

Person fred = new Person("Fred", "Smith", 21);
Person jane = new Person("Jane", "Doe", 25);
Person bob = new Person("Bob", "Johnson", 30);
Person ian = new Person("Ian", "Brown", 28);
Person sam = new Person("Sam", "Wilson", 22);
Person rusell = new Person("Russell", "Davis", 26);
Person jack = new Person("Jack", "Miller", 24);
Person sue = new Person("Sue", "Williams", 29);
Person Aroosh = new Person("Aroosh", "Rajash", 23);
Person Chen = new Person("Chen", "Wang", 27);

var people = new List<Person> { fred, jane, bob, ian, sam, rusell, jack, sue, Aroosh, Chen };
LinkedList<Person> LinkedList = Person.ToLinkedList(people);
Console.WriteLine(Person.PrintPeople(LinkedList));
LinkedList<Person> sortedLinkedList = Person.SortPeople(LinkedList);
Console.WriteLine(Person.PrintPeople(sortedLinkedList));