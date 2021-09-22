using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    //abstract classes allow for inheritance: this allows new classes to gain additional attributes...abstract cannot be directly insatiated
    abstract class Computer :IPowerOn
    {
        protected IPowerOn powerController;
        protected string _name = "Unknown";

        public bool isOn 
        {
            get
            {
                return powerController.isOn;
            } 
        
        }
        public virtual string name //adding the virtual keyword allows for this property to be overriden
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

            //using INTERFACE implementation
            powerController = new PowerController();
        }

        
       

        
        //the togglepower method protects turnon and off so no other methods can access protected methods
        //concept of encapsulation so certain methods are not initiated during runtime of program
        public virtual void TogglePower()
        {
            powerController.TogglePower();
        }

        //abstract classes allow for inheritance: this allows new classes to gain additional attributes...abstract cannot be directly insatiated

        #region refactored code after creating interfaces
        //protected ensures that computer class has a scope that cannot be accessed by other methods
        // NOTE: no longer needed since these methods are included within an interface
        //      protected void TurnOn()
        //      {
        //          isOn = true;
        //      }

        //      protected void TurnOff()
        //      {
        //           isOn = false;
        //      }

        // from TogglePower Method

        //        if (isOn)
        //            {
        //                TurnOff();
        //    }
        //            else
        //            {
        //                TurnOn();
        //}

        #endregion
    }
}
