using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, password;
            int count = 0;
        start: Console.WriteLine("Enter Username : ");
            name=Console.ReadLine();
            Console.WriteLine("Enter Password : ");
            password=Console.ReadLine();
           if (name == "john" && password=="pass123") {
                Console.WriteLine("Login successful");
            }
            else if(name =="john" && password != "pass123")
            {
                Console.WriteLine("Invalid password");
                count=count+1;
                Console.WriteLine($"Remaining atempts {3 - count}");
            }
            else if(name != "john")
            {
                Console.WriteLine("invalid username");
                count=count+1;
                Console.WriteLine($"Remaining atempts {3 - count}");
            }
            if (name != "john" || password != "pass123")
            {
                if (count < 3)
                {

                    goto start;
                }
                else
                {

                    Console.WriteLine("Login failed");

                }
            }
            Console.ReadKey();
        }
    }
}
