using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interactiveCalendareForParents
{
    class Child
    {
        public string Name { get; set; }
        public int AgeInWeeks { get; set; }
        public int AgeInMonths { get; set; }

        Feeding _feedingPlan;

        public Child(string name, DateTime birthday)
        {
            this.Name = name;
            this.AgeInMonths = birthday.Month - DateTime.Now.Month;
            this.AgeInWeeks = AgeInMonths / 4;
        }
    }
}
