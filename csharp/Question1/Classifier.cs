using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Classifier
    {
        //Child, Teenager, Adult, Senior
        //Short, Average, Tall.

        const decimal smallHeightMax = 160;
        const decimal averageHeightMax = 180;

        const int childAgeMax = 12;
        const int teenAgeMax = 18;
        const int adultAgeMax = 60;


        public string Height(decimal height)
        {
            if (height < 0) throw new ArgumentOutOfRangeException(nameof(height));

            if (height < smallHeightMax)
            {
                return "Small";
            }
            if(height > averageHeightMax)
            {
                return "Tall";
            }
            
            return "Average";
        }

        public string Age(int age)
        {
            if (age < 0) throw new ArgumentOutOfRangeException(nameof(age));

            if(age < childAgeMax)
            {
                return "Child";
            }

            if (age < teenAgeMax)
            {
                return "Teenager";
            }

            if(age < adultAgeMax)
            {
                return "Adult";
            }

            return "Senior";
        }
    }
}
