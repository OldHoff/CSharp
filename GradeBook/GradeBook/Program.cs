using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBookTest
    {
        private string courseName;

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        
        public void DisplayMessage( string courseName ){
            Console.WriteLine("Welcome to the grade book for \n{0}!", courseName);
        }
        static void Main(string[] args)
        {

            // create a gradebook object
            GradeBookTest myGradeBook = new GradeBookTest();

            // prompt for and input course name
            Console.WriteLine("Please enter the course name:");
            string nameOfCourse = Console.ReadLine();
            Console.WriteLine();

            // call myGradeBook's DisplayMessage method
            myGradeBook.DisplayMessage(nameOfCourse);
            Console.WriteLine("");
            string blank = Console.ReadLine();

        }
    }
}
