using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class Vaccinations
    {
        bool _isVaccinated;
        bool _vaccinatedForFree;
        bool _vaccinCombo;
        bool _extraVaccinatians;

        string VaccinationPlan;

        public Vaccinations()
        {
            askForVaccinationPlan();
            if (!_isVaccinated) VaccinationPlan = "Little baby coffins are not cheaper then free vaccines!!!!";
        }

        private void askForVaccinationPlan()
        {
            Console.WriteLine("Are You Vaccinating Your baby?(Y/N):");
            string answer2 = Console.ReadLine();
            if (answer2 == "Y" || answer2 == "y") { _isVaccinated = true; }
            if (answer2 == "N" || answer2 == "n") { _isVaccinated = false; }
            else Console.WriteLine("Please try again.");
            Console.WriteLine("Are You going with the free vaccination scheme or the paid combo version? (F/P):");
            answer2 = Console.ReadLine();
            if (answer2 == "F" || answer2 == "f") { _isVaccinated = true; }
            if (answer2 == "P" || answer2 == "p") { _isVaccinated = false; }
            else Console.WriteLine("Please try again.");
        }
    }
}
