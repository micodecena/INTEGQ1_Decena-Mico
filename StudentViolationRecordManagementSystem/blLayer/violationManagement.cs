using System;
using System.Collections.Generic;
using System.Text;
using dlLayer;
namespace blLayer
{
    public class violationManagement
    {
        ViolationData viocon = new ViolationData();

        public void viewViolations(int viochoice)
        {

            viochoice--;
            Console.WriteLine("Violation: " + viocon.studentViolation[viochoice]);
            Console.WriteLine("ViolationCount: " + viocon.studentViolationCount[viochoice]);

        }

        public void addViolation()
        {
            Console.Write("Enter Student's Violation: ");
            viocon.studentViolation.Add(Console.ReadLine());
            viocon.studentViolationCount.Add(1);

        }

        public void deleteViolation(int viochoice)
        {
            viochoice--;
            viocon.studentViolation.RemoveAt(viochoice);
            viocon.studentViolationCount.RemoveAt(viochoice);



        }


        



    }
}
