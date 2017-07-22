using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class DoctorsAppointments
    {
        public string nearestDoctorsAppointment="";
        protected Baby _baby;

        public DoctorsAppointments(Baby baby)
        {
            _baby = baby;
            whenNearestDoctorsAppointment(baby);
        }

        private void whenNearestDoctorsAppointment(Baby baby)
        {
           if (baby.AgeInWeeks >= 2 && baby.AgeInWeeks < 4)
            {
                nearestDoctorsAppointment += "The first doctors appointment of " + baby.Name + " should be between the age of 2 and 4 weeks."
                   + "During this visit "+baby.Name+" will be weighed and listened to with a stethoscope. The Doctor will see "+baby.Name+"'s eyes, assess the size of the darkness, measure head circumference, examine the tummy and genitals."
                   + "During this visit the physician should write you an orthopedic referral to see if the child has hip dysplasia."
                    + "If during the examination your doctor will notice any disturbing symptoms, he will refer the referral to another specialist.";  }
           else if (baby.AgeInMonths <= 2)
            {
                nearestDoctorsAppointment += "Before the mandatory vaccination your pediatrician should weight and examine " + baby.Name+" to check for signes of infetion.";
            }
           else if(baby.AgeInMonths >= 3 && baby.AgeInMonths <= 4)
            {
                nearestDoctorsAppointment += "6 weeks after the last vaccination it's time for the next one. Like before, your pediatrician should weight and examine " + baby.Name + " to check for signes of infetion."
                    +"If he finds signs of allergy, he'll refer you to an allergist";
            }
           else if (baby.AgeInMonths>=5 && baby.AgeInMonths<=6)
            {
                nearestDoctorsAppointment += "At the age of 6 months a visit to your pediatrician should be made before the third vaccination, same as before. If "
                    +baby.Name+" is poorly gaining weight, the doctor may recommend a blood test to rule out anemia. He'll also assess whether additional doses of vitamin D are needed "
                    + "and might advise you how to expand "+baby.Name+"'s diet to get everything what is needed.";
            }
           else if (baby.AgeInMonths>6 && baby.AgeInMonths <= 12)
            {
                nearestDoctorsAppointment += "At the age of 12 months the pediatrician will examine "+baby.Name+
             " and will measure the scar after vaccination against tuberculosis (the baby was given the first day of life). If it is less than 3 mm, vaccination will need to be repeated.";
            }

        }

        
    }
}
