using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    public class Vaccinations: IBabyInfo
    {
       protected bool _isVaccinated;
        protected bool _vaccinatedForFree;
       protected  bool _vaccinCombo;
        //  bool _extraVaccinatians;
        protected Baby Baby;
        protected string VaccinationPlan = "";

        public Vaccinations()
        {
            
        }
        public Vaccinations(Baby baby)
        {
            Baby = baby;
            AskForVaccinationPlan(Baby);
         
        }
       
        private void AskForVaccinationPlan(Baby baby)
        {
            AskIsVaccinated();
            
            if (!_isVaccinated)
            {
                VaccinationPlan += "Little baby coffins are not cheaper then free vaccines!!!!\n";
                return;
            }
            AskWhatVaccinationPlan();
            ChooseVaccinationPlan(baby);
        }
        
        private void AskIsVaccinated()
        {
            Console.WriteLine("Are You Vaccinating Your baby?(Y/N):");
            string answer2 = Console.ReadLine();
            if (answer2 == "Y" || answer2 == "y") { _isVaccinated = true; }
            else if (answer2 == "N" || answer2 == "n") { _isVaccinated = false;  return; }
            else { Console.WriteLine("Please try again."); AskIsVaccinated(); }
        }
        private void AskWhatVaccinationPlan()
        {
            Console.WriteLine("Are You going with the free vaccination scheme or the paid combo version? (F/P):");
            string answer2 = Console.ReadLine();
            if (answer2 == "F" || answer2 == "f") { _vaccinatedForFree = true; _vaccinCombo = false; }
            else if (answer2 == "P" || answer2 == "p") { _vaccinCombo = true; _vaccinatedForFree = false; }
            else { Console.WriteLine("Please try again."); AskWhatVaccinationPlan(); }
        }
        protected void ChooseVaccinationPlan(Baby baby)
        {
            if (_isVaccinated && !_vaccinCombo && !_vaccinatedForFree)
            {
                VaccinationPlan += "Choose Vaccination Plan. Free or Payed Combo version.";
            }
            else if (baby.AgeInMonths > 5 && baby.AgeInMonths <= 7 && _vaccinatedForFree)
            { VaccinationPlan += "At the age of 7 months " + baby.Name + " shoud receve third dose of vaccine against hepatitis B."; }
            else if (baby.AgeInMonths <= 5 && baby.AgeInMonths > 3 && _vaccinatedForFree)
            {
                VaccinationPlan += "Between the age of 5 and 6 months (6-8weeks after the last vaccination) " +
baby.Name +
" should receve \nthe third dose of vaccination against diphtheria, tetanus and pertussis (DTP) , Haemophilus influenzae type b (Hib) \nand the second against polio.";
            }
            else if ( baby.AgeInMonths == 3 && _vaccinatedForFree)
            {
                VaccinationPlan += "Between the age of 3 and 4 months (6-8weeks after the last vaccination) "
+ baby.Name +
" should receve \nthe second dose of vaccination against diphtheria, tetanus and pertussis (DTP) , Haemophilus influenzae type b (Hib) bacteria and pneumococcal.\n" +
"At this age " + baby.Name + " should receve the first vaccinaton against acute severe childhood paralysis (poliomyelitis).";
            }

            else if (baby.AgeInMonths <= 2 && _vaccinatedForFree)
            {
                VaccinationPlan += "At the age of 2 months "
                   + baby.Name +
                 " should receve \nthe second dose of the hepatitis B vaccine, as well as first against diphtheria, \ntetanus and pertussis (DTP), Haemophilus influenzae type b (Hib) bacteria and pneumococcal.";
            }
            else if (baby.AgeInMonths == 6 && _vaccinCombo)
                VaccinationPlan += baby.Name + " should be past the first year vaccination plan.";
            else if (baby.AgeInMonths <= 5 && _vaccinCombo && baby.AgeInMonths >3) VaccinationPlan += "Between the age of 5 and 6 months " + baby.Name + " should receve the last 6 in 1 vaccine.";
            else if (baby.AgeInMonths == 3 && _vaccinCombo) VaccinationPlan += "Between the age of 3 and 4 months " + baby.Name + " should receve the second 6 in 1 vaccine.";
            else if (baby.AgeInMonths <= 2 && _vaccinCombo) VaccinationPlan += "At the age of 2 months " + baby.Name + " should receve the first 6 in 1 vaccine.";
            else VaccinationPlan += baby.Name + " is older then 7 months and should be past the first year vaccination plan.";
        }

        public string GetBabyInfo()
        {
            return VaccinationPlan;
        }
    }
}
