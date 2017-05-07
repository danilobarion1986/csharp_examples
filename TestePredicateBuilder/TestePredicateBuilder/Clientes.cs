using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePredicateBuilder
{
    public class Clientes
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public IEnumerable<Clientes> ObterClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();

            listaClientes.Add(new Clientes() { Idade = 29, Nome = "Danilo", Cidade = "São Paulo" });
            listaClientes.Add(new Clientes() { Idade = 31, Nome = "Alessandra", Cidade = "São Paulo" });
            listaClientes.Add(new Clientes() { Idade = 65, Nome = "Aldaiza", Cidade = "Santos" });
            listaClientes.Add(new Clientes() { Idade = 54, Nome = "Luiz Carlos", Cidade = "João Pessoa" });
            listaClientes.Add(new Clientes() { Idade = 68, Nome = "Nice", Cidade = "Santos" });
            listaClientes.Add(new Clientes() { Idade = 71, Nome = "Hamilton", Cidade = "São Caetano do Sul" });
            listaClientes.Add(new Clientes() { Idade = 28, Nome = "Eugênio", Cidade = "São Carlos" });

            return listaClientes;
        }
    }
}

