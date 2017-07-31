using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
  
    public class FeedingPlan
    {
      private bool _isBreastfead;
        protected Baby Baby;

        public string Feeding = "The Baby should be ";
        public enum Age
        {
            to6months,
            to9months,
            to10months,
            to12months
        };
        public Dictionary<int, string> FeedingPlanDictionary;

        public FeedingPlan(Baby baby)
        {
            Baby = baby;
            _isBreastfead = AskIfIsBreastfead();

            if (_isBreastfead)
                Feeding += "breastfead on demand.\n";
            else
                Feeding += "fead modified milk on demand.";
            
            ChoosingFeedingPlan();
       }
        public FeedingPlan(Baby baby,bool isBreastfead)
        {
            Baby = baby;
            _isBreastfead = isBreastfead;
            FeedingPlanDictionary = new Dictionary<int, string>();
            if (_isBreastfead)
                Feeding += "breastfead on demand.\n";
            else
                Feeding += "fead modified milk on demand.";

            PopulateDictionary();
            Feeding = FeedingPlanDictionary[Baby.AgeInMonths];
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

        private void PopulateDictionary()
        {
            FeedingPlanDictionary.Add(0, Feeding + "");
            FeedingPlanDictionary.Add(1, Feeding + "");
            FeedingPlanDictionary.Add(2, Feeding + "");
            FeedingPlanDictionary.Add(3, Feeding + "");
            FeedingPlanDictionary.Add(4, Feeding + " Introducing groucery mousse in Manna gruel once a day.");
            FeedingPlanDictionary.Add(5, Feeding + " Introducing groucery mousse in Manna gruel once a day.");
            FeedingPlanDictionary.Add(6, Feeding + " Introducing groucery mousse in Manna gruel once a day.");
            FeedingPlanDictionary.Add(7, Feeding + "Extending " + Baby.Name + " diet should consist of:\n" +
               "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.");
            FeedingPlanDictionary.Add(8, Feeding + "Extending " + Baby.Name + " diet should consist of:\n" +
              "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.");
            FeedingPlanDictionary.Add(9, Feeding + "Extending " + Baby.Name + " diet should consist of:\n" +
              "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.");
            FeedingPlanDictionary.Add(10, Feeding + "Extending " + Baby.Name + " diet should consist of:\n" +
               "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.");
            FeedingPlanDictionary.Add(11, Feeding + "Extending " + Baby.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.");
            FeedingPlanDictionary.Add(12, Feeding + "Extending " + Baby.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.");
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




    }
    }


   

