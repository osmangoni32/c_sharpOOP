using System;
using System.Collections.Generic;
using System.Xml.Schema;

class Program
{
    static void Main()
    {
       
        var grades=new int[5] {88,66,44,84,65};
        int total = 5;

        // for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Please Enter for {0} position " ,i+1);
        //// grades[i]=Console.ReadLine();
        //}

        foreach (int j in grades) {
            Console.WriteLine(j);

        }
        Console.ReadKey();




    }
    public class StudentInfo
    {
        public int grades { get; set; }
        public string name { get; set; }

    }
    }

