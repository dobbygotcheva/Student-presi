/* PresentationGUI.cs
 * This application added two new
 * classes - all in the same project.
 * Inheritance is illustrated through
 * Student extending Person.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace PresentationGUI
{
    public partial class PresentationGUI : Form
    {
        private Student aStudent;
        public PresentationGUI()
        {
            InitializeComponent();
        }

        private void PresentationGUI_Load(object sender, EventArgs e)
        {
            // Student object instantiated
            aStudent = new Student("123456789", "Metodi", "Traykov", "CS", "1111");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Uses Age property defined in the Person class
            aStudent.Age = 25;

            // Calls overridden ToString() defined in Person class
            txtBxName.Text = aStudent.ToString();

            // Calls ToString( ) defined in object class
            txtBxAge.Text = aStudent.Age.ToString();

            // Uses StudentID property defined in Student class
            txtBxID.Text = aStudent.StudentId;

            // Calls GetSleepAmt( ) defined in Student class
            txtBxStudentSleep.Text = Convert.ToString(aStudent.GetSleepAmt());

            // Calls method defined in Student class that
            // has a call to base.GetSleepAmt( ) in Person class
            txtBxPersonSleep.Text = Convert.ToString(aStudent.CallOverriddenGetSleepAmt());
        }
    }
}
