using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class ListPeople
    {
        #region Properties
        private static List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people; }
        }
        #endregion

        #region Constructors
        public ListPeople() { }
        #endregion

        #region Methods

        public void AddPerson(Person p)
        {
            people.Add(p);
        }

        public void RemovePerson(Person p)
        {
            people.Remove(p);
        }

        #endregion

    }
}
