using System;
using RunningLine;

namespace Ticker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Running Line";
            Console.ForegroundColor = ConsoleColor.Cyan;
            var rl = new RunningLineCreator();
            rl.Advertisments.Add("In der Kantine gibt es heute das Essen vom Vortag zum halben Preis.");
            rl.Advertisments.Add("Die Fahrradständer sind jetzt kostenpflichtig. Herr Adler hat diese gepachtet und bietet dafür Mietverträge an.");
            rl.Advertisments.Add("--- hier könnte auch Ihre Anzeige stehen ---");

            rl.RunTheLine();

            Console.ReadKey();
        }
    }
}
