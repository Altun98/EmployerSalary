using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EmployerSalary.library
{
    public class Security : Departament
    {
        public int Departament_ID;
        public string DepartamentName;
        public int QueueNumber;//novbe sayi 
        //public string SecName;
        //public string SecSurName;
        //public double SecSalary;
       // public bool Queue; // novbesi
        //public int Seniority; //staji ille
        public Security()
        {
            QueueNumber = 1;
        }
        public Security(int _departamentID, string _departamentName)
        {
            Departament_ID = _departamentID;
            DepartamentName = _departamentName;          
        }
        public override double Award(double award)
        {
            if (QueueNumber < 10)
            {
                return award * 0.002;
            }
            if (QueueNumber > 9 && QueueNumber <= 20)
            {
                return award * QueueNumber * (((365) / (QueueNumber * 2)) / 4);
            }
            if (QueueNumber > 21 && QueueNumber <= 30.4)
            {
                return award * QueueNumber * (((365) / (QueueNumber * 2)) / 3);
            }
            else
            {
                return award * QueueNumber * (((365) / (QueueNumber * 2)));
            }
        }

        public override int LeaveAllowance(int vacation)
        {
            return QueueNumber;
        }

        public override double Salary(double salary)
        {

            return salary + salary * QueueNumber * 0.005;

        }
        public override string[] Addition()
        {
            return new string[] { "67 AZN sigorta", $"{QueueNumber/30}{0.00} yemek pulu " };
        }
        public void Print()
        {
            Console.WriteLine($"TEHLUKESIZLIK");
        }
    }
}
