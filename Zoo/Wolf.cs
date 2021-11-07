using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Wolf : Animal 
    {
        public bool _Furry = true;
        public Wolf() : this(0, 0, "Uknown", "No name", 0, false) { }

        public Wolf(int id, int age, string gender, string name, int weight, bool furry) : base(id, age, gender, name, weight)
        {
            this._Furry = furry;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine("Animal Id = {0} Animal Age = {1}  Animal gender {2} Animal Name = {3} Animal Weight = {4} Is the Wolf furry = {5}", this._Id, this._Age, this._Gender, this._Name, this._Weight, this._Furry);
        }
        public void hunting()
        {
            Console.WriteLine(_Name + " is hunting");
        }
        public override void makeSound()
        {
            Console.WriteLine("Wolf growl");
        }
    }
}
