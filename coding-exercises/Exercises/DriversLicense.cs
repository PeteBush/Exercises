using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class DriversLicense
    {         /*
         * In order to receive a drivers license in the state of ohio you need to have
         * received 50 hours of supervised driving practice, passed a vision exam, and a written exam
         * if you are under the age of 18 years old. If you are over 18 years of age you need to have
         * passed the vision exam and a written exam. If you are under 16 years old you are not allowed
         * to legally drive.
         * 
         * GetDriversLicense(16, 20, false, true) - false
         * GetDriversLicense(16, 50, false, false) - false
         * GetDriversLicense(16, 50, true, true) - true
         * GetDriversLicense(18, 0, true, true) - true
         * 
         */
        public bool GetDriversLicense(int age, int hoursOfDrivingPractice, bool passedVision, bool passedWritten)
        {

            if(age <16)
            {
                return false;
            }
            if((age >= 16 && age < 18) && hoursOfDrivingPractice >= 50 && passedVision && passedWritten)
            {
                return true;

            }
            if(age >= 18 && passedVision && passedWritten)
            {
                return true;
            }
            return false;
        }
    }
}
