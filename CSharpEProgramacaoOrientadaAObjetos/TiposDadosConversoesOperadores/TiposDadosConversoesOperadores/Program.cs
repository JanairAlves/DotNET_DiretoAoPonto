using System;

namespace TiposDadosConversoesOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Tipos de dados

            int numeroInt = 10;
            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 1232123123132312;
            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double maiorNumeroDouble = double.MaxValue;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Janair Alves";
            char letra = 'J';

            DateTime entradaEmpresa = new DateTime(2021, 1, 1);
            TimeSpan QuantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;

            #endregion

            Console.WriteLine();

            #region Conversoes

            int notaAluno = 10;

            //  Conversão implícita.
            double notaAlunoDouble = notaAluno;

            // Conversão explícita.
            int numeroDoudleComoInt = (int)notaAlunoDouble;

            // Conversão utilizando a classe Convert.
            string notaString = "10A+";
            //int notaConvert = Convert.ToInt32(notaString);

            // Conversão utilizando o método Parse.
            //int notaParse = int.Parse(notaString);

            // Conversão utilizando Parse com validação do dado que será convertido.
            if (int.TryParse(notaString, out int notaTryParse))
            {
                Console.WriteLine("Número informado é válido.");

            }
            else
            {
                Console.WriteLine("Número informado é inválido.");
            }

            #endregion

            Console.WriteLine();

            #region Operadores Aritméticos

            // Unários
            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++);
            Console.WriteLine(numeroOperador--);

            Console.WriteLine(++numeroOperador);
            Console.WriteLine(--numeroOperador);

            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));
            Console.WriteLine(+(-numeroOperador));
            Console.WriteLine(+numeroOperador);

            // Binários
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;
            
            var multiplos = (4 * 5) / 10;


            Console.WriteLine(4 > 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(6 >= 5);

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);

            #endregion

            Console.WriteLine();

            #region Operadores de igualdade

            Console.WriteLine(5 == 5);
            Console.WriteLine(5 == 4);

            Console.WriteLine(5 != 5);
            Console.WriteLine(4 != 5);

            #endregion

            Console.WriteLine();

            #region Operadores lógicos

            var minhaNota = 4;
            var ultimoAno = true;

            if(minhaNota >= 7 && ultimoAno)
            {
                Console.WriteLine("Aprovado e termino o curso, parabéns!");
            }

            if(minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado!");
            }

            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            #endregion

        }
    }
}
