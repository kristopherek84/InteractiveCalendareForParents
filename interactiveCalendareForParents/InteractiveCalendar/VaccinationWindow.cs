using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interactiveCalendareForParents;

namespace InteractiveCalendar
{
    class VaccinationWindow:Vaccinations
    {
        public VaccinationWindow(Baby baby, bool isVaccinated, bool vaccinatedForFree, bool vaccinCombo)
        {
            Baby = baby;
            _isVaccinated = isVaccinated;
            _vaccinatedForFree = vaccinatedForFree;
            _vaccinCombo = vaccinCombo;
            if (!_isVaccinated)
            {
                VaccinationPlan += "Little baby coffins are not cheaper then free vaccines!!!!\n";
                return;
            }
            ChooseVaccinationPlan(baby);
        }

    }
}
