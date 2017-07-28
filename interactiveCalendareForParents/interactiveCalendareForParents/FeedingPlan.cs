using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
  
    public class FeedingPlan
    {
       private bool _isBreastfead=true;
        protected Baby _baby;

        public string feeding = "The Baby should be ";
        public enum age
        {
            to6months,
            to9months,
            to10months,
            to12months
        };
        public Dictionary<int, string> feedingPlan;

        public FeedingPlan(Baby baby)
        {
            _baby = baby;
            _isBreastfead = askIfIsBreastfead();

            //feedingPlan = new Dictionary<int, string>();

            if (_isBreastfead)
                feeding += "breastfead on demand.\n";
            else
                feeding += " fead modified milk on demand.";
            
            choosingFeedingPlan();
       }
        public FeedingPlan(Baby baby,bool isBreastfead)
        {
            _baby = baby;
            _isBreastfead = isBreastfead;
            feedingPlan = new Dictionary<int, string>();
            if (_isBreastfead)
                feeding += "breastfead on demand.\n";
            else
                feeding += " fead modified milk on demand.";

            populateDictionary();
            feeding = feedingPlan[_baby.AgeInMonths];
        }

        private bool askIfIsBreastfead()
        {
            Console.WriteLine("Is the baby Breastfead?(Y/N?):");
            string answer2 = Console.ReadLine();
            bool breastfead = false;
            if (answer2 == "Y" || answer2 == "y") { breastfead = true; }
            else if (answer2 == "N" || answer2 == "n") { breastfead = false; }
            return breastfead;
        }

        private void populateDictionary()
        {
            feedingPlan.Add(0, feeding + " ");
            feedingPlan.Add(1, feeding + " ");
            feedingPlan.Add(2, feeding + " ");
            feedingPlan.Add(3, feeding + " ");
            feedingPlan.Add(4, feeding + " Introducing groucery mousse in Manna gruel once a day.");
            feedingPlan.Add(5, feeding + " Introducing groucery mousse in Manna gruel once a day.");
            feedingPlan.Add(6, feeding + " Introducing groucery mousse in Manna gruel once a day.");
            feedingPlan.Add(7, feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
               "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.");
            feedingPlan.Add(8, feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
              "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.");
            feedingPlan.Add(9, feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
              "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.");
            feedingPlan.Add(10, feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
               "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.");
            feedingPlan.Add(11, feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.");
            feedingPlan.Add(12, feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.");
        }
        private void choosingFeedingPlan()
        {
            if (_baby.AgeInMonths <= 6 && _baby.AgeInMonths > 4)
                feeding += "Introducing groucery mousse in Manna gruel once a day.";

            if (_baby.AgeInMonths > 6 && _baby.AgeInMonths <= 9)
               

            if (_baby.AgeInMonths == 10)
                feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
               "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.";

            if (_baby.AgeInMonths > 10)
                feeding += "Extending " + _baby.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice 3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.";
        }




    }
    }


   

