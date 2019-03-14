using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionBingo
{
    public class Card
    {
        public string name;
        public int[,] grid;
        private int rows;
        private int cols;
        public Card(string name, int[,] grid, int rows, int cols)
        {
            this.name = name;
            this.grid = new int[rows, cols];
            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    this.grid[x, y] = grid[x, y];

            this.rows = rows;
            this.cols = cols;
        }
        public override string ToString()
        {
            string ret = $"{name},";
            for (int x = 0; x < cols; x++)
                for (int y = 0; y < rows; y++)
                    ret += $"{grid[x, y]},";
            return ret;
        }
    }
    class CardTest
    {
        public Base101 id;
        public int[,] grid;
        public CardTest(int[,] grid)
        {

        }
    }

    class Base101
    {
        private static Dictionary<int, char> base101Symbols = new Dictionary<int, char>()
        {
            [0] = '0',
            [1] = '1',
            [2] = '2',
            [3] = '3',
            [4] = '4',
            [5] = '5',
            [6] = '6',
            [7] = '7',
            [8] = '8',
            [9] = '9',
            [10] = 'A',
            [11] = 'B',
            [12] = 'C',
[13] = 'D',
[14] = 'E',
[15] = 'F',
[16] = 'G',
[17] = 'H',
[18] = 'I',
[19] = 'J',
[20] = 'K',
[21] = 'L',
[22] = 'M',
[23] = 'N',
[24] = 'O',
[25] = 'P',
[26] = 'Q',
[27] = 'R',
[28] = 'S',
[29] = 'T',
[30] = 'U',
[31] = 'V',
[32] = 'W',
[33] = 'X',
[34] = 'Y',
[35] = 'Z',
[36] = 'a',
[37] = 'b',
[38] = 'c',
[39] = 'd',
[40] = 'e',
[41] = 'f',
[42] = 'g',
[43] = 'h',
[44] = 'j',
[45] = 'i',
[46] = 'k',
[47] = 'l',
[48] = 'm',
[49] = 'n',
[50] = 'o',
[51] = 'p',
[52] = 'q',
[53] = 'r',
[54] = 's',
[55] = 't',
[56] = 'u',
[57] = 'v',
[58] = 'w',
[59] = 'x',
[60] = 'y',
[61] = 'z',
[62] = 'Ç',
[63] = 'ü',
[64] = 'é',
[65] = 'â',
[66] = 'ä',
[67] = 'à',
[68] = 'å',
[69] = 'ç',
[70] = 'ê',
[71] = 'ë',
[72] = 'è',
[73] = 'ï',
[74] = 'î',
[75] = 'ì',
[76] = 'Ä',
[77] = 'Å',
[78] = 'É',
[79] = 'æ',
[80] = 'Æ',
[81] = 'ô',
[82] = 'ö',
[83] ='ò',
[84]='û',
[85]='ù',
[86]='ÿ',
[87]='Ö',
[88]='Ü',
[89]='¢',
[90]='¥',
[91]='₧',
[92]='ƒ',
[93]='á',
[94]='í',
[95]='ó',
[96]='ú',
[97]='ñ',
[98]='Ñ',
[99]='ª',
[100]='º',
        };
        public static Base101 NumsToBase101(int[] grid)
        {
            int cells = grid.Length;
            List<char> chars = new List<char>();
            for(int i = cells-1; i >= 0; i--)
            {
                chars.Add(base101Symbols[grid[i]]);
            }
            Console.WriteLine(string.Join("", chars));
            return null;
        }
    }
}
