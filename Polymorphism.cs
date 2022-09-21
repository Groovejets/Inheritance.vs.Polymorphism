
namespace Polymorphism.Sample
{
    public interface IAnimal
    {
        string Name { get; }
    }

    public class Dog : IAnimal
    {
        public string Name { get { return "Dog"; } }
    }

    public class Cat : IAnimal
    {
        public string Name { get { return "Cat"; } }
    }
}
