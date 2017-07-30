using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    internal class Kid : IBuisnessLogic
    {
        private int age;
        private string name;

        public Kid()
        {
            //this.age = age;
            //this.name = name;
        }

        public Kid(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public override string ToString()
        {
            var m = this.age.ToString();
            return "KID's age: " + m + " KID's Name: " + this.name;

        }
    }
}
