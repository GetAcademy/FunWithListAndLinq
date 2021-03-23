using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListAndLinq
{
    class ListDemo
    {
        public static void Run()
        {
            var l = new System.Collections.Generic.List<string>();
            l[2] = "Terje";

            var list = new List<string>();
            while (true)
            {
                var numberStr = Console.ReadLine();
                //var number = Convert.ToInt32(numberStr);
                list.Add(numberStr);
                var description = list.GetDescription();
                Console.WriteLine(description);
            }

            //var numbers = new int[4];
            //var count = 0;
            //while (true)
            //{
            //    var numberStr = Console.ReadLine();
            //    var number = Convert.ToInt32(numberStr);
            //    numbers[count] = number;
            //    count++;
            //    var sum = numbers.Sum();
            //    Console.WriteLine($"Til sammen {count} tall - sum = {sum}");
            //}
        }
    }
}
