using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace While_loop_authentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plesase enter password");
            string password = "";
            password = Console.ReadLine();
            int number = 4; 
            if (password == "faruk")
            {
                Console.WriteLine(" password match welcome " + password);
                Console.ReadKey();
            }

            while (password != "faruk" && number!=0)
            {
                Console.WriteLine("Wrong password you have {0} times left", number);
                Console.Write("Plesase enter password \t");
                password=Console.ReadLine();
                if (password == "faruk")
                {
                    Console.WriteLine(" password match welcome " + password);
                    Console.ReadKey();
                }
               
                number--;
                


            }
            
        }
    }
}
