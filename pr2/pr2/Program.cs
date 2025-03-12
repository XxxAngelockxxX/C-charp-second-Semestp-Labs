namespace pr2
{
    internal class Program
    {
        static void Main()
        {
            Dog dog = new Dog(2);
            dog.Voice();
            Animal animal = dog;
            animal.Voice();
            //Cat cat = new Cat(1);
            //Animal animal = cat;
            //if(animal is Dog dog1)
            //{
            //    Console.WriteLine("this is Dog");
            //    dog.Voice();
            //}
            //Dog? dog2 = animal as Dog;
            //dog2?.Voice();
        }
    }
}
