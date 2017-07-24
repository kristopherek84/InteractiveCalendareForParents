using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    public class Baby
    {
        public string Name { get; set; }
        public int AgeInWeeks { get; set; }
        public int AgeInMonths { get; set; }

       // public bool isBreastfead;
        // Feeding _feedingPlan;

        public Baby(string name, DateTime birthday)
        {
            this.Name = name;
            this.AgeInMonths =(int)DateTime.Now.Subtract(birthday).TotalDays/30;
            this.AgeInWeeks = (int)DateTime.Now.Subtract(birthday).TotalDays / 7;
           // isBreastfead = breastfead;
        }
      
    }
}
