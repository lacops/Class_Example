using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Person
    {
        #region Properties

        private string fName;
        private string lName;
        private int age;

        public int Age
        {
            get { return age; }
        }

        public string FName
        {
            get { return fName; }
        }

        
        public string LName
        {
            get { return lName; }
        }


        #endregion

        #region Constructors

        public Person()
        {
            // Some functionality
        }

        public Person(string _fName, string _lName, int _age)
        {
            fName = _fName;
            lName = _lName;
            age = _age;
        }

        #endregion

        #region Methods

        public void ChangeAge(int _age)
        {
            age = _age;
        }

        #endregion
    }
}
