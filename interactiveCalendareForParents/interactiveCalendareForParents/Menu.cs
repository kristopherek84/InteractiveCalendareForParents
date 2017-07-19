using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class Menu
    {
        protected static Child baby;
        protected  static FeedingPlan _feedingPlan;
        //private Vaccinations vaccinationPlan;

        public static void Start()
        {
            
            bool isOn = true;
            while (isOn)
            {
               
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
            Console.WriteLine("Is the baby Breastfead?(Y/N?):");
            string answer2 = Console.ReadLine();
            bool breastfead = false;
            if (answer2 == "Y" || answer2 == "y") { breastfead = true; }
            if (answer2 == "N" || answer2 == "n") { breastfead = false; }
            baby = new Child(name, birthday, breastfead);
            
        }
        private static void getBabysAge()
        {
            Console.WriteLine("The Baby's Name is {2}, its {0} months old, witch is {1} weeks old",
                     baby.AgeInMonths, baby.AgeInWeeks, baby.Name);
            Console.ReadLine();
        }

        private static void readFeedingDetails()
        {
            _feedingPlan = new FeedingPlan(baby);
            Console.WriteLine(_feedingPlan.feeding);
            Console.ReadLine();
        }
        private static void getVaccinationPlan()
        {
            throw new NotImplementedException();
        }
    }
}


    

