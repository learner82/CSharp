using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4Mich
{
    public class Person//:IEnumerable
    {
         public int Age;
        string Name;
        string Surname;
        double Afm;
        string FatherName;

        public Person(int age, string name, string surname, double afm, string fatherName)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
            this.Afm = afm;
            this.FatherName = fatherName;
        }

        

        public Person Minage(List<Person> persons )
        {
            //persons = new List<Person>();
            
           var query1 = (from p in persons
                     where  p.Age == persons.Min(r => r.Age)
                     select p).FirstOrDefault();
            return query1;

        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
}
