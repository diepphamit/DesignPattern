using FactoryPattern.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Factory
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal createAnimal()
        {
            var random = new Random();
            switch (random.Next(0, 3))
            {
                case 0:
                    return new Dog();
                case 1:
                    return new Cat();
                case 2:
                    return new Dusk();
                default:
                    return null;
            }
        }
    }
}
