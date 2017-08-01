using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interactiveCalendareForParents;


namespace InteractiveCalendar
{
     public class Program
    {
       static Baby _baby;
        //public Baby _baby { get; set; }
        static FeedingPlanWindow _feedingPlan;
        static VaccinationWindow _vaccinationPlan;
        static DoctorsAppointments _doctorsAppointment;
        static Skills _babysSkills;
        public static string Name = "Interactive Callendar For Parents Of Newborns and Infint Children";

        public Program(Baby baby)
        {
            _baby = baby;
        }

        public Program()
        {
            
        }
        public void InitializeBaby(string name, DateTime birthday)
        {
            _baby = new Baby(name,birthday);    
        }

        public int GetAge()
        {
            return _baby.AgeInMonths;
        }
        public string GetBabysAge()
        {
            return "The Baby's Name is " + _baby.Name + ", its " + _baby.AgeInMonths + " months old, witch is " + _baby.AgeInWeeks + " weeks old";
        }
        public  string GetFeedingPlan(bool isBreastfead)
        {
            _feedingPlan = new FeedingPlanWindow(_baby, isBreastfead);
            return _feedingPlan.GetBabyInfo();
        }
        public  string GetVaccinationPlan(bool isVaccinated, bool vaccinatedForFree, bool vaccinCombo)
        {
          
            _vaccinationPlan = new VaccinationWindow(_baby,isVaccinated,vaccinatedForFree,vaccinCombo);
             return _vaccinationPlan.GetBabyInfo();
        }
        public  string GetNearestDoctorsAppointment()
        {
            _doctorsAppointment = new DoctorsAppointments(_baby);
            return _doctorsAppointment.GetBabyInfo();
        }
        public  string GetBabysSkills()
        {
            _babysSkills = new Skills(_baby);
            return _babysSkills.GetBabyInfo();
        }

       
    }
}
