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
            

            Horse horse = new Horse("Very fast", "Thunder", 5, 70);
            Dog dog = new Dog(true, "Fido", 6, 10);
            
            var animals = new List<Animal>
            {
                horse,
                dog,
                new Worm("black", "Wormy", 1, 2),
                new Wolfman(true, "Henry", 100, 200),
                new Bird("koko", "Gök", 3, 4),
                new Pelican(12, "kakaka", "Peli", 3, 5),
                new Swan("Black", "chaaa", "Black swan", 5, 8),
                new Dog(true, "Rufs", 13, 20),

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
                    Console.WriteLine(anim.DogString());
                }

            }

            //F13: Den hämtar listan av hundar går igenom hundklasserna och overridar Stats() metoden i den klassen och skriver ut hundens egenskaper. 
            //F17: Nej jag kommer inte åt Dog metoden i Animals för att animals ärver inte från Dogs. Metoder i Dog klassen är bara tillgänlig för Dog. Dem andra klasserna kommer inte åt den. För att Animal ska få tillgång till Dog metoden har jag castat animal as Dog i animal foreach-loopen, och då får animal tillgång till Dog-metoden. Men vet inte om det är rätt. 
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(true, "Sally", 100, 4),
                new Dog(false, "Truls", 3, 10),
                new Dog(true, "Rufus", 15, 10),

                //new Horse("Fast", "Blixten", 3, 5, false) //Se F9 i uppgift 3.3 
            };
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

            foreach (var error in useErrors)
            {
                Console.WriteLine(error.UEMessage());
            }

        }
    }
}
