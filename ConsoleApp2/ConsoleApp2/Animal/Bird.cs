using System;

namespace ConsoleApp2.Animal
{
    public  class Bird : FatherAnimal {
        
        Byte lengthWings = 0;
        public Bird(Byte age, String name, Byte lengthWings, String color, String sex, TypeAnimal type)
            :base(age, name, color, sex, type)
        {
            this.type = type;
            this.name = name;
            this.age = age;
            this.lengthWings = lengthWings;
            this.color = color;
            this.sex = sex;
        }

        public string GetInfoBird()
        {
            Console.WriteLine("Птица:");
            GetInfo();
            Console.WriteLine($"lengthWings: {lengthWings}");
            Console.WriteLine();
            return "";
        }

        public override void Move()
        {
            Console.WriteLine("Вжух-вжух");
        }
        
   
        /*<summary>
            вывод полей класса
        <\summary>*/
        public override string ToString()
        {
            return GetInfoBird();
        }
    }
}
