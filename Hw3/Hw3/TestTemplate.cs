using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class TestTemplate
    {
        /*        Как хранить данные про скорость*/
        private List<byte> portsNumbers;
        private List<byte> portsSpeeds;
        public bool SetPortSpeed(byte portNumber,byte portSpeed)  
        {
            this.portsNumbers.Add(portNumber);
            this.portsSpeeds.Add(portSpeed);

            return true;
        }
        public bool PerformReset()
        {
            return true;
        }
        public byte ReadRegisterValue()
        {
            return 0;
        }
    }
}
