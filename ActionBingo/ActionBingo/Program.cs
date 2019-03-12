using System;
using System.Collections.Generic;
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
            int[,] card = new int[cols, rows];
            int[] cardFlat = new int[cols * rows];
            Dictionary<int, string> actions = new Dictionary<int, string>()
            {
                [0]="Hello",
                [1]="World",
                [2]="What",
                [3]="When",
                [4]="Who",
                [5]="How",
                [6]="Seven",
                [7]="Formula 1",
                [8]="Desktop",
                [9]="Weirdos",
                [10]="Kudos",
                [11]="Japan",
                [12]="Bingo",
                [13]="EERC",
                [14]="Taiwan",
                [15]="Russia",
                [16]="Syria",
                [17]="Yeet",
                [18]="Yote",
                [19]="Scrote",
                [20]="Yoda",
                [21]="Han",
                [22]="Hansje",
                [23]="Hansgay",
                [24]="W I L L",
                [25]="F U C K",
                [26]="T H E",
                [27]="S I S T E R",
                [28]="app.config",
                [29]="Elementary",
                [30]="Watson",
                [31]="Renault",
                [32]="Kubica",
                [33]="Stroll",
                [34]="Money",
                [35]="Daddy",
            };
            Random rng = new Random();
            for(int i = 0; i < rows * cols; i++)
            {
                int num = (int)rng.Next(actions.Keys.Min(), actions.Keys.Max() - 1);
                while (cardFlat.Contains(num))
                {
                    num = (int)rng.Next(actions.Keys.Min(), actions.Keys.Max() - 1);
                }
                cardFlat[i] = num;
            }

            for(int x = 0; x < cols; x++)
            {
                for(int y = 0; y < rows; y++)
                {
                    card[x, y] = cardFlat[cols * x + y];
                }
            }

            for(int x = 0; x < cols; x++)
            {
                for(int y = 0; y < rows; y++)
                {
                    Console.Write($"{actions[card[x,y]]}\t\t\t");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
