using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS007UzivatelskyVstup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadejte textový řetězec: ");
            //Console.WriteLine("Zadali jste: ", Console.ReadLine());

            Console.WriteLine("Postupně zadejte dvě celá čísla: ");
            Console.WriteLine("Součet čísek je: {0}", Console.ReadLine() + Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Stiskněte libovolnou klávesu.");
            Console.ReadKey(false);
        }
    }
}
