using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace exception_handling
{

    class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Login("yusuf", "1234567525");
                Console.WriteLine("login success");

            }
            catch (LoginException Exception)
            {
                Console.WriteLine(Exception);
            }
        }

        static void Login(string username, string parola)
        {
            if (username.Contains("Select"))
            {
                throw new LoginException("injection detect");
            }
            if (parola.Length < 8)
                throw new LoginException("Parola 8 karakterden düşük olamaz");
        }
    }
}
