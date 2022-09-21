using Polymorphism.Sample;
using Inheritance.Sample;
using System;

//
//Help fdrom StackOverflow here: https://stackoverflow.com/questions/7325518/whats-the-difference-between-inheritance-and-polymorphism
//

public class Test
{
    static void Main()
    {
        //DEMO: Polymorphism
        PolymorphismDemo();

        //DEMO: Inheritance
        //InheritanceDemo();

        Console.WriteLine("Press any key to end the demo..");
        Console.ReadKey();
    }

    private static void PolymorphismDemo()
    {
        IAnimal animal = new Dog();
        IAnimal animalTwo = new Cat();

        Console.WriteLine(animal.Name);
        Console.WriteLine(animalTwo.Name);
    }

    private static void InheritanceDemo()
    {
        InheritanceSampleSubClass subClass = new InheritanceSampleSubClass();

        // Inheritence
        Console.WriteLine(subClass.HelloMessage);
    }

}
