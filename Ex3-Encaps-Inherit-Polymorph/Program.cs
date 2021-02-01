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

                person.SetAge(p, 35);
                person.GetFullName(p, "Susanna", "Sjöberg");
                person.GetWightAndHeight(p, 160.3, 50.5);
                Console.WriteLine("Prints person: ");
                Console.WriteLine($"{p.Fname} {p.Lname} is {p.Age} years old, and are {p.Height} cm tall and weight {p.Weight} kg");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Uppgift 3.2 - ARV
            //F13: Då skulle jag lägga det attributet i Bird klassen eftersom alla fåglar ärver från den klassen. Bird är basklassen för fåglarna
            //F14: Om alla djur behöver ett nytt attribut lägger jag det i Animal klassen eftersom det är basklassen för alla djur.

            //Uppgift 3.3 - Polymorfism
            //F9: Det finns ingen construktor i Dog klassen som heter Horse 
            //F10. Det måste vara en Animal type för att alla klasser ska kunna lgrad tillsammans
            

            Horse horse = new Horse("Very fast", "Thunder", age: 5, weight: 70);
            Dog dog = new Dog(hasPattern: true, "Fido", age: 6, weight: 10);
            
            var animals = new List<Animal>
            {
                horse,
                dog,
                new Worm("black", "Wormy", age: 1, weight: 2),
                new Wolfman(isHungry: true, "Henry", age: 100, weight: 200),
                new Bird("koko", "Gök", 3, 4),
                new Pelican(12, "kakaka", "Peli", age: 3, weight: 5),
                new Swan("Black", "chaaa", "Black swan", age: 5, weight: 8),
                new Dog(hasPattern: true, "Rufs", age: 13, weight: 20),

            };

            Console.WriteLine(" ");
            Console.WriteLine("Prints animals: ");
            
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
                    Console.WriteLine(anim.DogString());
                }

            }

            //F13: Den hämtar listan av hundar går igenom hundklasserna och overridar Stats() metoden i den klassen och skriver ut hundens egenskaper. 
            //F17: Nej jag kommer inte åt Dog metoden i Animals för att animals ärver inte från Dogs. Metoder i Dog klassen är bara tillgänlig för Dog. Dem andra klasserna kommer inte åt den. För att Animal ska få tillgång till Dog metoden har jag castat animal as Dog i animal foreach-loopen, och då får animal tillgång till Dog-metoden. Men vet inte om det är rätt. 
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(hasPattern: true, "Sally", age: 100, weight: 4),
                new Dog(hasPattern: false, "Truls",age: 3, weight: 10),
                new Dog(hasPattern: true, "Rufus", age: 15, weight: 10),

                //new Horse("Fast", "Blixten", 3, 5, false) //Se F9 i uppgift 3.3 
            };

            Console.WriteLine(" ");
            Console.WriteLine("Prints dogs");
            
            foreach (var item in dogs)
            {  
                Console.WriteLine(item.Stats());
                Console.WriteLine(item.DogString()); 
            }

            //Uppgift 3.4 Polymorfism
            //F11: Det är viktigt att behärska Polymorfism eftersom det tillåter en klass att behandlas som en annan klass inom samma arvstruktur. Detta gör att man kan utföra en handling på flera oliak sätt.
            //F12: Men en bra struktur kan man förbättra en kod genom att återanvända samma struktur för flera olika typer.
            //F13:En interface kan inte innehålla fields och man kan inte anända access modifiers i en interface, men det kan man i abstrakta klasser. Allt i en interface är public.  Abtrakta klasser kan inte åstadkomma flera arv men det kan man med Interface.

            List<UseError> useErrors = new List<UseError>()
            {
                new NumericInputError(),
                new TextInputError(),
            };

            Console.WriteLine(" ");
            Console.WriteLine("Prints errors");

            foreach (var error in useErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

        }
    }
}
