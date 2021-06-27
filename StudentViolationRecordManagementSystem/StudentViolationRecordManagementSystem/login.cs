using System;
using System.Collections.Generic;
using System.Text;
using dlLayer;

namespace StudentViolationRecordManagementSystem
{
    class login
    {

        public void loginfunction()
        {


            AdminData admindatacon = new AdminData();
            

            Console.WriteLine("Enter Username");
            string inputAdminUserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string inputAdminPassword = Console.ReadLine();

            if (inputAdminPassword == admindatacon.adminPassword && inputAdminUserName == admindatacon.adminUserName)
            {
                Console.WriteLine("Log in Successful");
                Console.Clear();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input try again");
                loginfunction();
            }



        }
    }
}
