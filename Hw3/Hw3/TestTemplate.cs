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
        public bool SetPortSpeed(byte portNumber,byte portSpeed)  
        {
                                     /*Array ?*/

            PerformReset();
            return true;
        }
        public bool PerformReset()
        {
            return true;
        }
        public byte ReadRegisterValue(DataStructureFwRegister.Registers registerName)
        {
/*                                                                               А какие бывают типы регистров                                                                             */
            return 0;
        }
    }
}
