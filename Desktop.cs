﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    //created desktop class to extend the abstract class in computer.cs

    //desktop class would be considered a child class

    class Desktop : Computer //inheriting from the computer class
    {
        public enum CaseType
        {
            Tower,
            MiniTower
        }

        //creating a property that is specific to the desktop class
        public bool isSleeping { get; private set; }


        //creating a property to access the desktop CaseType
        public CaseType caseType { get; private set; }

        //name needed to be set to virtual in order to override in "computer.cs"
        public override string name
        {
            get
            {
                //adding logice for the getter
                return base.name + " " + caseType;
                //base keyword allowed access to the computer class (parent class) to get the name property
                // needed because of the override
            }
        
        
        } 


        public Desktop(string name, CaseType caseType ) : base(name) //uses name and passes it through the base class "Computer"
        {
            //this is another constructor
            this.caseType = caseType;
        }

        //adding logice specific to only the desktop class

        public void ToggleSleep()
        {
            if (!isOn)
            {
                return;
            }

            isSleeping = !isSleeping; //if above is true, this sets to false and vice versa
        }

        public override void TogglePower()
        {
            if (isSleeping)
            {
                return;
            }

            base.TogglePower();
        }
    }
}
