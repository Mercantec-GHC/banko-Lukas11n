using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string pladeId = "lukas";

            //nested list
            List<List<int>> bankoPlade = new List<List<int>>();

            bankoPlade.Add(new List<int> { 7, 10, 25, 62, 73 });
            bankoPlade.Add(new List<int> { 13, 27, 47, 55, 63 });
            bankoPlade.Add(new List<int> { 15, 36, 56, 77, 89 });

            bankoPlade.Add(new List<int> { 2, 2, 2, 62, 73 });
            bankoPlade.Add(new List<int> { 2, 27, 47, 55, 63 });
            bankoPlade.Add(new List<int> { 2, 36, 56, 77, 89 });

            bankoPlade.Add(new List<int> { 3, 10, 25, 62, 73 });
            bankoPlade.Add(new List<int> { 3, 27, 47, 55, 63 });
            bankoPlade.Add(new List<int> { 3, 36, 56, 77, 89 });

            bankoPlade.Add(new List<int> { 4, 10, 25, 62, 73 });
            bankoPlade.Add(new List<int> { 4, 27, 47, 55, 63 });
            bankoPlade.Add(new List<int> { 4, 36, 56, 77, 89 });

            bankoPlade.Add(new List<int> { 5, 10, 25, 62, 73 });
            bankoPlade.Add(new List<int> { 5, 27, 47, 55, 63 });
            bankoPlade.Add(new List<int> { 5, 36, 56, 77, 89 });


            List<int> completedRow1 = new List<int>();
            List<int> completedRow2 = new List<int>();
            List<int> completedRow3 = new List<int>();


            Console.WriteLine($"Bingo plade ID: {pladeId} ");

            for (int antalPlader = 0; antalPlader < 5; antalPlader++)
            {

                int plus0 = 0;
                int plus1 = 1;
                int plus2 = 2;


                foreach (int d in bankoPlade[plus0])
                {
                    Console.Write($"{d} ");
                }
                Console.WriteLine();
                foreach (int d in bankoPlade[plus1])
                {
                    Console.Write($"{d} ");
                }
                Console.WriteLine();

                foreach (int d in bankoPlade[plus2])
                {
                    Console.Write($"{d} ");
                }
                Console.WriteLine("\n");
                plus0 += 3;
                plus1 += 3;
                plus2 += 3;
            }

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine();
                string userNumber = Console.ReadLine();
                int Number = Convert.ToInt32(userNumber);
                int a = 1;
                int b = 2;
                int c = 3;

                SaveNumber(bankoPlade[0], bankoPlade[1], bankoPlade[2], completedRow1, completedRow2, completedRow3, Number);

                if (bankoPlade[0].All(completedRow1.Contains))
                {

                    Console.WriteLine($"Du har banko på en række {a} plade: {pladeId}");
                    i++;
                }

                if (bankoPlade[1].All(completedRow2.Contains))
                {
                    Console.WriteLine($"Du har banko på en række {b} plade: {pladeId}");
                    i++;
                }

                if (bankoPlade[2].All(completedRow3.Contains))
                {
                    Console.WriteLine($"Du har banko på en række {c} plade: {pladeId}");
                    i++;
                }

            }

            while (i == 1)
            {
                Console.WriteLine();
                string userNumber = Console.ReadLine();
                int Number = Convert.ToInt32(userNumber);
                int a = 1;
                int b = 2;
                int c = 3;

                SaveNumber(bankoPlade[0], bankoPlade[1], bankoPlade[2], completedRow1, completedRow2, completedRow3, Number);

                if (bankoPlade[0].All(completedRow1.Contains) && bankoPlade[1].All(completedRow2.Contains))
                {
                    Console.WriteLine($"Du har banko på række {a} og {b} plade: {pladeId}");
                    i++;
                }

                if (bankoPlade[0].All(completedRow1.Contains) && bankoPlade[2].All(completedRow3.Contains))
                {
                    Console.WriteLine($"Du har banko på række {a} og {c} plade: {pladeId}");
                    i++;
                }

                if (bankoPlade[1].All(completedRow2.Contains) && bankoPlade[2].All(completedRow3.Contains))
                {
                    Console.WriteLine($"Du har banko på række {b} og {c} plade: {pladeId}");
                    i++;
                }
            }

            while (i == 2)
            {
                Console.WriteLine();
                string userNumber = Console.ReadLine();
                int Number = Convert.ToInt32(userNumber);

                SaveNumber(bankoPlade[0], bankoPlade[1], bankoPlade[2], completedRow1, completedRow2, completedRow3, Number);

                if (bankoPlade[0].All(completedRow1.Contains) && bankoPlade[1].All(completedRow2.Contains) && bankoPlade[2].All(completedRow3.Contains))
                {
                    Console.WriteLine($"Du har banko på hele pladen plade: {pladeId}");
                    i++;
                }
            }

            Console.ReadLine();
        }

        private static void SaveNumber(List<int> row1, List<int> row2, List<int> row3, List<int> completedRow1, List<int> completedRow2, List<int> completedRow3, int Number)
        {
            if (row1.Contains(Number))
            {
                completedRow1.Add(Number);
            }
            if (row2.Contains(Number))
            {
                completedRow2.Add(Number);
            }
            if (row3.Contains(Number))
            {
                completedRow3.Add(Number);
            }
        }
    }
}
