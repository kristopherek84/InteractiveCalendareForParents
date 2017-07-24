using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    public class Menu
    {
        static Baby _baby;
        static FeedingPlan _feedingPlan;
        static Vaccinations _vaccinationPlan;
        static DoctorsAppointments _doctorsAppointment;
        static Skills _babysSkills;
        public static string name   = "Interactive Callendar For Parents Of Newborns and Infint Children";


        public static void Startup(bool isOn = true)
        {
            bool stayOn = true;
           
            while (isOn)
            {
                Console.Clear();
                Console.WriteLine(name);
                Console.WriteLine("1) New Baby: \n2) Quit:");
                string answer = Console.ReadLine();
                isOn = evaluateAtSturtup(answer, out stayOn);
                if (stayOn) { KeepRunning(); }
            }
        }
        public static void KeepRunning()
        {
            bool stayOn = true;
            while (stayOn)
            {
                Console.Clear();
                Console.WriteLine(name);
                Console.WriteLine("1) New Baby: \n2) Get Age: \n3) Feedding details: \n4) Vaccination Plan: \n5) Nearest Doctors Appointment: \n6) What can my baby do?: \n7)Quit:");
                string answer = Console.ReadLine();
                stayOn = evaluateAnswer(answer);
            }

        }

        private static bool evaluateAtSturtup(string answer, out bool stayOn)
        {
            stayOn = true;
            bool isOn = true;
            if (answer == "1") { initializeBaby(); isOn = false; }
            if (answer == "2") { isOn = false; stayOn = false; }
           return isOn;

        }

        private static bool evaluateAnswer(string answer)
        {
            bool stayOn = true;
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
                    nearestDoctorsAppointment();
                    break;
                case "4":
                    getVaccinationPlan();
                    break;
                case "6":
                    getBabysSkills();
                break;
                case "7":
                    stayOn = false;
                    break;
                default:
                    break;
            }
           
            return stayOn;
        }

        private static void getBabysSkills()
        {
            _babysSkills = new Skills(_baby);
            Console.WriteLine(_babysSkills.babySkills);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void nearestDoctorsAppointment()
        {
            _doctorsAppointment = new DoctorsAppointments(_baby);
            Console.WriteLine(_doctorsAppointment.nearestDoctorsAppointment);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

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
            catch (FormatException )
            {
                Console.WriteLine("You've entered an invalid date format. Try again.");
                return;
            }
           
            _baby = new Baby(name, birthday);
            
        }
        private static void getBabysAge()
        {
            Console.WriteLine("The Baby's Name is {2}, its {0} months old, witch is {1} weeks old",
                     _baby.AgeInMonths, _baby.AgeInWeeks, _baby.Name);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void readFeedingDetails()
        {
            _feedingPlan = new FeedingPlan(_baby);
            Console.WriteLine(_feedingPlan.feeding);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        private static void getVaccinationPlan()
        {
            _vaccinationPlan = new Vaccinations(_baby);
            Console.WriteLine(_vaccinationPlan.vaccinationPlan);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
    }
}


    

