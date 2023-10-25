using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class bankoSpil
    {
        List<List<int>> completedRows = new List<List<int>>();

        private bool SaveNumber(List<List<int>> bankoPlade, int Number)
        {
            for (int i = 0; i < bankoPlade.Count; i++)
            {
                if (bankoPlade[i].Contains(Number))
                {
                    completedRows[i].Add(Number);
                }
            }
            return false;
        }

        private bool isBanko1(List<List<int>> bankoPlade)
        {
            foreach (var bankoRow in bankoPlade)
            {
                foreach (var item in completedRows)
                {
                    if (bankoRow.All(item.Contains))
                    {
                        Console.WriteLine("Du har ramt banko på en række på denne plade, ");
                        success2 = true;
                    }

                }
            }
            return false;
        }

        private bool isBanko2(List<List<int>> bankoPlade)
        {
            foreach (var bankoRow in bankoPlade)
            {
                foreach (var item in completedRows)
                {
                    if (bankoRow.All(item.Contains))
                    {
                        if (bankoPlade[0].All(completedRows[0].Contains) && bankoPlade[1].All(completedRows[1].Contains))
                        {
                            Console.WriteLine($"Du har banko på to rækker plade: ");
                            success3 = true;
                        }

                        if (bankoPlade[0].All(completedRows[0].Contains) && bankoPlade[2].All(completedRows[2].Contains))
                        {
                            Console.WriteLine($"Du har banko på to rækker plade: ");
                            success3 = true;
                        }

                        if (bankoPlade[1].All(completedRows[1].Contains) && bankoPlade[2].All(completedRows[2].Contains))
                        {
                            Console.WriteLine($"Du har banko på to rækker plade: ");
                            success3 = true;
                        }
                    }
                }
            }
            return false;
        }

        private bool isBanko3(List<List<int>> bankoPlade)
        {
            foreach (var bankoRow in bankoPlade)
            {
                foreach (var item in completedRows)
                {
                    if (bankoRow.All(item.Contains))
                    {
                        if (bankoPlade[0].All(completedRows[0].Contains) && bankoPlade[1].All(completedRows[1].Contains) && bankoPlade[2].All(completedRows[2].Contains))
                        {
                            Console.WriteLine($"Du har banko på hele pladen plade: ");
                            success4 = true;
                        }
                    }
                }
            }
            return false;
        }

        private bool show(List<List<int>> bankoPlade)
        {
            int s = 1;
            foreach (var bankoRow in bankoPlade)
            {
                foreach (var item in bankoRow)
                {
                    Console.Write($"{item}, ");
                }
                Console.WriteLine();
                if (s % 3 == 0)
                {
                    Console.WriteLine();
                }
                s++;
            }
            return false;
        }
        public bool RunGame()
        {

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


            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });

            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });

            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });

            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });

            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });
            completedRows.Add(new List<int> { });

            show(bankoPlade);

            while (true)
            {
                Console.WriteLine("Skriv et tal");
                string input = Console.ReadLine();
                int tal = Convert.ToInt32(input);
                bool success = SaveNumber(bankoPlade, tal);

                bool success2 = isBanko1(bankoPlade);
                bool success3 = isBanko2(bankoPlade);
                bool success4 = isBanko3(bankoPlade);




            }

        }
    }
}

