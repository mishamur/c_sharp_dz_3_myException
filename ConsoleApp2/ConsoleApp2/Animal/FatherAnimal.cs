using System;


namespace ConsoleApp2.Animal
{
    public class FatherAnimal : IAnimalInterface
    {
        protected TypeAnimal type;

        //поля класса
        protected String sex = "none";
        protected Byte age = 0;
        protected String name = "none";
        protected String color = "none";
        protected Byte TravelSpeed = 0; // км.ч
        public FatherAnimal(Byte age, String name, String color, String sex, TypeAnimal type)
        {
            this.color = color;
            this.sex = sex;
            this.age = age;
            this.name = name;
            this.type = type;
        }
        
        public String getName()
        {
            return this.name;
        }

        public Byte getAge()
        {
            return this.age;
        }

        virtual public void Move() { }

        //выводит поля класса
        public virtual void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"color: {color}");
            Console.WriteLine($"sex: {sex}");
          //  Console.WriteLine($"type: {type}");
        }
    }
}
