using System;
using System.Diagnostics;

namespace Sebrae.Atendimento.Infra.CrossCutting.Util
{
    public class Cronometro
    {
        public enum UnidadeTempo
        {
            Segundos,
            Minutos,
            Horas,
            Dias
        }

        private Stopwatch Watch { get; set; }
        private TimeSpan TempoTranscorrido { get; set; }
        
        public Cronometro()
        {
            Watch = new Stopwatch();
        }

        public void Iniciar()
        {
            this.Watch.Start();
        }

        public void Parar()
        {
            this.Watch.Stop();
        }

        public void Reiniciar()
        {
            this.Watch.Restart();
        }

        public void Zerar()
        {
            this.Watch.Reset();
        }

        public TimeSpan ObterTempoTranscorrido()
        {
            return this.Watch.Elapsed;
        }

        public int ObterTempoTranscorrido(UnidadeTempo unidadeTempo)
        {
            var resultado = 0;

            switch (unidadeTempo)
            {
                case UnidadeTempo.Segundos:
                    resultado = this.Watch.Elapsed.Seconds;
                    break;
                case UnidadeTempo.Minutos:
                    resultado = this.Watch.Elapsed.Minutes;
                    break;
                case UnidadeTempo.Horas:
                    resultado = this.Watch.Elapsed.Hours;
                    break;
                case UnidadeTempo.Dias:
                    resultado = this.Watch.Elapsed.Days;
                    break;
                default:
                    break;
            }

            return resultado;
        }

    }
}
