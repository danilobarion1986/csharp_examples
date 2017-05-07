using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace TestePredicateBuilder
{
    public class TesteLinqDynamic
    {
        private List<Clientes> Clientes { get; set; }

        public TesteLinqDynamic()
        {
            this.Clientes = new Clientes().ObterClientes().ToList();
        }

        public void MostrarClientesMaioresQue(int idade)
        {
            try
            {
                string criterio = string.Format("Idade >= {0}", idade);
                
                var lista = Clientes.Where(criterio).OrderBy(x => x.Nome).ToList();

                if (lista != null && lista.Count() > 0)
                {
                    foreach (var item in lista)
                    {
                        Console.WriteLine(item.Nome);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
