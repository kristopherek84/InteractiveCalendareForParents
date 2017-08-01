using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interactiveCalendareForParents;

namespace InteractiveCalendar
{
    class FeedingPlanWindow: FeedingPlan
    {
        public Dictionary<int, string> FeedingPlanDictionary;
        

        public FeedingPlanWindow(Baby baby, bool isBreastfead)
        {
            
            Baby = baby;
            IsBreastfead = isBreastfead;
            FeedingPlanDictionary = new Dictionary<int, string>();
            if (IsBreastfead)
                Feeding += "breastfead on demand.\n";
            else
                Feeding += "fead modified milk on demand.";

            PopulateDictionary();
            Feeding = FeedingPlanDictionary[Baby.AgeInMonths];
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
    }
}
