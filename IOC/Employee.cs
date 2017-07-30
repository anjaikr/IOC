using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class Employee //: IEmployee
    {


        //[InjectionConstructor]
        //public Employee(ICompany tmpCompany)
        //{
        //    _Company = tmpCompany;
        //}

        //private ICompany _Company;
        [Dependency]
        public ICompany Company { get; set; }



        //[InjectionMethod]
        //public void SetObject(ICompany tmpCompany)
        //{
        //    _Company = tmpCompany;
        //}

        public void DisplaySalary()
        {
            Company.ShowSalary();
        }
    }

}
