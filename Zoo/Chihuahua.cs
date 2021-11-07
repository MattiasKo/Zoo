using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Chihuahua: Wolf
    {
        public bool _InPurse = true;
        public Chihuahua() : this(0, 0, "Uknown", "No name", 0, false, true) { }

        public Chihuahua(int id, int age, string gender, string name, int weight, bool furry, bool inpurse) : base(id, age, gender, name, weight, furry)
        {
            this._InPurse = inpurse;
        }

        public void Barks()
        {
            if (this._InPurse == true)
            {
                Console.WriteLine(_Name + " barks like crazy inside of a Purse");
            }
            else
            {
                Console.WriteLine(_Name + " doesnt dare to bark.");
            }
        }
        public override void PrintAnimal()
        {
            Console.WriteLine("Animal Id = {0} Animal Age = {1}  Animal gender {2} Animal Name = {3} Animal Weight = {4} Wolfhound is furry = {5} Is the Chihuahua is a purse = {6}", this._Id, this._Age, this._Gender, this._Name, this._Weight, this._Furry, this._InPurse);
        }
        public override void makeSound()
        {
            Console.WriteLine("Chihuahua skreeks");
        }
    }
}
