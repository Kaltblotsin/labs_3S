using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_4.Classes
{
    abstract public class Worker : Person
    {
        public Worker()
        {
            Console.WriteLine("Worker class created!");
        }
        private string name;
        public string? workPlace;
        public virtual string getName() { return this.name; }
        public virtual void _setName(string name) { this.name = name; }
        public abstract string getWorkPlace();
    }
}