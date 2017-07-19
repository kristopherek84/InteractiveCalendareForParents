using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
  
    class Feeding
    {
       private bool _isBreastfead;

        public string feeding = "The Baby should be: ";
        public enum age
        {
            to6months,
            to9months,
            to10months,
            to12months
        };
        public Dictionary<int, string> feedingPlan; 
        
        public Feeding(Child child)
        {
            _isBreastfead = child.isBreastfead;
            feedingPlan = new Dictionary<int, string>();
           
            if (_isBreastfead)
            feeding += "Breastfead on demand.\n";
            //feedingPlan.Add(6, feeding + " once a day groucery mousse in Manna gruel");
            //feedingPlan.Add(7, feeding + " 1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk. 2.Manna gruel. 3.Juice puree");
            //feedingPlan.Add(10, feeding + " 1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.2.porridge,biscuits,bread,rusks.3.Purée from fruit or fruit juice");
            //feedingPlan.Add(11, feeding + " 1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice3-4times a week a whole egg." +
            //     " 2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week)." +
            //          " 3.Purée from fruit or fruit juice");
            if (child.AgeInMonths <= 6)            
                feeding += "Introducing groucery mousse in Manna gruel once a day.";

            if (child.AgeInMonths > 6 && child.AgeInMonths <= 9)
                feeding +=
               "1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk.\n2.Manna gruel. \n3.Juice puree.";

            if (child.AgeInMonths == 10)
                feeding +=
               "1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.\n2.porridge,biscuits,bread,rusks.\n3.Purée from fruit or fruit juice.";

            if (child.AgeInMonths > 10)
                feeding +=
             "1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice3-4times a week a whole egg.\n" +
             "2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week).\n" +
                  "3.Purée from fruit or fruit juice.";



        }
    }


    }

