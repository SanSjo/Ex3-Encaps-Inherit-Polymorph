using System;
using System.Collections.Generic;

namespace Ex3_Encaps_Inherit_Polymorph
{
    class Program
    {

        
        static void Main(string[] args)
        {

            try
            {
                //Person person = new Person();
                var person = new PersonHandler();
                var p = new Person();
                //person.CreatePerson = Console.ReadLine();

               // var createPerson = person.CreatePerson(35, "Su", "Sjöberg", 160, 50);
                person.SetAge(p, 35);
                person.GetFullName(p, "Susanna", "Sjöberg");
                person.GetWightAndHeight(p, 160.3, 50.5);

                Console.WriteLine($"{p.Fname} {p.Lname} is {p.Age} years old, and are {p.Height} cm tall and weight {p.Weight} kg");
                
                
               // p.Fname = "s";
               
                //string name = Console.ReadLine();
              //  person.SetAge(35);
               // string age = int.Parse(Console.ReadLine());
               // person.OldEnoughToDrink(35);
                //person.CalculateBMI(163, 50);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Wolfman wolfmenSays = new Wolfman(true, "Harry", 3, 40, true);
            Horse horse = new Horse("Very fast", "Thunder", 5, 70);
            Dog dog = new Dog(true, "Fido", 6, 10);
            //var wolfmenSound = wolfmenSays.DoSound();
            //Console.WriteLine(wolfmenSound);
            Animal animal1 = new Dog(true, "Rufs", 13, 20);
            
            var animals = new List<Animal>
            {
                horse,
                dog,
                new Worm("black", "Wormy", 1, 2),
                //new Wolf(true, "Scar", 20, 50, true),
                new Wolfman(true, "Henry", 100, 200),
                new Bird("koko", "Gök", 3, 4),
                new Pelican(12, "kakaka", "Peli", 3, 5),
                new Swan("Black", "chaaa", "Black swan", 5, 8),
                new Dog(true, "Rufs", 13, 20),
                animal1

        };


            foreach (var animal in animals)
            {

                if (animal is IPerson)
                {
                    IPerson pers = (IPerson)animal;
                    Console.WriteLine(pers.Talk());

                }
                Console.WriteLine(animal.Stats());
                Console.WriteLine(animal.DoSound());

                Dog anim = animal as Dog;
                if (anim != null)
                {
                    Console.WriteLine(anim.StringMethod());

                }

            }

            List<Dog> dogs = new List<Dog>()
            {
                new Dog(true, "Sally", 100, 4),
                new Dog(false, "Truls", 3, 10),

                //new Horse("Fast", "Blixten", 3, 5, false) //Det finns ingen construktor i Dog klassen som heter som heter Horse 
            };
            Console.WriteLine("Prints dogs");
            foreach (var item in dogs)
            {
                
                Console.WriteLine(item.Stats());
                Console.WriteLine(item.StringMethod()); // Mna kommer inte åt StringMethod metoden i Animals för att animals ärevr inte från Dogs

               
            }

            

            List<UseError> useErrors = new List<UseError>()
            {
                new NumericInputError(),
                new TextInputError(),
            };

            foreach (var error in useErrors)
            {
                Console.WriteLine(error.UEMessage());
            }


            
          

            //10. Det måste vara en Animal type för att alla klasser ska kunna lgrad tillsammans

            //try
            //{
            //    Person validFname = (Person)person;
            //    Console.WriteLine("Rätt antal bokstäver");
            //} catch
            //{
            //    Console.WriteLine("Du måste ange minst 2 eller högst 10 bokstäver");
            //}

        }
    }
}
