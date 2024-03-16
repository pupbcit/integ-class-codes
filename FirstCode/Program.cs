using System;
using SISBL;

namespace FirstCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Register a user. Enter -1 to go login");
            string userOption = Console.ReadLine();

            while (userOption != "-1")
            {
                Console.WriteLine("REGISTRATION!");
                Console.Write("Enter student number: ");
                string userinputSN = Console.ReadLine();

                Console.Write("Enter password: ");
                string userinputPW = Console.ReadLine();

                UserCredentials registerUser = new UserCredentials();
                registerUser.studentnumber = userinputSN;
                registerUser.password = userinputPW;

                UserBusinessLogic.RegisterUser(registerUser);

                Console.WriteLine("Register a user. Enter -1 to go login");
                userOption = Console.ReadLine();
            }

            if (GetLoginCredentials())
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static bool GetLoginCredentials()
        {
            string studentNumber;
            string password;

            Console.WriteLine("Welcome to PUP SIS");
            Console.WriteLine("LOGIN");

            Console.WriteLine("Enter Student Number: ");
            studentNumber = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            password = Console.ReadLine();

            return UserBusinessLogic.Login(studentNumber, password);
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Profile");
            Console.WriteLine("Enrollment");
            Console.WriteLine("Grades");
            Console.WriteLine("Schedule");
        }
    }
}