using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
           string userName = NameValidation();
            Console.WriteLine("Thanks, " + userName + " please enter a valid email: ");
            string userEmail = EmailValidation();
            Console.WriteLine("Please enter a valid phone number: ");
            string userPhone = PhoneValidation();
            Console.WriteLine("Please enter a valid date: ");
            string userDate = DateValidation();
            Console.ReadLine();           

        }

            public static string NameValidation()
        {
            Console.WriteLine("Please enter a valid Name: ");
            //input
            string userName = Console.ReadLine();
            //processing

            while(!Regex.IsMatch(userName, @"^[A-Z]+[A-z]{2,30}$"))
            {
                Console.WriteLine("Sorry, name is not valid!");
                Console.WriteLine("Enter a valid name: ");
                userName = Console.ReadLine();
            }
            //output
            return userName;
        }
        

        public static string EmailValidation()
        {
            string userEmail = Console.ReadLine();
            
            //input
            while(!Regex.IsMatch(userEmail, @"^([0-9A-z]{5,30})(@[0-9A-z]{5,10}).([0-9A-z]{2,3})$"))
            {
                Console.WriteLine("Sorry, email is not valid!");
                Console.WriteLine("Enter a valid email: ");
                userEmail =Console.ReadLine();
            }
            //processing
            return userEmail;
            
            //output

        }
        public static string PhoneValidation()
        {
            string userPhone = Console.ReadLine();//input

            while(!Regex.IsMatch(userPhone, @"^(\d{3})-(\d{3})-(\d{4})$"))//processing
            {
                Console.WriteLine("Sorry, phone number is not valid!");
                Console.WriteLine("Enter a valid phone number: ");
                userPhone = Console.ReadLine();
            }
            return userPhone; //output
        }

        public static string DateValidation()
        {
            string userDate = Console.ReadLine();

            while(!Regex.IsMatch(userDate, @"^(0[1-9]|1[0 2])[\/](0[1-9]|[12]\d|3[01])[\/](19|20)\d{2}$"))
            {
                Console.WriteLine("Sorry, date is not valid!");
                Console.WriteLine("Enter a valid date: ");
                userDate = Console.ReadLine();
            }
            return userDate; //output
            
        }
        
         
        
    }
    
}
