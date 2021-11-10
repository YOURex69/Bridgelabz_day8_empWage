using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageForMonth
{
    class empWage
    {
        public void computeMonthlyWage()
        {
            const int Present = 1;
            const int Absent = 0;
            const int PartTime = 2;
            const int empWagePerHour = 20;
            const int empWorkingDays = 20;
            int empHours = 0;
            // int empDailyWage = 0;
            int empMonthlyWage = 0;
            int countDays = 0;
            while (countDays < empWorkingDays)
            {
                Random rand = new Random();
                int check = rand.Next(0, 3);

                switch (check)
                {
                    case Present:
                        empHours += 8;

                        break;
                    case PartTime:
                        empHours += 4;

                        break;
                    case Absent:
                        empHours += 0;

                        break;
                }
                countDays++;
            }
            empMonthlyWage = empHours * empWagePerHour;
            Console.WriteLine("Employee Monthly Wage is " + empMonthlyWage);
        }
    }
}
