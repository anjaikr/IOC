using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    internal class Person
    {
        private int age;
        private string name;


        public Person()
        {
            //this.age = age;
            //this.name = name;
            //objKid = new Kid(kidAge, kidName);
        }

        //public Person(int age, string name, int kidAge, string kidName)
        //{
        //    this.age = age;
        //    this.name = name;
        //    objKid = new Kid(kidAge, kidName);
        //}

        //Constructor Injection
        //public Person(int age, string name, IBuisnessLogic objKids)
        //{
        //    this.age = age;
        //    this.name = name;
        //    //objKid = new Kid(kidAge, kidName);
        //    refKids = objKids;
        //}

        //Setter Injection
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
            //objKid = new Kid(kidAge, kidName);
            //refKids = objKids;
        }

        public IBuisnessLogic REFKID { get; set; }


        public override string ToString()
        {
            var m = this.age.ToString();
            //Console.WriteLine(objKid);
            return "Person's age: " + m + " Person's Name: " + this.name;

        }
    }
}
