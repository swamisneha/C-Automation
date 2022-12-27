using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Training
{
    public class Student
    {
        public int StudentId;
        public string StudentName;
        public string StudentMailId;
        public double StudentPercentage;
        public static string SchoolName;
        public static string SchoolAddress;

        public void printStudentDetails()
        {
            Console.WriteLine("StudentID: " + StudentId);
            Console.WriteLine("Stident Name: " + StudentName);
            Console.WriteLine("Student MailId: " + StudentMailId);
            Console.WriteLine("Student Percentage: " + StudentPercentage);
            Console.WriteLine("School Name: " + SchoolName);
            Console.WriteLine("School Address: " + SchoolAddress);
            Console.WriteLine("---------------------------------------------------");
        }
            public void DisplayCertification()
            {
                Console.WriteLine("StudentID: " + StudentId);
                if (StudentPercentage >= 90)
                {
                    Console.WriteLine("Hi " + StudentName + " ! You have Successfully passed with Grade 'A'");
                    Console.WriteLine();
                }      
                else if (StudentPercentage>=80 && StudentPercentage<=89)
                {
                    Console.WriteLine("Hi " + StudentName + " ! You have Successfully passed with Grade 'B'");
                    Console.WriteLine();
                }
                else if (StudentPercentage >= 60 && StudentPercentage<=79)
                {
                    Console.WriteLine("Hi " + StudentName + " ! You have Successfully Passed with Grade 'C'");
                    Console.WriteLine();
                }
                else if (StudentPercentage < 60)
                {
                    Console.WriteLine("Hi " + StudentName + " ! Your Grade is 'F'");
                    Console.WriteLine();
                }
               
            }

        
        

    }
}
