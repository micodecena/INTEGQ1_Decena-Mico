using System;
using blLayer;
using dlLayer;

namespace StudentViolationRecordManagementSystem
{
    class Program
    {

        
        static void Main(string[] args)
        {
            login logincon = new login();
            MainInterface maininterfacecon = new MainInterface();
            logincon.loginfunction();
            maininterfacecon.menuinterface();
        }


       



    }
}
