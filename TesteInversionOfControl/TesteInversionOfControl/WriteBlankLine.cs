using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInversionOfControl
{
    class WriteBlankLine : IWriteBlank
    {
        public void MyWriteBlank()
        {
            Console.WriteLine("");
        }
    }
}
