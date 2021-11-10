using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageSwitchCase
{
    public class empSwitch
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

            switch (check)
            {
                case Present:
                    empHours += 8;
                    empStatus += "Full-Time";
                    break;
                case PartTime:
                    empHours += 4;
                    empStatus += "Part-Time";
                    break;
                case Absent:
                    empHours += 0;
                    empStatus += "Absent";
                    break;
            }
            empDailyWage = empHours * empWagePerHour;
            Console.WriteLine("Employee Wage is " + empDailyWage + " & Employee is " + empStatus);
        }
    }
}
