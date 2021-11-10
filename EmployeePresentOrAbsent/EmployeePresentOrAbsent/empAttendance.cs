using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePresentOrAbsent
{
    class empAttendance
    {
        public void compute()
        {

            const int Present = 1;
            const int Absent = 0;

            Random rand = new Random();
            int check = rand.Next(0, 2);
            if (check == Present)
            {
                Console.WriteLine("Employee is Present");
            }
            else if (check == Absent)
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
