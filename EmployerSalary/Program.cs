using EmployerSalary.library;

namespace EmployerSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Credit c1 = new Credit(124, "Kredit_mutexesisi-1");
            c1.Crdt_count = 265;
            Credit c2 = new Credit(125, "Kredit_mutexesisi-2");
            c2.Crdt_count = 362;
            EmployeeCredit employeeCredit1 = new EmployeeCredit("Etibar", "Hesenov", 852, c1);
            EmployeeCredit employeeCredit2 = new EmployeeCredit("Hesen", "Memmedov", 942, c2);
            //employeeCredit1.Print();
            //employeeCredit2.Print();
            Security s1 = new Security(225, "Tehluksesilzik-1");
            Security s2 = new Security(226, "Tehlukesizlik-2");
            EmployeeSecurity employeeSecurity1 = new EmployeeSecurity("", "", 545, 26, true,16, 210, s1);
            employeeSecurity1.Print();
        }
    }
}
