using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class ECheck
    {/*
         * The Clean Air Act requires vehicles to regularly undergo inspection for exhaust fumes.
         * In the state of Ohio, if it is an even-numbered year, then car models manufactured
         * in even-numbered years need an e-Check. The same goes for odd-numbered years. Vehicles 
         * manufactured within the last four years are exempt. So are historical vehicles that 
         * are 25 years or older. Don't forget some manufacturers release the next model year before
         * the current year is up.
         * 
         * NeedsECheck(2017, 2011) - true
         * NeedsECheck(2016, 2004) - true
         * NeedsECheck(2011, 2012) - false
         * NeedsECheck(2011, 1992) - false
         */
        public bool NeedsECheck(int currentYear, int carModelYear)
        {
            if((currentYear - carModelYear <= 4) || currentYear - carModelYear >=25)
            {
                return false;
            }
            else if((currentYear %2 == 0 && carModelYear %2 == 0) || (currentYear %2 ==1 && carModelYear %2 ==1))
            {
                return true;
            }
            return false;
        }
    }
}
