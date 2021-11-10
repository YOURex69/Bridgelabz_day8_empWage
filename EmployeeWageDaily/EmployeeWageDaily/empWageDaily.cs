using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageDaily
{
    public class empWageDaily
    {
        public void compute()
        {


            const int Present = 1;
            const int Absent = 0;
            const int empWagePerHour = 20;
            int empHours = 0;
            int empDailyWage = 0;
            string empStatus = "";
            Random rand = new Random();
            int check = rand.Next(0, 2);
            if (check == Present)
            {
                empHours += 8;
                empStatus += "Present";
            }
            else if (check == Absent)
            {
                empHours += 0;
                empStatus += "Absent";
            }
            empDailyWage = empHours * empWagePerHour;
            Console.WriteLine("Employee Wage is " + empDailyWage + " & Employee is " + empStatus);


        }
    }
}
