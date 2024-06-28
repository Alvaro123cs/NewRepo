using System;

class Program
{
    static void Main()
    {
        string[,] table = new string[,]
        {
            { "c", "x", "valor", "i", "j" },
            { "2", "1", "1", "1-3", "1-4" },
            { "",  "2", "0",  "1" , "1-4" },
            { "",  "3", "1" , ""   , ""   },
            { "4", "1", "1", "2" , "1-2" },
            { "",  "2", "0", ""   , "1-2" },
            { "",  "3", "1", ""   , "1-2" },
            { "",  "4", "0", ""   , "1-2" },
            { "",  "5", ""  , ""   , ""   }
        };

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write("| " + table[i, j].PadRight(10));
            }
            Console.WriteLine(" |");
            Console.WriteLine(new string('-', (table.GetLength(1) * 12) + 3));
        }
    }
}
