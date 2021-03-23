using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListAndLinq
{
    class FloatList
    {
        private float[] _numbers;
        private int _count;

        public FloatList()
        {
            _numbers = new float[2];
        }

        public void Add(float number)
        {
            if (_count >= _numbers.Length)
            {
                Console.WriteLine($"Øker kapasitet fra {_numbers.Length} til {_numbers.Length * 2}");
                var newNumbers = new float[_numbers.Length * 2];
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
