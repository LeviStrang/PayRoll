using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming_Using_Collections
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double RateofPay { get; set; }
        public double HoursWorked { get; set; }
        //This constructor has all the arguments needed for the list.
        public Employee(int EmpID, string EmpName, double ROPay, double Hours)
        {
            EmployeeID = EmpID;
            EmployeeName = EmpName;
            RateofPay = ROPay;
            HoursWorked = Hours;
        }
        //each one of these variables are made public static to be used as a total of all the lists combined for each area. Having thembe static allows me to use them in the main method.
        public static double RegularPayTotal = 0;
        public static double OverTimeTotal = 0;
        public static double Grandtotal = 0;


        public double CalculateRegPay()
        { //This method allows me to calculate the regular pay for each employ before overtime is added.
            if (HoursWorked <= 40)
            {
                double RegPay = (HoursWorked * RateofPay);
                return RegPay;
            }
            else
            {
                double RegPay = (40 * RateofPay);
                return RegPay;
            }
        }
        public double CalculateOvertime()
        { //This method allows me to calculate all the overtime for each employee in the list. ONLY the over time.
            if (HoursWorked > 40)
            {
                
                double Overtime = (HoursWorked - 40) * (RateofPay * 1.5);
                return Overtime;
            }
            else
            {
                double Overtime = 0;
                return Overtime;
            }
        }


        public double CalculatePay(double RateofPay, double HoursWorked)
        {// this method calculates the total of both the overtime and regular pay for each employee in the list. It also uses += for the total regular pay, total overtime pay and grand total for all the employees.
                if (HoursWorked <= 40)
                {
                    double RegPay = CalculateRegPay();
                    Grandtotal += RegPay;
                    RegularPayTotal += RegPay;
                    return RegPay;

                }

                else
                {
                    //calculating Employees who worked more than 40 hours
                    double OverPay = (CalculateOvertime() + CalculateRegPay());
                    OverTimeTotal += CalculateOvertime();
                    RegularPayTotal += CalculateRegPay();
                    Grandtotal += OverPay;
                    
                    return OverPay;
                }
               
            
        }

    }
}
