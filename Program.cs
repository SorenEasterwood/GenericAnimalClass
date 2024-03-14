namespace GenericAnimalClass
{
    internal class Program
    {
        public class Animal<T>
        {

            public T data;

            public Animal(T data)
            {
                this.data = data;
                Console.WriteLine("Data passed: " + this.data);
            }
            public T getAnimal()
            {
                return data;
            }
        }
        static void Main(string[] args)
        {
            Animal<string> animalName = new Animal<string>("Penguin");
            Animal<string> animalHabitat = new Animal<string>("The cold tundra of Antartica");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(20);
            Console.WriteLine();

            Console.WriteLine("Animal Name: " + animalName.getAnimal());
            Console.WriteLine("Habitat: " + animalHabitat.getAnimal());
            Console.WriteLine("Endangered: " + endangered.getAnimal());
            Console.WriteLine("Extinct: " + extinct.getAnimal());
            Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal());
        }
    }
}
