using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteExcelDna.RAE.WCF.Funcionario;

namespace TesteExcelDna
{
    public static class MyUDFs
    {
        [ExcelFunction(Description = "My first .NET function")]
        public static string HelloDna(string name)
        {
            return "Hello " + name;
        }

        [ExcelFunction(Description = "My second .NET function")]
        public static int Random([ExcelArgument(Name = "Mínimo")] int min = 0, [ExcelArgument(Name = "Máximo")] int max = 0)
        {
            var rnd = new Random();

            if (max < min)
            {
                return 0;
            }
            else
            {
                var randomInt = rnd.Next(min, max);
                return randomInt;
            }
        }

        [ExcelFunction(Description = "Get people info")]
        public static string FuncionarioPorLocal([ExcelArgument(Name = "Id Local")] int id)
        {
            try
            {
                FuncionarioClient _funcClient = new FuncionarioClient();

                if (id > 0)
                {
                    var func = _funcClient.BuscarFuncionariosPorLocal(new int[] { id }).FirstOrDefault();

                    if (func != null)
                    {
                        var retorno = string.Format("{0}|{1}|{2}|{3}|{4}",
                        func.Chapa,
                        func.CPF,
                        func.Nome,
                        (string.IsNullOrEmpty(func.Telefone) ? "Sem Telefone" : func.Telefone),
                        (func.SituacaoFuncionario ? "Ativo" : "Inativo"));

                        return retorno;
                    }
                    else
                    {
                        return "Nenhum resultado encontrado!";
                    }
                }
                else
                {
                    return "Id Inválido!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
