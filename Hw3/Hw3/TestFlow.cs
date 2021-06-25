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
            ReadRegisterValue(DataStructureFwRegister.Registers.PortCount);
/*            int port = 8;
            if (port == (int)DataStructurePorts.QuantityOfPorts.One || port == (int)DataStructurePorts.QuantityOfPorts.Two);*/
            return true;
        }
    }
}



