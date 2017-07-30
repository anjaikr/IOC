using Microsoft.Practices.Unity;
using System;

namespace IOC
{
    class Program
    {
        static void Main()
        {
            //var objPerson = new Person(42, "David", 6, "Ben");
            var objIOC = new IOC();
            objIOC.FactoryMethod();
            Console.WriteLine(objIOC);

            var client = new Client();
            client.Start(new Service());


            using (IUnityContainer unitycontainer = new UnityContainer())
            {
                unitycontainer.RegisterType<ICompany, Company>();

                var emp = unitycontainer.Resolve<Employee>();
                emp.DisplaySalary();


                //Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
