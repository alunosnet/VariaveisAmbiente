using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisAmbiente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string variavel = "temp";
            try
            {
                string temp = Environment.GetEnvironmentVariable(variavel);
                if (string.IsNullOrEmpty(temp))
                    throw new Exception("Erro");
                Console.WriteLine(temp);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Não existe a {variavel}");
            }
        }
    }
}
