using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationGUI
{
    class Student2 : Person2
    {
        private string major;
        private string studentId;

        // Default constructor
        public Student2()
            : base() // No arguments sent to base class constructor
        {
        }

        // Constructor sends three arguments to base class constructor
        public Student2(string id, string fname, string lname, string maj, string sId)
            : base(id, lname, fname) // Base constructor arguments
        {
            major = maj;
            studentId = sId;
        }

        // Read only Property for studentID
        public string StudentId
        {
            get
            {
                return studentId;
            }
        }

        // Property for major data field
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        // Overrides GetSleepAmt( ) method of the Person class
        public override int GetSleepAmt()
        {
            return 6;
        }

        // Using the base keyword, calls the overridden
        // GetSleepAmt( ) method of the Person class
        public int CallOverriddenGetSleepAmt()
        {
            return base.GetSleepAmt();
        }
    }
}
