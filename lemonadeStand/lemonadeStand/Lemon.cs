using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Lemon
    {
        private int daysOld;

        public Lemon()
        {
            daysOld = 0;
        }

        public bool IsSpoiled()
        {
            if (daysOld == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IncrementDaysOld()
        {
            daysOld++;
        }
    }
}
