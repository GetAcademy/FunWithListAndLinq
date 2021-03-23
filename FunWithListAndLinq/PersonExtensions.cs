using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListAndLinq
{
    static class PersonExtensions
    {
        public static bool HasLongName(this Person person)
        {
            return (person.FirstName + person.LastName).Length > 20;
        }
    }
}
