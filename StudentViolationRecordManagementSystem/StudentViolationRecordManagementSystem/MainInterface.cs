using System;
using System.Collections.Generic;
using System.Text;
using blLayer;

namespace StudentViolationRecordManagementSystem
{
    class MainInterface
    {
        studentManagement studentmanagementcon = new studentManagement();
        violationManagement violationmanagementcon = new violationManagement();

        public void mainInterface()
        {

            Console.WriteLine("===================================================");
            Console.WriteLine("            STUDENT VIOLATION RECORD               ");
            Console.WriteLine("               MANGAGEMENT SYSTEM                  ");
            Console.WriteLine("===================================================");
            Console.WriteLine("");
            Console.WriteLine("(1) View violation Record");
            Console.WriteLine("(2) Add Violation");
            Console.WriteLine("(3) Remove Violation");

        }

        public void menuinterface()
        {

           
            
            int limiter = 1;
            for (int i = 0; i < limiter; i++)
            {
                
                mainInterface();
                int choice = Convert.ToInt32(Console.ReadLine());

            
           
                if (choice == 1)
                {
                    Console.Clear();
                    ViewViolationRecord();
                    limiter++;
                }

                else if(choice == 2)
                {
                    Console.Clear();
                    AddViolation();
                    limiter++;

                }

                else if (choice == 3)
                {
                    Console.Clear();
                    removeViolation();
                    limiter++;
                }

                else
                {
                    menuinterface();
                }



            }


        }


        public void ViewViolationRecord()
        {

            studentmanagementcon.viewStudentList();
            Console.WriteLine("");
            Console.WriteLine("Select a student's violation to view");
            int choice = Convert.ToInt32(Console.ReadLine());
            studentmanagementcon.viewStudentInfo(choice);
            violationmanagementcon.viewViolations(choice);
            Console.WriteLine("");
            Console.WriteLine("press (1) to go back");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                Console.Clear();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Invalid Input Returned to ViolatioRecords");
                ViewViolationRecord(); 
            }
        }


        public void AddViolation()
        {

            studentmanagementcon.addStudentInfo();
            violationmanagementcon.addViolation();
            Console.Clear();
            Console.WriteLine("Record Successfully Added");
            Console.WriteLine("");


        }

        public void removeViolation()
        {
            studentmanagementcon.viewStudentList();
            Console.WriteLine("");
            Console.WriteLine("Choose a student Record to be removed");
            int choice = Convert.ToInt32(Console.ReadLine());
            studentmanagementcon.deleteStudentinfo(choice);
            violationmanagementcon.deleteViolation(choice);
            Console.Clear();
            Console.WriteLine("Record Successfully Removed");
            Console.WriteLine("");


        }



    }
}
