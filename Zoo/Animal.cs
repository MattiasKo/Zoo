using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal
    {
        public int _Id;
        public int _Age;
        public string _Gender ;
        public string _Name ;
        public int _Weight ;

        public Animal() : this(0,0," No age given "," No name given ",0) { }
        public Animal(int id,int age, string gender, string name, int weight)
        {
            this._Id = id;
            this._Age = age;
            this._Gender = gender;
            this._Name = name;
            this._Weight = weight;
        }
        public void Sleeping()
        {
            Console.WriteLine(_Name+" is sleeping.");
        }
        public void Eating()
        {
            Console.WriteLine(_Name+ " ss eating.");
        }
        public void Roaming()
        {
            Console.WriteLine(_Name+" is roaming around.");
        }
        public virtual void makeSound()
        {
            Console.WriteLine(_Name + " Animal is not making any sound.");
        }
        public virtual void PrintAnimal()
        {
            Console.WriteLine("Animal Id = {0} Animal Age = {1}  Animal gender {2} Animal Name = {3} Animal Weight = {4}",this._Id ,this._Age,this._Gender,this._Name,this._Weight);
        }
        
    }
}
