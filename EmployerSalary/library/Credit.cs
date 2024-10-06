using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerSalary.library
{
    public class Credit : Departament
    {
        public int Departament_ID;
        public string DepartamentName;
        public int Crdt_count;
        public Credit()
        {
            Crdt_count = 10;
        }
        public Credit(int _departamentID,string _departamentName)
        {
            Departament_ID = _departamentID;
            DepartamentName = _departamentName;
        }
        public override double Award(double award)
        {
            //mukafat =mukafat * kredit sayi *0.001
            return award  * Crdt_count * 0.001;
        }

        public override int LeaveAllowance(int vacation)
        {
            // mezuniyyet =kredit sayi /100;
            return Crdt_count / 100;
        }

        public override double Salary(double salary)
        {
            //massi= massi (kredit sayi * massi )*0.003;
            return salary + salary * Crdt_count * 0.003;            
        }
        public override string[] Addition()
        {
            return new string[] { "10 AZN sigorta", $"{Crdt_count / 10}{0.00} yemek pulu" };  
        }

        public void Print()
        {
            Console.WriteLine($"Kredit Mutexesisi ");
        }
    }
}
