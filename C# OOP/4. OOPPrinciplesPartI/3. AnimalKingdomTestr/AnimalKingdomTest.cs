/* Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat 
 * and define useful constructors and methods. Dogs, frogs 
 * and cats are Animals. All animals can produce sound 
 * (specified by the ISound interface). Kittens and tomcats are cats. 
 * All animals are described by age, name and sex. Kittens can be only female and 
 * tomcats can be only male. Each animal produces a specific sound. Create arrays of 
 * different kinds of animals and calculate the average age of each kind 
 * of animal using a static method (you may use LINQ). */

using System;
using System.Collections.Generic;
using System.Linq;
using AnimalKingdom;

class AnimalKingdomTest
{
    static void Main()
    {
        Dog[] dogArray = new Dog[10];
        for (int i = 0; i < 10; i++)
        {
            dogArray[i] = new Dog(0, "Rover", "Male");
            dogArray[i].SetRandomAge(0, 15);
        }
        Console.WriteLine("Average years of the Dog array: " + Animal.AverageAge(dogArray));
        Console.WriteLine();

        Frog[] frogArray = new Frog[10];
        for (int i = 0; i < 10; i++)
        {
            frogArray[i] = new Frog(0, "Wib", "Male");
            frogArray[i].SetRandomAge(0, 20);
        }
        Console.WriteLine("Average years of the Frog array: " + Animal.AverageAge(frogArray));
        Console.WriteLine();

        Cat[] catArray = new Cat[10];
        for (int i = 0; i < 10; i++)
        {
            catArray[i] = new Cat(0, "Whiskers", "Male");
            catArray[i].SetRandomAge(0, 22);
        }
        Console.WriteLine("Average years of the Cat array: " + Animal.AverageAge(catArray));
        Console.WriteLine();

        Tomcat[] tomcatArray = new Tomcat[10];
        for (int i = 0; i < 10; i++)
        {
            tomcatArray[i] = new Tomcat(0, "Tom");
            tomcatArray[i].SetRandomAge(0, 22);
        }
        Console.WriteLine("Average years of the Tomcat array: " + Animal.AverageAge(tomcatArray));
        Console.WriteLine();

        Kitten[] kittenArray = new Kitten[10];
        for (int i = 0; i < 10; i++)
        {
            kittenArray[i] = new Kitten(0, "Felicity");
            kittenArray[i].SetRandomAge(0, 22);
        }
        Console.WriteLine("Average years of the Kitten array: " + Animal.AverageAge(kittenArray));
        Console.WriteLine();
    }
}
