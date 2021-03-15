using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress DefaultAdress = new Adress();
            Console.WriteLine("Приветсвутю, Это практика номер 1");
            Console.WriteLine("Введите город");
            string gorod = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите улицу");
            string ulica = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите НомерДома");
            string NomDoma = Convert.ToString(Console.ReadLine());
            Console.Clear();
            DefaultAdress.ToString();
            DefaultAdress.setGorod(gorod);
            DefaultAdress.setUlica(ulica);
            DefaultAdress.setNomDoma(NomDoma);
            DefaultAdress.ToString();
            Console.ReadKey();
        }
    }
}
