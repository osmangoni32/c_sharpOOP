using System;
using System.Collections.Generic;

namespace ListAutoAddStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2 };//Example of array
            var Grade = new List<int>();//why cant i use Int Garade
            var StudentName = new List<string>();
            bool NewAdd = true;
            while (NewAdd)
            {
                Console.WriteLine("Please Enter Student Name ");
                StudentName.Add(Console.ReadLine());
                Console.WriteLine("Please Enter Student Grade ");
                Grade.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Do You Want To Add Some Other Student: Y/n? ");
                
                if (Console.ReadLine() != "y") 
                {
                    NewAdd = false;
                }
            }
            Console.WriteLine("You Have Enter Total {0}", StudentName.Count);
            for (int i = 0; i < StudentName.Count; i++)
            {
                Console.WriteLine("Student Name :{0} && Marks : {1}", StudentName[i], Grade[i]);

            }


            Console.ReadKey();
        }
    }
}
