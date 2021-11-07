using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class WolfHound : Wolf
    {
        public bool _Hunting = false;

        public WolfHound() : this(0, 0, "Uknown", "No name", 0, true, true) { }

        public WolfHound(int id, int age, string gender, string name, int weight, bool furry, bool hunting) : base(id, age, gender, name, weight, furry)
        {
            this._Hunting = hunting;
        }
        public void IsHunting()
        {
            if (this._Hunting == true)
            {
                Console.WriteLine(this._Name + " is trying to hunt in the zoo");
            }
            else
            {
                Console.WriteLine(this._Name + " is not hunting at the moment.");
            }
        }
        public override void PrintAnimal()
        {
            Console.WriteLine("Animal Id = {0} Animal Age = {1}  Animal gender {2} Animal Name = {3} Animal Weight = {4} Wolfhound is furry = {5} Is the Wolfhound is hunting = {6}", this._Id, this._Age, this._Gender, this._Name, this._Weight, this._Furry, this._Hunting);
        }
        public override void makeSound()
        {
            Console.WriteLine("Wolfhound howls");
        }
    }
}
