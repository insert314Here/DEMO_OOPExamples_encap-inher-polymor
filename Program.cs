using OOPExamples;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is the computers name?");
        string compName = Console.ReadLine();

        #region result of changing a class to abstract
        //can no longer use a constructor "new"
        //  var comp = new Computer(compName); //using constructor from 'computer.cs'
        #endregion

        //instantiating the desktop classes that inherits from base class Computer
        //  once CaseType was created in the Desktop child class; need to define the caseType
        //var comp = new Desktop(compName, Desktop.CaseType.Tower);

        var comp = new Laptop(compName, 1024, 768);
        // with the above line: we could use desktop inheritance to apply casetype and is sleeping methods
        // TODO: interface is a better solution?
        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);
        //Console.WriteLine("Computer case type - " + comp.caseType);

        //these methods run sequentially so the computer is turned on then off as final before writeline
        #region result of protected methods
        //once the methods were PROTECTED and not PUBLIC we could not use the methods in the non-parent class
        //comp.TurnOn();
        //comp.TurnOff();

        #endregion

        //this call is still public which uses the PROTECTED methods
        comp.TogglePower(); 
        Console.WriteLine("Computer is on - "+comp.isOn);

        //MODIFICATION: creating a variable to implement the interface ISleep to apply to laptop
        //casting the comp variable to the interface
        // replacing 'comp' with 'sleepingComp' allows the interface to implement itself
        var sleepingComp = comp as ISleep; 
        if (sleepingComp != null)
        {
            sleepingComp.ToggleSleep();
            Console.WriteLine("Computer is sleeping - " + sleepingComp.isSleeping);

            sleepingComp.TogglePower();
            Console.WriteLine("Computer is on - " + sleepingComp.isOn);
        }

        


        Console.Read();

    }
}

