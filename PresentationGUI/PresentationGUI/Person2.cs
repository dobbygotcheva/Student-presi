using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationGUI
{
    class Person2
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;

        public Person2()   // Constructor with zero arguments
        {
        }

        public Person2(string id, string lname, string fname,
            int anAge)  // Constructor with four arguments
        {
            idNumber = id;
            lastName = lname;
            firstName = fname;
            age = anAge;
        }

        public Person2(string id, string lname, string fname)
        {               // Constructor with three arguments
            idNumber = id;
            lastName = lname;
            firstName = fname;
        }
        public Person2(string id)
        {               // Constructor with one arguments
            idNumber = id;
        }

        // Read-only property for the
        // identification number, it can not be changed.
        public string IdNumber
        {
            get
            {
                return idNumber;
            }
        }

        // Property for last name
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // Read-only property. First name can not be changed.
        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        // Overrides ToString( ) method from the Object class
        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        // Virtual method can be overriden by classes that
        // derive from the Person class.
        public virtual int GetSleepAmt()
        {
            return 8;
        }
    }
}
