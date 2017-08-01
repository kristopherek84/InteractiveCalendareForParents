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
        public static string Name   = "Interactive Callendar For Parents Of Newborns and Infint Children";


        public static void Startup(bool isOn = true)
        {
            bool stayOn = true;
           
            while (isOn)
            {
                Console.Clear();
                Console.WriteLine(Name);
                Console.WriteLine("1) New Baby: \n2) Quit:");
                string answer = Console.ReadLine();
                isOn = EvaluateAtSturtup(answer, out stayOn);
                if (stayOn) { KeepRunning(); }
            }
        }
        public static void KeepRunning()
        {
            bool stayOn = true;
            while (stayOn)
            {
                Console.Clear();
                Console.WriteLine(Name);
                Console.WriteLine("1) New Baby: \n2) Get Age: \n3) Feedding details: \n4) Vaccination Plan: \n5) Nearest Doctors Appointment: \n6) What can my baby do?: \n7)Quit:");
                string answer = Console.ReadLine();
                stayOn = EvaluateAnswer(answer);
            }

        }

        private static bool EvaluateAtSturtup(string answer, out bool stayOn)
        {
            stayOn = true;
            bool isOn = true;
            if (answer == "1") { InitializeBaby(); isOn = false; }
            if (answer == "2") { isOn = false; stayOn = false; }
           return isOn;

        }

        private static bool EvaluateAnswer(string answer)
        {
            bool stayOn = true;
            switch (answer)
            {
                case "1":
                    InitializeBaby();
                    break;
                case "2":
                    GetBabysAge();
                    break;
                case "3":
                    ReadFeedingDetails();
                    break;
                case "5":
                    NearestDoctorsAppointment();
                    break;
                case "4":
                    GetVaccinationPlan();
                    break;
                case "6":
                    GetBabysSkills();
                break;
                case "7":
                    stayOn = false;
                    break;
                default:
                    break;
            }
           
            return stayOn;
        }

        private static void GetBabysSkills()
        {
            _babysSkills = new Skills(_baby);
            Console.WriteLine(_babysSkills.GetBabyInfo());
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void NearestDoctorsAppointment()
        {
            _doctorsAppointment = new DoctorsAppointments(_baby);
            Console.WriteLine(_doctorsAppointment.GetBabyInfo());
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }

        private static void InitializeBaby()
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
        private static void GetBabysAge()
        {
            Console.WriteLine("The Baby's Name is {2}, its {0} months old, witch is {1} weeks old",
                     _baby.AgeInMonths, _baby.AgeInWeeks, _baby.Name);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }

        private static void ReadFeedingDetails()
        {
            _feedingPlan = new FeedingPlan(_baby);
            Console.WriteLine(_feedingPlan.GetBabyInfo());
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        private static void GetVaccinationPlan()
        {
            _vaccinationPlan = new Vaccinations(_baby);
            Console.WriteLine(_vaccinationPlan.GetBabyInfo());
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
    }
}


    

