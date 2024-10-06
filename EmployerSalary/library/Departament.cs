using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerSalary.library
{
    public abstract class Departament
    {
        public abstract double Salary(double salary);
        public abstract double Award(double award);
        public abstract int LeaveAllowance(int vacation);
        public virtual string[] Addition()
        {
            // Bu sahee elave odenisler nezerde tutulub. 
            return new string[] { "10 azn sigorta" };
        }
    }
}
