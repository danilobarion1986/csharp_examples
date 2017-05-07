using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TesteInversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um kernel padrão para o Ninject
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            // Registra a interface IWrite para corresponder com a classe WriteInline
            kernel.Bind<IWrite>().To<WriteInline>();

            // Instancia a classe WriteService, passando automaticamente no construtor 
            // a classe vinculada no Bind anterior, que implementa a interface IWrite
            var writeService = kernel.Get<WriteService>();
            
            // Escreve utilizando o método da interface, da maneira implementada pela classe concreta
            writeService.Escrever("1ª frase");
            writeService.Escrever("2ª fase");

            Console.WriteLine();
            Console.WriteLine();

            // Refaz o registro da interface IWrite, agora usando a classe WriteNewLine
            kernel.Rebind<IWrite>().To<WriteNewLine>();
            writeService = kernel.Get<WriteService>();
            writeService.Escrever("1ª frase");
            writeService.Escrever("2ª fase");

            #region Erro!
            // O Ninject não permite dar um Bind com alguma classe que não implementa a interface informada 
            // --> kernel.Rebind<IWrite>().To<WriteBlankLine>(); 
            #endregion

            #region Aviso!
            // Se tentar obter o serviço tendo como Bind uma classe que implementa uma interface não esperada pelo serviço,
            // o Ninject mantém o último Bind válido.
            kernel.Rebind<IWriteBlank>().To<WriteBlankLine>();
            writeService = kernel.Get<WriteService>();

            // Desta forma, este escrever irá utilizar o MyWrite da classe WriteNewLine, que foi o último Bind válido.
            writeService.Escrever("Teste!"); 
            #endregion

            Console.ReadLine();

        }
    }
}
