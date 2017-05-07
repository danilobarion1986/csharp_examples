using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteInversionOfControl
{
    class WriteService
    {
        protected IWrite Write { get; private set; }

        // Recebe a interface como parâmetro no construtor, em vez de uma classe concreta.
        // Desta forma, é possível instanciar o serviço com qualquer classe que implemente a interface IWrite. 
        public WriteService(IWrite write)
        {
            if (write == null)
            {
                throw new ArgumentNullException("write");
            }

            this.Write = write;
        }

        public void Escrever(string msg)
        {
            Write.MyWrite(msg);
        }
    }
}
