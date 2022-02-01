using System;

namespace TrabalhandoComDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DateTime Principais Métodos
            Console.WriteLine("Principais Métodos DateTime.");

            var now = DateTime.Now;
            var today = DateTime.Today;

            var threeDaysAgo = now.AddDays(-3);
            var threeDaysAgoOther = today.AddDays(-3);
            var sixMonthLater = today.AddMonths(6);
            var twoYearsLater = today.AddYears(2);

            var shortDate = now.ToShortDateString();
            var longDate = now.ToLongDateString();

            var shortTime = now.ToShortTimeString();
            var longTime = now.ToLongTimeString();

            var date = now.Date;
            var day = now.Day;
            var month = now.Month;
            var year = now.Year;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;

            var dayOfWeek = now.DayOfWeek;

            if ( dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("É sim de semana!");
            }

            var dayOfYear = now.DayOfYear;

            #endregion

            #region DateTime Formatação

            var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "y" };

            Console.WriteLine();
            Console.WriteLine("Formatação DateTime.");
            Console.WriteLine();

            foreach( var format in formats)
            {
                Console.WriteLine("Data no Formato {0}: {1}", format, now.ToString(format));
                //Console.WriteLine($"Data no Formato {format}: {now.ToString(format)}");
                //Console.WriteLine("Data no Formato " + format + ": " + now.ToString(format));
            }

            Console.WriteLine();
            Console.WriteLine("Diferentes maneiras de formatar manualamente.");
            Console.WriteLine();

            Console.WriteLine($"Data no Formato d: {now:d}");
            Console.WriteLine($"Data no Formato MM-dd-yyyy: {now:MM-dd-yyyy}");
            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");

            #endregion
        }
    }
}
