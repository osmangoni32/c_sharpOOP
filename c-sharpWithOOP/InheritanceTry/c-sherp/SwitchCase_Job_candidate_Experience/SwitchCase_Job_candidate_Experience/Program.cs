using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_Job_candidate_Experience
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to JOB Experiece AI\n How Many Years Of Experience Do you Have :");
            int Experience=int.Parse(Console.ReadLine());
            // Console.WriteLine(" Experience Have :"+Experience);
            switch (Experience)
            {
                case 0:
                    Console.WriteLine("you Have {0} Years of Experience Means\n\t noob :", Experience);
                    break;
                case 1:
                    Console.WriteLine("you Have {0} Years of Experience Means\n\t amature :", Experience);
                    break;
                case 2: Console.WriteLine("you Have {0} Years of Experience Means\n\t Mid Level :", Experience);
                    break;
                default:
                    Console.WriteLine("you Have {0} Years of Experience Means\n\t Expert :" , Experience);
                    break;
            }
            Console.ReadKey();
        }
    }
}
