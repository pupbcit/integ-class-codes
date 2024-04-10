using PUPPointsBusinessServices;

namespace PUPPointsUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter student number: ");
            string studentNumber = Console.ReadLine();

            StudentService studentService = new StudentService();
            bool result = studentService.VerifyStudent(studentNumber);

            if (result)
            {
                Console.WriteLine("WELCOME TO PUPPOINTS");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}