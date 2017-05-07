using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInversionOfControl
{
    class WriteInline : IWrite
    {
        public void MyWrite(string msg)
        {
            Console.Write(msg);
        }
    }
}
