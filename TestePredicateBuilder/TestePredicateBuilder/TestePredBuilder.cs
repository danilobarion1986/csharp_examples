using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePredicateBuilder
{
    public class TestePredBuilder
    {
        private List<Clientes> Clientes { get; set; }

        public TestePredBuilder()
        {
            this.Clientes = new Clientes().ObterClientes().ToList();
        }

        public void MostrarClientesMaiores30Anos()
        {
            try
            {
                var predicate = PredicateBuilder.False<Clientes>();
                predicate = predicate.Or(c => c.Idade >= 30);
                
                var lista = this.Clientes.AsQueryable<Clientes>().Where(predicate);

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
