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

            Console.WriteLine("Press enter  for next student");
            Console.ReadKey();

            //Create second student

            Console.WriteLine(" \nSecond Student Info\n");

            Student SecondStudent = new Student("2345", "Smith", "Maria");

            SecondStudent.Major = AskForMajor(SecondStudent.StudentFirstName);

            SecondStudent.Score1 = AskForExamScore(1);

            SecondStudent.Score2 = AskForExamScore(2);

            SecondStudent.Score3 = AskForExamScore(3);

            Console.Clear();
            Console.WriteLine("Second Student");
            Console.WriteLine(SecondStudent.ToString());

            Console.WriteLine("Press enter  for next student");
            Console.ReadKey();

            Console.WriteLine(" Geting data from database");

            Student ThirdStudent = new Student("23457", "Smith", "Mr.", "Computer Science", 95, 78, 92);

            Console.WriteLine("Third Student");
            Console.WriteLine(ThirdStudent.ToString());

            Console.WriteLine("Enter any key to stop program");
            Console.ReadKey();
        }

        private static void GetstudentInfo()
        {
            throw new NotImplementedException();
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
