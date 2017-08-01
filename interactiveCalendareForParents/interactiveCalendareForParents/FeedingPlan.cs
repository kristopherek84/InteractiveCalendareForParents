using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
  
    public class FeedingPlan: IBabyInfo
    {
      protected bool IsBreastfead;
        protected Baby Baby;

        protected string Feeding = "The Baby should be ";


        public FeedingPlan()
        {
            
        }
        public FeedingPlan(Baby baby)
        {
            Baby = baby;
            IsBreastfead = AskIfIsBreastfead();

            if (IsBreastfead)
                Feeding += "breastfead on demand.\n";
            else
                Feeding += "fead modified milk on demand.";
            
            ChoosingFeedingPlan();
       }
     

        private bool AskIfIsBreastfead()
        {
            Console.WriteLine("Is the baby Breastfead?(Y/N?):");
            string answer2 = Console.ReadLine();
            bool breastfead = false;
            if (answer2 == "Y" || answer2 == "y") { breastfead = true; }
            else if (answer2 == "N" || answer2 == "n") { breastfead = false; }
            return breastfead;
        }

       
        private void ChoosingFeedingPlan()
        {
            if (Baby.AgeInMonths <= 6 && Baby.AgeInMonths > 4)
            { Feeding += "Introducing groucery mousse in Manna gruel once a day.";
                return;
            }

            if (Baby.AgeInMonths > 6 && Baby.AgeInMonths <= 9)
            {
                Feeding += "Extending " + Baby.Name + " diet should consist of:\n" +
                 "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.";
                return;
            }

            if (Baby.AgeInMonths == 10)
            {
                Feeding += "Extending " + Baby.Name + " diet should consist of:\n" +
                 "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.";
                return;
            }


            if (Baby.AgeInMonths > 10)
            {
                Feeding += "Extending " + Baby.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.";
                return;
            }
        }

        public string GetBabyInfo()
        {
            return Feeding;
        }
    }
    }


   

