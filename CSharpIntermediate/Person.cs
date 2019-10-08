using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Person
    {
        //private DateTime _birthdate;

        //public void SetBirthDate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}

        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}


        //Properties - shorter way of doing above
        public string Name { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.SetBirthDate(new DateTime(1982, 1, 1));
            //Console.WriteLine(person.GetBirthdate());

            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);

        }
    }
}
