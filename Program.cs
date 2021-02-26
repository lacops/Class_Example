using System;
using System.Collections.Generic;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Anders","And",88);
            Person person2 = new Person("Fætter", "Højben", 34);
            Person person3 = new Person("Mickey", "Mouse", 90);

            person1.ChangeAge(85);

            ListPeople listPeople = new ListPeople();

            // Adding persons to listPeople
            listPeople.AddPerson(person1);
            listPeople.AddPerson(person2);
            listPeople.AddPerson(person3);
            
            // Loop that shows people
            foreach (Person p in listPeople.People)
            {
                Console.WriteLine(p.FName + " " + p.LName + " er " + p.Age + " år gammel.");
            }
            
            Console.ReadKey();
        }
    }
}
