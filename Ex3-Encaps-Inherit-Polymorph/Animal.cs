using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_Encaps_Inherit_Polymorph
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public abstract string DoSound();

        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }
        public virtual string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }

    class Horse : Animal
    {
        public string IsFast { get; set; }

        public Horse(string isFast, string name, int age, double weight) : base(name, age, weight)
        {
            IsFast = isFast;
        }

        public override string DoSound()
        {
            return "Gnägg";
        }

        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }

    }

    internal class Dog : Animal
    {
        public bool HasPattern { get; set; }
        public Dog(bool hasPattern, string name, int age, double weight) : base(name, age, weight)
        {
            HasPattern = hasPattern;
        }

        public override string DoSound()
        {
            return "Woff";
        }

        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }

        public string DogString() 
        {

           return "Hunden är människans bästa vän"; 
      
        }
    }
    class HedgeHog : Animal
    {
        public int NoOfSpikes { get; set; }
        public HedgeHog(int noOfSpikes, string name, int age, double weight) : base(name, age, weight)
        {
            NoOfSpikes = noOfSpikes;
        }
        public override string DoSound()
        {
            return "Pip";
        }

        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }
    class Worm : Animal
    {
        public string Color { get; set; }
        public Worm(string color, string name, int age, double weight) : base(name, age, weight)
        {
            Color = color;
        }
        public override string DoSound()
        {
            return "Silence";
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }


    class Wolf : Animal
    {
        public bool IsHungry { get; set; }
        public Wolf(bool isHungry, string name, int age, double weight) : base(name, age, weight)
        {
            IsHungry = isHungry;
        }
        public override string DoSound()
        {
            return "Yyyylll";
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }
    class Bird : Animal
    {
        public string Sound { get; set; }
        public Bird(string sound, string name, int age, double weight) : base(name, age, weight)
        {
            Sound = sound;
        }
        public override string DoSound()
        {
            return "Kvitter";
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }
    class Pelican : Bird
    {
        public int BeakSize { get; set; }
        public Pelican(int beaksize, string sound, string name, int age, double weight) : base(sound, name, age, weight)
        {
            BeakSize = beaksize;
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }

    }

    class Flamingo : Bird
    {
        public int LegHeight { get; set; }
        public Flamingo(int legheight, string sound, string name, int age, double weight) : base(sound, name, age, weight)
        {
            LegHeight = legheight;
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }

    class Swan : Bird
    {
        public string Color { get; set; }

        public Swan(string color, string sound, string name, int age, double weight) : base(sound, name, age, weight)
        {
            Color = color;
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }

    class Wolfman : Wolf, IPerson
    {

        public Wolfman(bool isHungry, string name, int age, double weight) : base(isHungry, name, age, weight)
        {
           
        }

        public string Talk()
        {
            return "Ylar som en man";
        }
        public override string Stats()
        {
            return $"{Name}, {Age}, {Weight}";
        }
    }

}
