using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTry
{
     class Car:vehical
    {
        public Car()
        {
            Console.WriteLine("class is wroking properly and color is : ");
            var ok = new List<vehical>();
            var vehi = new vehical();
            Boolean a = true;
            while (a)
            {
                Console.WriteLine("Please Enter Name :");
                vehi.name = Console.ReadLine();

                Console.WriteLine("Please Enter engine :");
                vehi.engine = Console.ReadLine();
               
                ok.Add(vehi);

                Console.WriteLine("Want To Add More ? Y/n");
                if (Console.ReadLine() != "y") { a = false; }

            }

            foreach (var item in ok)
            {
                Console.WriteLine("Name is {0} Where name of Engine is {1}", item.name, item.engine);
            }

            //    k.color = Console.ReadLine("");
            //k.Add(1);
        }
    }
}
