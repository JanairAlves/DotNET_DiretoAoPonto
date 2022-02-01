using System;

namespace TratandoExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tratando Exceções
            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
                var formatException= int.Parse(seteString);
                var argumentNullException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Format Exception {exception.Message}");
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine($"Argument Null Exception {exception.Message}");
            }
            catch (OverflowException exception)
            {
                Console.WriteLine($"Overflow Exception {exception.Message}");
            }
            finally
            {
                Console.WriteLine("Este código é executado sempre.");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
