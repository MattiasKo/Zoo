using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Pike : Animal
    {
        public string _FishType;
        public Pike() : this(0,0,"Uknown","No name", 0,"No fishtype given") { }

        public Pike(int id, int age, string gender, string name, int weight,string fishtype): base(id, age, gender, name, weight)
        {
            this._FishType = fishtype;
        }
        public void Swimming()
        {
            Console.WriteLine(_Name+" is swimming in a aquarium");
        }
        public override void makeSound()
        {
            Console.WriteLine("Pike is splashing in the water.");
        }
        public override void  PrintAnimal()
        {
            Console.WriteLine("Animal Id = {0} Animal Age = {1}  Animal gender {2} Animal Name = {3} Animal Weight = {4} FishType = {5}"
                                , this._Id, this._Age, this._Gender, this._Name, this._Weight, this._FishType);
        }
    }
}
