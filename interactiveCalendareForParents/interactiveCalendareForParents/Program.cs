using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasntBeenInitialized=true;
            bool isOn = true;
            while (isOn)
            {
                if (hasntBeenInitialized)
                {
                    Console.WriteLine("Interactive Callendar For Parents Of Newborns and Infint Children");
                    Console.WriteLine("1) New Baby: \n 2)Quit:");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine("Enter babys name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter babys birthday: ");
                        DateTime birthday = DateTime.Parse(Console.ReadLine());
                        Child baby = new Child(name, birthday);
                        hasntBeenInitialized = false;
                        Console.Write("The Baby's Name is {2}, its {0} months old, witch is {1} weeks old",
                            baby.AgeInMonths,baby.AgeInWeeks,baby.Name);
                    }
                    if(answer == "2") { hasntBeenInitialized = false; return; }
                }
                
               

            }

           
        }
    }
}
