using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListAndLinq
{
    class IntList
    {
        private int[] _numbers;
        private int _count;

        public IntList()
        {
            _numbers = new int[2];
        }

        public void Add(int number)
        {
            if (_count >= _numbers.Length)
            {
                Console.WriteLine($"Øker kapasitet fra {_numbers.Length} til {_numbers.Length * 2}");
                var newNumbers = new int[_numbers.Length * 2];
                Array.Copy(_numbers, newNumbers, _numbers.Length);
                _numbers = newNumbers;
            }
            _numbers[_count] = number;
            _count++;
        }

        public string GetDescription()
        {
            return $"Til sammen {_count} tall - sum = {_numbers.Sum()}";
        }
    }
}
