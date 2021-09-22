using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class PowerController : IPowerOn
    {
        //public property
        public bool isOn { get; private set; }

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
        public virtual void TogglePower()
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
