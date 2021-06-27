using System;
using dlLayer;


namespace blLayer
{
    public class studentManagement
    {

        studentData studentdatacon = new studentData();

        public void viewStudentList() 
        {
            
            
            
            int num = 0;
            for (int i = 0; i < studentdatacon.studentFirstName.Count; i++)
            {
                num++;
                Console.WriteLine("(" + num + ") " + studentdatacon.studentFirstName[i] + ", " + studentdatacon.studentLastName[i]) ;
             
            }
          

        }

        public void viewStudentInfo(int studchoice)
        {

            
            
            studchoice--;

            Console.WriteLine("FirstName: " + studentdatacon.studentFirstName[studchoice]);
            Console.WriteLine("LastName: " + studentdatacon.studentLastName[studchoice]);
            Console.WriteLine("Age: " + studentdatacon.studentAge[studchoice]);
            Console.WriteLine("YearLevel: " + studentdatacon.studentYearLevel[studchoice]);
            Console.WriteLine("Course: " + studentdatacon.studentCourse[studchoice]);
            Console.WriteLine("studentIDNo.: " + studentdatacon.studentIDNo[studchoice]);


        }

        public void addStudentInfo()
        {
            Console.Write("Enter Student's FistName: ");
            studentdatacon.studentFirstName.Add(Console.ReadLine());
            Console.Write("Enter Student's LastName: ");
            studentdatacon.studentLastName.Add(Console.ReadLine());
            Console.Write("Enter Student's Age: ");
            studentdatacon.studentAge.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter Student's Year Level: ");
            studentdatacon.studentYearLevel.Add(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter Student's Course: ");
            studentdatacon.studentCourse.Add(Console.ReadLine());
            Console.Write("Enter Student's IDNo.: ");
            studentdatacon.studentIDNo.Add(Console.ReadLine());

        }

        public void deleteStudentinfo(int studchoice)
        {


            studchoice--;
            
            studentdatacon.studentFirstName.RemoveAt(studchoice);

            studentdatacon.studentLastName.RemoveAt(studchoice);

            studentdatacon.studentAge.RemoveAt(studchoice);

            studentdatacon.studentYearLevel.RemoveAt(studchoice);

            studentdatacon.studentCourse.RemoveAt(studchoice);

            studentdatacon.studentIDNo.RemoveAt(studchoice);



        }

    }
}
