using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("prasad");
            Console.WriteLine("--------------------");
            validateUser.validateLastName("anduri");
            Console.ReadKey();
        }
    }
}