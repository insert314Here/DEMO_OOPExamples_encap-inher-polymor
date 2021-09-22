using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    interface ISleep
    {
        //NOTE: public keyword is not needed within an interface b/c it is assumed to be public
        bool isSleeping { get;}
        void ToggleSleep();

    }
}
