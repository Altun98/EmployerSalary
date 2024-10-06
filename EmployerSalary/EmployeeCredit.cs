using EmployerSalary.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerSalary
{
    public class EmployeeCredit
    {
        public string EmployeeName;
        public string EmployeeSurname;
        public double Employee_Salary;
        public double EmployeeAward;
        public Credit credit;
        public EmployeeCredit()
        {

        }
        public EmployeeCredit(string _employeName, string _employeeSurName, double _empSalary, Credit _credit)
        {
            EmployeeName = _employeName;
            EmployeeSurname = _employeeSurName;
            Employee_Salary = _empSalary;
            credit = _credit;
        }
        public double GetProfit()
        {
            return credit.Salary(Employee_Salary) + credit.Award(EmployeeAward);
        }
        public void Print()
        {
            Console.WriteLine($"Isci ad: {EmployeeName} Soyad:{EmployeeSurname} Maas:{Employee_Salary} Gelir:{GetProfit():0.00} Elave mezuniyyet: {credit.LeaveAllowance(credit.Crdt_count)}");
            credit.Print();
            string[] Elv = credit.Addition();
           for (int i = 0; i < Elv.Length; i++)
            {
                Console.WriteLine(Elv[i]);
            }
        }
    }
}
