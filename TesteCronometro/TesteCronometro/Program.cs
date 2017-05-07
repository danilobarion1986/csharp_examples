using Sebrae.Atendimento.Infra.CrossCutting.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesteCronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            var cron = new Cronometro();

            cron.Iniciar();
            Console.WriteLine("Início em: " + DateTime.Now);
            Thread.Sleep(new TimeSpan(0, 0, 3));
            Console.WriteLine();

            cron.Parar();
            Console.WriteLine("1ª parada: " + cron.ObterTempoTranscorrido(Cronometro.UnidadeTempo.Segundos));
            Console.WriteLine("Final em: " + DateTime.Now);
            Console.WriteLine();

            cron.Iniciar();
            Console.WriteLine("Início em: " + DateTime.Now);
            Thread.Sleep(new TimeSpan(0, 0, 3));
            Console.WriteLine("2ª parada: " + cron.ObterTempoTranscorrido(Cronometro.UnidadeTempo.Segundos));
            Console.WriteLine("Final em: " + DateTime.Now);
            Console.WriteLine();

            cron.Reiniciar();
            Console.WriteLine("Reinício em: " + DateTime.Now);
            Thread.Sleep(new TimeSpan(0, 0, 3));
            Console.WriteLine();

            cron.Parar();
            Console.WriteLine("3ª parada (Reiniciado): " + cron.ObterTempoTranscorrido(Cronometro.UnidadeTempo.Segundos));
            Console.WriteLine("Final em: " + DateTime.Now);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
