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
            Console.WriteLine("--------------------------------------");
            validateUser.validateLastName("anduri");
            Console.WriteLine("--------------------------------------");
            validateUser.validateEmailId("prasadanduri@gmail.com");
            Console.WriteLine("---------------------------------------");
            validateUser.validateMobileNumber("9133090222");
            Console.WriteLine("---------------------------------------");
            validateUser.validatePassword("prasad13");
            Console.WriteLine("---------------------------------------");
            validateUser.validateUperCasePassword("Prasad13");
            Console.WriteLine("---------------------------------------");
            validateUser.validateNumericPassword("prasad@13");
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();
        }
    }
}