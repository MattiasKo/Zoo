using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Huggorm : Animal
    {
        public bool _Reptile = true;
        public Huggorm() : this(0, 0, "Uknown", "No name", 0, false) { }

        public Huggorm(int id, int age, string gender, string name, int weight, bool reptile) : base(id, age, gender, name, weight)
        {
            this._Reptile = reptile;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine("Animal Id = {0} Animal Age = {1}  Animal gender {2} Animal Name = {3} Animal Weight = {4} Is a reptile = {5}", this._Id, this._Age, this._Gender, this._Name, this._Weight, this._Reptile);
        }


        public void LayingEggs()
        {
            Console.WriteLine(_Name + " lays eggs.");
        }
        public override void makeSound()
        {
            Console.WriteLine("Reptile is hissing");
        }
    }
}
