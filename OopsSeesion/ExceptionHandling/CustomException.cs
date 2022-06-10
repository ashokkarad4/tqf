using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class InvalidPasswordExceotion:SystemException
    {
        public InvalidPasswordExceotion(string msg):base(msg)
        {

        }
    }
 
    class CustomException
    {
        string name;
        long mobile;
        string password;

        public void accept()
        {
            Console.WriteLine("Enter name,mobile,paasword");
            name = Console.ReadLine();
            mobile = long.Parse(Console.ReadLine());
            password = Console.ReadLine();
            validate();
        }

        void validate()
        {
            if(password.Length<5)
            {
                throw new InvalidPasswordExceotion("password length should be greater than 8");
            }
          
        }
       
        static void Main(string[] args)
        {
            CustomException c = new CustomException();
            while(true)
            {
                try
                {
                    c.accept();
                    break;
                }
                catch(InvalidPasswordExceotion e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("main ends");
        }
    }

}
