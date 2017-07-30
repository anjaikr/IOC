using Microsoft.Practices.Unity;

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
