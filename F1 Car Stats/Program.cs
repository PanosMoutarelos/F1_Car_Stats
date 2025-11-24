namespace F1_Car_Stats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stats formulaSeat1 = new Stats("Mercedes Petronas AMG", 1000, 786.0, 2010, "Brackley, England", "1.6 liter V6 turbo hybrid engine" );
            Stats formulaSeat2 = new Stats("Scuderia Ferrari", 1000, 798.0, 1950, "Maranello, Italy", "1.6-liter V6 turbo hybrid engine");

            Console.WriteLine("===== Formula1 Car Stats =====\n" );

            formulaSeat1.StatsSummary();

           formulaSeat2.StatsSummary();

            formulaSeat1.ComparePowerToWeight(formulaSeat2);

            Console.ReadKey();  
        }
    }
}
