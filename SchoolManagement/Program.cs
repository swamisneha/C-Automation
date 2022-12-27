
namespace Csharp.Training
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Student Details**************");

            Student.SchoolName = "Global School";
            Student.SchoolAddress = "Chennai";

            Student S1 = new Student();
            Student S2 = new Student();
            Student S3 = new Student();

            S1.StudentId= 1001;
            S1.StudentName = "Jack";
            S1.StudentMailId = "jack@gmail.com";
            S1.StudentPercentage = 45.2;

            S2.StudentId = 1002;
            S2.StudentName = "Peter";
            S2.StudentMailId = "peter@gmail.com";
            S2.StudentPercentage = 85.2;

            S3.StudentId = 1003;
            S3.StudentName = "Mark";
            S3.StudentMailId = "mark@gmail.com";
            S3.StudentPercentage = 56.5;

            S1.printStudentDetails();
            S2.printStudentDetails();
            S3.printStudentDetails();

            S1.DisplayCertification();
            S2.DisplayCertification();
            S3.DisplayCertification();
        }
    }
}