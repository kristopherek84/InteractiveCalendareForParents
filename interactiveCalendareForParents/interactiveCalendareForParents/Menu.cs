using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class Menu
    {
        protected static Child _baby;
        protected  static FeedingPlan _feedingPlan;
        protected static Vaccinations _vaccinationPlan;

        public static void Start()
        {
            
            bool isOn = true;
            while (isOn)
            {
                Console.Clear();
               Console.WriteLine("Interactive Callendar For Parents Of Newborns and Infint Children");
               Console.WriteLine("1) New Baby: \n2) Get Age: \n3) Feedding details: \n4) Vaccination Plan: \n5) Quit:");
               string answer = Console.ReadLine();
               isOn= evaluateAnswer(answer);
                
            }
        }
             private static bool evaluateAnswer(string answer)
        {
            bool isOn = true;
            switch (answer)
            {
                case "1":
                    initializeBaby();
                    break;
                case "2":
                    getBabysAge();
                    break;
                case "3":
                    readFeedingDetails();
                    break;
                case "5":
                    isOn = false;
                    break;
                case "4":
                    getVaccinationPlan();
                    break;
                default:
                    break;
            }
            //if (answer == "1")
            //{
            //    initializeBaby();

            //}
            //else if (answer == "2") { isOn = false; }
            return isOn;
        }

       

        private static void initializeBaby()
        {
            Console.WriteLine("Enter babys name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter babys birthday(year.month.day): ");
            DateTime birthday;
            try
            {
                 birthday = DateTime.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You've entered an invalid date format. Try again.");
                return;
            }
           
            _baby = new Child(name, birthday);
            
        }
        private static void getBabysAge()
        {
            Console.WriteLine("The Baby's Name is {2}, its {0} months old, witch is {1} weeks old",
                     _baby.AgeInMonths, _baby.AgeInWeeks, _baby.Name);
            Console.ReadLine();
        }

        private static void readFeedingDetails()
        {
            _feedingPlan = new FeedingPlan(_baby);
            Console.WriteLine(_feedingPlan.feeding);
            Console.ReadLine();
        }
        private static void getVaccinationPlan()
        {
            _vaccinationPlan = new Vaccinations(_baby);
            Console.WriteLine(_vaccinationPlan.vaccinationPlan);

        }
    }
}


    

