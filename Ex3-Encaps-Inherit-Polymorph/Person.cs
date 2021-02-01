using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_Encaps_Inherit_Polymorph
{
    public class Person 
    {
        public Person()
        {

        }

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            Fname = fname;
            Lname = lname;
            Height = height;
            Weigt = weight;
        }


        private int age;
        private string fname;
        private string lname;


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Du måste skriva in en ålder");
                } else
                {
                    age = value;
                }

            }
        }
        public string Fname
        {
            get
            {
                    return fname;
            }
        set
           {
                if (value.Length < 2 || value.Length > 10 || value == null)
                {
                    throw new ArgumentException("Förnamnet måste vara minst 2 ord och max 10 ord");
                }
                else
                {

                    fname = value;
                }
            }
        }
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Efternamnet måste vara minst 3 ord och max 15 ord");
                }
                else
                {

                    lname = value;
                }

            }
        }
        public double Height { get; set; }
        public double Weigt { get; set; }
        public bool Furry { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Weight { get;  set; }

        public string AddPerson()
        {
          
                return Fname;
            
        }

        public string DoSound()
        {
            throw new NotImplementedException();
        }

        public string Talk()
        {
            throw new NotImplementedException();
        }

        //public void AddPerson(int age, string fname, string lname, double height, double weight)
        //{
        //    Console.WriteLine(age);
        //    Console.WriteLine(fname);
        //    Console.WriteLine(lname);
        //    Console.WriteLine(height);
        //    Console.WriteLine(weight);
        //}


    }
}
