namespace F1_Car_Stats
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Enter stats for the first car
            Console.WriteLine("Give stats for the first car\n");

            Console.WriteLine("Enter Team name: ");
            string teamName = Console.ReadLine();

            Console.WriteLine("Enter Horsepower: ");
            int horsePower = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter year of creation: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter constructor location: ");
            string constructor = Console.ReadLine();

            Console.WriteLine("Enter engine type: ");
            string engineType = Console.ReadLine();

            // 2. Enter stats for the second car

            Console.WriteLine("\nGive stats for the second car\n");

            Console.WriteLine("Enter Team name: ");
            string teamName2 = Console.ReadLine();

            Console.WriteLine("Enter Horsepower: ");
            int horsePower2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Weight: ");
            double weight2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter year of creation: ");
            int year2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter constructor location: ");
            string constructor2 = Console.ReadLine();

            Console.WriteLine("Enter engine type: ");
            string engineType2 = Console.ReadLine();

            // 3. Create Stats objects

            Stats formulaSeat1 = new Stats(teamName, horsePower, weight, year, constructor, engineType);

            Stats formulaSeat2 = new Stats(teamName2, horsePower2, weight2, year2, constructor2, engineType2);

            // 4. Call methods to display stats and compare

            Console.WriteLine("\n===== Formula1 Car Stats =====\n" );

            formulaSeat1.StatsSummary();

           formulaSeat2.StatsSummary();

            formulaSeat1.ComparePowerToWeight(formulaSeat2);

            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Press enter to close the program");
            Console.ReadKey();  
        }
    }
}
