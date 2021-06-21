using System;

namespace ChallengeIfStatements
{
    class Program
    {
        /* Create a user Login System, where the user can first register
         * and then Login. The program should check if the user has entered the
         * correct username and password. Create the program in a way that
         * doesn't require data storage. Use if statements, user input and
         * methods to solve the problem.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please register a username");
            string username = Console.ReadLine();
            Console.WriteLine("Please register a password");
            string password = Console.ReadLine();
            Console.WriteLine("Thank you for registersing");
            Console.WriteLine("----------Login-----------");
            Console.WriteLine("Please enter a valid username");
            if (username.Equals(Console.ReadLine()))
            {
                Console.WriteLine("Please enter a valid password");
                if (password.Equals(Console.ReadLine()))
                {
                    Console.WriteLine("You are now logged in.");
                }
                else
                {
                    Console.WriteLine("Incorrect Password. This terminal will now self destruct");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Username. This terminal will now self destruct");
            }
        }
    }
}
