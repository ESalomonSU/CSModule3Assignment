using System;
using System.Collections.Generic;
using CSModule3Assignment.Models;

namespace Module3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersDTO myUser = new UsersDTO();
            myUser.UserNumber = 8007;
            myUser.UserName = "Esteban Salomon";

            Console.WriteLine(myUser.UserNumber);
            Console.WriteLine(myUser.UserName);
        }
    }
}













