//Mattias Kokkonen SUT21
using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Wolf W1 = new Wolf();
            W1._Id = 1;
            W1._Age = 12;
            W1._Gender = "male";
            W1._Name = "Fang";
            W1._Weight = 20;
            W1._Furry = true;
            Chihuahua chi1 = new Chihuahua();
            chi1._Id = 2;
            chi1._Age = 2;
            chi1._Name = "Rex";
            chi1.Eating();
            chi1._Weight = 200;
            Pike P1 = new Pike(20,1,"male","Gammelgädda",20,"Gädda"); 

            Animal A1 = new Animal(2, 12, "Male", "Doggo", 35);

            Animal A2 = new Animal();

            
            Animal An = new Animal();
            WolfHound WH = new WolfHound();
            Huggorm HO1 = new Huggorm();
            Wolf W2 = new Wolf();
            Chihuahua C1 = new Chihuahua(21,1,"Female","Zork",2,false,true);
            Chihuahua C2 = new Chihuahua(22, 5, "Male", "Bork", 2, true, false);

            W2.hunting();
         
            
            P1.makeSound();
            HO1.makeSound();
            WH.makeSound();
            chi1.makeSound();
            W1.makeSound();
            An.makeSound();
            Console.WriteLine();
            A2.PrintAnimal();
            W1.PrintAnimal();
            W2.PrintAnimal();
            P1.PrintAnimal();
            W1.PrintAnimal();
            C1.PrintAnimal();
            C2.PrintAnimal();
            C1.Barks();
            C2.Barks();

       
        }
    }
}
