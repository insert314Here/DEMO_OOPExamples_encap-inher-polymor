using OOPExamples;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what is the computers name?");
        string compName = Console.ReadLine();
        var comp = new Computer(compName); //using constructor from 'computer.cs'

        Console.WriteLine("Computer Type - " + comp.GetType());

        var isComputer = comp is Computer;

        Console.WriteLine("Is computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.name);

        //these methods run sequentially so the computer is turned on then off as final before writeline
        #region result of protected methods
        //once the methods were PROTECTED and not PUBLIC we could not use the methods in the non-parent class
        //comp.TurnOn();
        //comp.TurnOff();

        #endregion

        comp.TogglePower(); //this call is still public which uses the PROTECTED methods
        Console.WriteLine("Computer is on - "+comp.isOn);
        Console.Read();

    }
}

