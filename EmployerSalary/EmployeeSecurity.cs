using EmployerSalary.library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerSalary
{
    public class EmployeeSecurity
    {
        public string SecName;
        public string SecSurName;
        public double SecSalary;
        public double SecAward;
        public int QueueNumber;
        public bool Queue; // novbesi
        public int Seniority; //staji ille
        public Security EmpSecurity;
        public EmployeeSecurity() { }
        public EmployeeSecurity(string _name, string _surname, double _secSalary, int _qNumber, bool _queue, int _staj, double _award, Security _empSecurity)
        {
            SecName = _name;
            SecSurName = _surname;
            SecSalary = _secSalary;
            QueueNumber = _qNumber;
            Queue = _queue;
            Seniority = _staj;
            EmpSecurity = _empSecurity;
            SecAward = _award;
        }
        public double GetProfit()
        {

            if (!Queue)
            {
                return EmpSecurity.Salary(SecSalary) + EmpSecurity.Award(SecAward);
            }
            else
            {
                return EmpSecurity.Salary(SecSalary) + EmpSecurity.Award(SecAward) * 2;
            }

        }

        public void Print()
        {
            //Console.WriteLine($"Isci ad: {EmployeeName} Soyad:{EmployeeSurname} Maas:{Employee_Salary} Gelir:{GetProfit():0.00} Elave mezuniyyet: {credit.LeaveAllowance(credit.Crdt_count)}");
            //credit.Print();
            //string[] Elv = credit.Addition();
            //for (int i = 0; i < Elv.Length; i++)
            //{
            //    Console.WriteLine(Elv[i]);
            //}
            Console.WriteLine($"Iscinin adi {SecName} Soyaadi {SecSurName} maas:{SecSalary} gelir:{GetProfit():0.00} Elave mezuniyyet gunu {EmpSecurity.LeaveAllowance(EmpSecurity.QueueNumber)}");
            EmpSecurity.Print();
            string[] secElave = EmpSecurity.Addition();
            for (int i = 0; i < secElave.Length; i++)
            {
                Console.WriteLine(secElave[i]+", ");
            }
        }
    }
}
