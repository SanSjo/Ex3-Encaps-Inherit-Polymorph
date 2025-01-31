﻿using System;
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
            return $"{Name} is {Age} years old and weight {Weight} kg. This horse is {IsFast}";
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
            return $"{Name} is {Age} years old and weight {Weight} kg. The dog has patterns: {HasPattern}. ";
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
            return $"{Name} is {Age} years old and have {NoOfSpikes} spikes and weight {Weight} kg";
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
            return $"{Name} have the color {Color} and is {Age} years old. The worms weight is {Weight} kg";
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
            return $"{Name} is {Age} years old and weight {Weight} kg. Is the wolf hungry: {IsHungry}";        }
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
            return $"{Name} is {Age} years old and weight {Weight} kg, making {Sound} sounds";
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
            return $"{Name} is {Age} years old, have {BeakSize} cm beak size and weight {Weight} kg";
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
            return $"{Name} is {Age} years old have {LegHeight} cm long legs and weight {Weight} kg.";
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
            return $"{Name} is {Age} years old have a {Color} color and weight {Weight} kg.";
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
            return $"{Name} is {Age} years old and weight {Weight} kg. Is Hungry? {IsHungry} ";
        }
    }

}
