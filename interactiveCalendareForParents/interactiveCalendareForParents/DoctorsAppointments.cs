using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    public class DoctorsAppointments: IBabyInfo
    {
        private string _nearestDoctorsAppointment="";
        protected Baby Baby;

        public DoctorsAppointments(Baby baby)
        {
            Baby = baby;
            WhenNearestDoctorsAppointment(baby);
        }

        public string GetBabyInfo()
        {
            return _nearestDoctorsAppointment;
        }

        private void WhenNearestDoctorsAppointment(Baby baby)
        {
           if (baby.AgeInWeeks >=2 && baby.AgeInWeeks < 4)
            {
                _nearestDoctorsAppointment += "The first doctors appointment of " + baby.Name + " should be between the age of 2 and 4 weeks.\n"
                   + "During this visit "+baby.Name+" will be weighed and listened to with a stethoscope. \nThe Doctor will see "+baby.Name+"'s eyes, assess the size of the darkness, measure head circumference, \nexamine the tummy and genitals."
                   + "During this visit the physician \nshould write you an orthopedic referral to see if the child has hip dysplasia."
                    + "\nIf during the examination your doctor will notice any disturbing symptoms, \nhe will refer the referral to another specialist.";  }
           else if (baby.AgeInMonths >= 1 && baby.AgeInMonths<3)
            {
                _nearestDoctorsAppointment += "Before the mandatory vaccination your pediatrician should weight and examine " + baby.Name+" to check for signes of infetion.";
            }
           else if(baby.AgeInMonths >= 3 && baby.AgeInMonths <= 4)
            {
                _nearestDoctorsAppointment += "6 weeks after the last vaccination it's time for the next one. Like before, your pediatrician \nshould weight and examine " + baby.Name + " to check for signes of infetion."
                    +"\nIf he finds signs of allergy, he'll refer you to an allergist";
            }
           else if (baby.AgeInMonths>=5 && baby.AgeInMonths<=6)
            {
                _nearestDoctorsAppointment += "At the age of 6 months a visit to your pediatrician should be made before the third vaccination, \nsame as before. If "
                    +baby.Name+" is poorly gaining weight, \nthe doctor may recommend a blood test to rule out anemia. He'll also assess whether \nadditional doses of vitamin D are needed "
                    + "and might advise you how to expand "+baby.Name+"'s \ndiet to get everything what is needed.";
            }
           else if (baby.AgeInMonths>6 && baby.AgeInMonths <= 12)
            {
                _nearestDoctorsAppointment += "At the age of 12 months the pediatrician will examine "+baby.Name+
             " \nand will measure the scar after vaccination against tuberculosis (the baby was given the first day of life). \nIf it is less than 3 mm, vaccination will need to be repeated.";
            }

        }

        
    }
}
