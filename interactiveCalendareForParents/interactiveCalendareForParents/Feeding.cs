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

        public string feeding { get; set; }
        //public enum age
        //{
        //    to6months,
        //    to9months,
        //    to10months,
        //    to12months
        //};

        public Feeding(int age, bool breastfeedding)
        {
            _isBreastfead = breastfeedding;
            if(_isBreastfead)
            feeding = "breastfeed on demand";
            if (age <= 6)  
                    feeding += " once a day groucery mousse in Manna gruel";
              
              if(age > 6 && age <= 9)
                    feeding +=
                   " 1.Soup or vegetable mousse with boiled meat, gruel and every-over-day half of yolk. 2.Manna gruel. 3.Juice puree";
                 
             if(age == 10)
                    feeding +=
                   " 1.Vegetable soup with gluten gruel,vegetables with boiled meat,half of yolk everyday.2.porridge,biscuits,bread,rusks.3.Purée from fruit or fruit juice";
                    
               if(age< 10)
                    feeding +=
                 " 1.Vegetable soup with gluten gruel,vegetables with boiled meat,potato,rice3-4times a week a whole egg." +
                 " 2.grain products(porridge,biscuits,bread,rusks) with milk products(cottage cheese, yogurt, kefir-several times a week)." +
                      " 3.Purée from fruit or fruit juice";
               
                   
                    
            }
        }


    }

