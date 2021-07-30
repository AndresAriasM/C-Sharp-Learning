using System;

namespace Logging_System
{
    class Program
    { 
 
        static void Main(string[] args)
        {
            Console.WriteLine("Are you registered on our platform?");
            
            Console.WriteLine("If you answer is YES enter 1");
            Console.WriteLine("If you answer is NO enter 2");
            string Answer = "";

            do
            {
                Answer = Console.ReadLine();
                switch (Answer)
                { 
                    case "1":
                        Console.WriteLine("Now enter your user name");
                        break;

                    case "2":
                        Console.WriteLine("Enter a name for you new account");
                        break;

                    default:
                        Console.WriteLine("You entered a different answer. Please enter 1 or 2");
                        break;

                }

            } while (Answer != "2" && Answer != "1");

            string Name = "";

            do
            {
                Name = Console.ReadLine();

                if (Name != "")
                {
                    Console.WriteLine("Welcome " + Name);
                }

                else
                {
                    Console.WriteLine("You did not enter a user name");
                }

            } while (Name == "");

            string Status = "";
         
            
           while (Status != "user" && Status != "admin")
            {
                Console.WriteLine("Are you an user or admin?");
                Status = Console.ReadLine();

                if (Status.Equals("user"))
                {
                    Console.WriteLine("Nice! You have been registered as a user.");
                }

                else if (Status.Equals("admin"))
                {
                    Console.WriteLine("Nice! You have been registered as admin");
                }

                else
                {
                    Console.WriteLine("You entered an invalid value");
                }

            }

            Console.WriteLine("That's all! Thank you");

            Console.Read();
        }
        
    }
}
