using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class TestFlow : TestTemplate
    {
        public bool Run()
        {
            // step one -- read from FW register "PortCount" current quantity of ports    this.ReadRegisterValue()
            ReadRegisterValue(DataStructureFwRegister.Registers.PortCount);
            return true;
        }
    }
}



