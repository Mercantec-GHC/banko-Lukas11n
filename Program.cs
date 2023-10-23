using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    public static string[] numbersPossibleArray { get; private set; }

    static void Main()
    {

        List<int> bankoPlade1 = GenerateBankPlade();
        bankoPlade1.Sort();

        while (true)
        {
            string result = Console.ReadLine();

            bool success = bankoPlade1.Exists(x => x == Convert.ToInt32(result));
            Console.WriteLine($"Nr blev fundet? : {success}");
        }


        //static int GenerateNumberOfRows()
        //{
        //    Random random = new Random();
        //    int randomNumber = random.Next(1, 2);
        //    return randomNumber;
        //}


        List<int> GenerateBankPlade()
        {
            int remainingSpots = 15;
            List<int> returnPlade = new List<int>();
            int[,] numbersPossibleArray = { { 1, 9 }, { 10, 19 }, { 20, 29 }, { 30, 39 }, { 40, 49 }, { 50, 59 }, { 60, 69 }, { 70, 79 }, { 80, 90 } };

            Random random = new Random(); // Create a new random number generator

            // Generate at least one number in each column
            for (int i = 0; i < 9; i++)
            {
                int number = random.Next(numbersPossibleArray[i, 0], numbersPossibleArray[i, 1] + 1);
                returnPlade.Add(number);
                remainingSpots--;
            }

            // Generate the rest of the numbers
            while (remainingSpots > 0)
            {
                int randomColumn = random.Next(0, 9); // Choose a random column
                int number = random.Next(numbersPossibleArray[randomColumn, 0], numbersPossibleArray[randomColumn, 1] + 1);
                returnPlade.Add(number);
                remainingSpots--;
            }

            return returnPlade;
        }

        Console.WriteLine("hvilket nummer et taget?");

        string[] answer = new string[10];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = Console.ReadLine();
        }

        //if (answer = )
        //{

        //}
    }
}

