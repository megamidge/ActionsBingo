using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionBingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = 5;
            int rows = 5;
            Dictionary<int, string> actions = new Dictionary<int, string>();
            List<Card> cards = new List<Card>();
            string[] names = File.ReadAllLines("Data/F1BingoNames.csv");

            string[] lines = File.ReadAllLines("Data/F1 Bingo - F1 2019.csv");
            foreach (string line in lines)
            {
                string[] split = line.Split(',');
                if (int.TryParse(split[0], out int res))
                {
                    actions.Add(res, split[1]);
                }
            }
            Random rng = new Random();
            foreach(string name in names)
            {
                int[,] card = new int[cols, rows];
                int[] cardFlat = new int[cols * rows];
                for(int i = 0; i < rows * cols; i++)
                {
                    int num = (int)rng.Next(actions.Keys.Min(), actions.Keys.Max() - 1);
                    while (cardFlat.Contains(num))
                    {
                        num = (int)rng.Next(actions.Keys.Min(), actions.Keys.Max() - 1);
                    }
                    cardFlat[i] = num;
                }
                for(int i = 0; i < 5; i++)
                {
                    int randIndex = rng.Next(0, cols * rows);
                    while(cardFlat[randIndex] == -1)
                    {
                        randIndex = rng.Next(0, cols * rows);
                    }
                    cardFlat[randIndex] = -1;
                }
                for(int x = 0; x < cols; x++)
                {
                    for(int y = 0; y < rows; y++)
                    {
                        card[x, y] = cardFlat[cols * x + y];
                    }
                }

                cards.Add(new Card(name, card, rows, cols));
            }
            using (StreamWriter sw = new StreamWriter(File.Open("cards.csv", FileMode.Create)))
            {
                foreach (Card card in cards)
                    sw.WriteLine(card.ToString());
            }
            Console.ReadLine();
        }
    }
}
