using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    interface IPowerOn
    {
        // these were copied from the powercontroller class to implement in an interface
        bool isOn { get; }
        void TogglePower();
    }
}
