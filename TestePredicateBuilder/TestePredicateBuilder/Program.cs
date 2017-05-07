using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePredicateBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var LinqDynamic = new TesteLinqDynamic();
            LinqDynamic.MostrarClientesMaioresQue(30);
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            var PredBuilder = new TestePredBuilder();
            PredBuilder.MostrarClientesMaiores30Anos();
            Console.ReadLine();
        }
    }
}
