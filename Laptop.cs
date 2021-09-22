using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Laptop:Computer,ISleep
    {
        private ISleep sleepController;
        
        //setting display PROPERTY
        public Display display { get; private set; }

        public bool isSleeping
        {
            get
            {
                return sleepController.isSleeping;
            }
        }

        //after adding Computer inheritance need for constructor
        // name is coming from the abstract class
        // width and height come from the DISPLAY class parameters
        public Laptop(string name, int width, int height) : base(name)
        {
            //width and height param's need to pass through the constructor to instantiate
            // data types have already been declared in the constructor above

            display = new Display(width, height);
            sleepController = new SleepController();

        }

        public void ToggleSleep()
        {
            sleepController.ToggleSleep();
        }
    }
}
