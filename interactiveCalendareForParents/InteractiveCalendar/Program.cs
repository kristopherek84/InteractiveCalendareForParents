using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interactiveCalendareForParents;


namespace InteractiveCalendar
{
     class Program
    {
        static Baby _baby;
        static FeedingPlan _feedingPlan;
        static Vaccinations _vaccinationPlan;
        static DoctorsAppointments _doctorsAppointment;
        static Skills _babysSkills;
        public static string name = "Interactive Callendar For Parents Of Newborns and Infint Children";

        public  void initializeBaby(string Name, DateTime birthday)
        {
            _baby = new Baby(Name,birthday);    
        }
        public  string getBabysAge()
        {
            return "The Baby's Name is " + _baby.Name + ", its " + _baby.AgeInMonths + " months old, witch is " + _baby.AgeInWeeks + " weeks old";
        }
        public  string getFeedingPlan()
        {
            _feedingPlan = new FeedingPlan(_baby);
            return _feedingPlan.feeding;
        }
        public  string getVaccinationPlan(bool isVaccinated, bool vaccinatedForFree, bool vaccinCombo)
        {
          
            _vaccinationPlan = new Vaccinations(_baby,isVaccinated,vaccinatedForFree,vaccinCombo);
             return _vaccinationPlan.vaccinationPlan;
        }
        public  string getNearestDoctorsAppointment()
        {
            _doctorsAppointment = new DoctorsAppointments(_baby);
            return _doctorsAppointment.nearestDoctorsAppointment;
        }
        public  string getBabysSkills()
        {
            _babysSkills = new Skills(_baby);
            return _babysSkills.babySkills;
        }

       
    }
}
