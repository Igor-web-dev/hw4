using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    class TestFlow : TestTemplate
    {
        // нужен ли конструктор что бы его потом вызвать в TestCase1
        public bool Run()
        {
            // step one -- read from FW register "PortCount" current quantity of ports    this.ReadRegisterValue()
            this.ReadRegisterValue();
            // как использовать этот метод с DataStructureFwRegister

            // step two -- to set speed for port   this.SetPortSpeed()
            this.SetPortSpeed(portNumber,portSpeed);
            // как передать эти значения 1. как параметр 2. задать в конструкторе 

            // step three -- to apply the changes made use the method    this.PerformReset();
            this.PerformReset();
            return true;
        }
    }
}



