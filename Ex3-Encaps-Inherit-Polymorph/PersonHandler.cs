using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_Encaps_Inherit_Polymorph
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {  
            pers.Age = age;
        }

        public void GetFullName(Person pers, string fName, string lname)
        {
            pers.Fname = fName;
            pers.Lname = lname;

        }

        public void GetWightAndHeight(Person pers, double height, double weight)
        {
            pers.Height = height;
            pers.Weight = weight;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person
            {
                Age = age,
                Fname = fname,
                Lname = lname,
                Height = height,
                Weigt = weight
            };

            return person;
        }

       


        public void CalculateBMI(Person pers, double height, double weight)
        {
            pers.Height = height;
            pers.Weigt = weight;
            double calcBMI = weight / height;
            double result = Math.Round(calcBMI);
            Console.WriteLine(result);
        }


        public void OldEnoughToDrink(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("Sorry, youre not enough old to drink");
            }
            else
            {
                Console.WriteLine("Let's have adrink");
            }
        }
    }
}
