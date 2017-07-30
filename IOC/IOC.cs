using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    class IOC
    {
        IBuisnessLogic objKid;
        Person p;

        public void FactoryMethod()
        {
            objKid = new Kid(6, "Ben");
            p = new Person(42, "David")
            {
                REFKID = objKid
            };


        }
        public override string ToString()
        {
            //return base.ToString();
            Console.WriteLine(p);
            Console.WriteLine(objKid);
            return "Displaying using Setter Injection";

        }

    }
}
