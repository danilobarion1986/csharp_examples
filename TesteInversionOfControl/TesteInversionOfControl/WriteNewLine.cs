using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInversionOfControl
{
    class WriteNewLine : IWrite
    {
        public void MyWrite(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
