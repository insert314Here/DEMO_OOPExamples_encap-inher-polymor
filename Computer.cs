using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Computer
    {
        //public property
        public bool isOn { get; private set; }

        protected string _name = "Unknown";

        public string name
        {
            get
            {
                return _name;
            }
            private set //private scope allows the name value to never be changed
            {
                _name = value;
            }
        }

        //creating a constructor...no return type and uses the name of the class
        public Computer(string name) //passes an argument thru the constructor
        {
            this.name = name; //property value being passed into the constructor parameter
            // this key modifier helps to distinguish the property VS the parameter
        }

        
        //protected ensures that computer class has a scope that cannot be accessed by other methods
        protected void TurnOn()
        {
            isOn = true;
        }

        protected void TurnOff()
        {
            isOn = false;
        }

        
        //the togglepower method protects turnon and off so no other methods can access protected methods
        //concept of encapsulation so certain methods are not initiated during runtime of program
        public void TogglePower()
        {
            if (isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
