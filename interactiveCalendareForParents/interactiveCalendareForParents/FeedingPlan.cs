using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
  
    class FeedingPlan
    {
       private bool _isBreastfead;
        protected Child _child;

        public string feeding = "The Baby should be: ";
        public enum age
        {
            to6months,
            to9months,
            to10months,
            to12months
        };
        public Dictionary<int, string> feedingPlan;

        public FeedingPlan(Child child)
        {
            _child = child;
            _isBreastfead = askIfIsBreastfead();
            
            feedingPlan = new Dictionary<int, string>();
            
            if (_isBreastfead)
                feeding += "Breastfead on demand.\n";
            else
                feeding = "";
          //  populateDictionary();
            choosingFeedingPlan();
           

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

        //private void populateDictionary()
        //{
        //    feedingPlan.Add((int)age.to6months, feeding + " Introducing groucery mousse in Manna gruel once a day.");
        //    feedingPlan.Add((int)age.to9months, feeding + " 1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk. 2.Manna gruel. 3.Juice puree");
        //    feedingPlan.Add((int)age.to10months, feeding + " 1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.2.porridge,biscuits,bread,rusks.3.Purée from fruit or fruit juice");
        //    feedingPlan.Add((int)age.to12months, feeding + " 1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice3-4times a week a whole egg." +
        //         " 2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week)." +
        //              " 3.Purée from fruit or fruit juice");
        //}
        private void choosingFeedingPlan()
        {
            if (_child.AgeInMonths <= 6 && _child.AgeInMonths > 4)
                feeding += "Introducing groucery mousse in Manna gruel once a day.";

            if (_child.AgeInMonths > 6 && _child.AgeInMonths <= 9)
                feeding += "Extending " + _child.Name + " diet should consist of:\n" +
               "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.";

            if (_child.AgeInMonths == 10)
                feeding += "Extending " + _child.Name + " diet should consist of:\n" +
               "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.";

            if (_child.AgeInMonths > 10)
                feeding += "Extending " + _child.Name + " diet should consist of:\n" +
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.";
        }




    }
    }


   

