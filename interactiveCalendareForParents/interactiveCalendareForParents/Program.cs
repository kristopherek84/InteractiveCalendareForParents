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
                    Console.Write("1) New Baby: /n 2)Quit:");
                    string answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.WriteLine("Enter babys name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter babys birthday: ");
                        DateTime birthday = DateTime.Parse(Console.ReadLine());
                        Child baby = new Child(name, birthday);
                        hasntBeenInitialized = false;
                    }
                    if(answer == "2") { hasntBeenInitialized = false; return; }
                }
                
               

            }

           
        }
    }
}
