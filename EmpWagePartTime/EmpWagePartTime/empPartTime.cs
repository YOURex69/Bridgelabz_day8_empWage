using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWagePartTime
{
    public class empPartTime
    {
        public void compute()
        {
            const int Present = 1;
            const int Absent = 0;
            const int PartTime = 2;
            const int empWagePerHour = 20;
            int empHours = 0;
            int empDailyWage = 0;
            string empStatus = "";
            Random rand = new Random();
            int check = rand.Next(0, 3);
            if (check == Present)
            {
                empHours += 8;
                empStatus += "Full-Time";
            }
            else if (check == PartTime)
            {
                empHours += 4;
                empStatus += "Part-Time";
            }
            else
            {
                empHours += 0;
                empStatus += "Absent";
            }
            empDailyWage = empHours * empWagePerHour;
            Console.WriteLine("Employee Wage is " + empDailyWage + " & Employee is " + empStatus);
        }
    }
}
