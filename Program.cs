using System;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create First Student

            Student FirstStudent = new Student();

            // Get student info First Student

            FirstStudent.StudentNum = AskForStudentNumber();

            FirstStudent.StudentFirstName = AskForStudentName("First");

            FirstStudent.StudentLastName = AskForStudentName("Last");

            FirstStudent.Major = AskForMajor(FirstStudent.StudentFirstName);

            FirstStudent.Score1 = AskForExamScore(1);

            FirstStudent.Score2 = AskForExamScore(2);
            
            FirstStudent.Score3 = AskForExamScore(3);

            Console.Clear();
            Console.WriteLine("First Student");
            Console.WriteLine(FirstStudent.ToString());

            Console.WriteLine("Enter any key to stop program");
            Console.ReadKey();



        }

        private static int AskForExamScore(int whichOne)
        {

            string inValue;
            int aScore;

            Console.WriteLine("Enter a value for score {0} :", whichOne);
            inValue = Console.ReadLine();
            aScore = int.Parse(inValue);
            return aScore;

        }

        private static string AskForMajor(string name)
        {
            string inValue;
            Console.WriteLine("Enter {0}\'s Major :", name);
            inValue = Console.ReadLine();
            return inValue;
        }

        private static string AskForStudentName(string whichOne)
        {

            string inValue;
            Console.WriteLine("Enter Students {0} Name :", whichOne);
            inValue = Console.ReadLine();
            return inValue;



        }

        private static string AskForStudentNumber()
        {
            string inValue;
            Console.WriteLine("Enter Students ID Number :");
            inValue = Console.ReadLine();
            return inValue;
        }
    }
}
