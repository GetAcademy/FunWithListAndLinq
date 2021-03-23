using System;
using System.Linq;
using FunWithListAndLinq;
using Person = FunWithListAndLinq.Person;

namespace FunWithListAndLinq2
{
    class LinqDemo
    {
        public static void Run()
        {
            var people = new System.Collections.Generic.List<Person>()
            {
                new Person("Per", "Hansen", 1980),
                new Person("Pål", "Hansen", 1981),
                new Person("Espen", "Olsen", 1982),
            };

            var first1 = people[0];
            var first2 = people.First();
            var first3 = people.FirstOrDefault();
            var last1a = people[people.Count - 1];
            var last1b = people[^1];
            var last2 = people.Last();
            var last3 = people.LastOrDefault();

            var hasLongName = first1.HasLongName();

            var sum = people.Sum(p => p.GetAge());
            var sum2 = people.Sum(GetAge);
            var max = people.Max(p => p.GetAge());
            var min = people.Min(p => p.GetAge());
            var average = people.Average(p => p.GetAge());

            var peopleCount = people.Count();
            /*
             * .First() - .FirstOrDefault() - .Last() - .LastOrDefault()
             * .Single() - .SingleOrDefault()
             * .Count()
             * .Sum()
             * .Where() => JS filter()
             * .Select() => JS map()
             * .Aggregate() => JS reduce()
             * method syntax vs query syntax
             */

            var hansens = people.Where(p => p.LastName == "Hansen");
            //foreach (var person in hansens)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.BirthYear})");
            //}

            Func<Person, bool> myFilterFunction1 = p => p.GetAge() > 18;
            Func<Person, bool> myFilterFunction2 = MyFilterFunction2;


            var listOfFirstNames = people.Select(p=>p.FirstName);
            Console.WriteLine(string.Join('-', listOfFirstNames));


            var sumAgeHansens1 = people
                .Where(p => p.LastName == "Hansen")
                .Select(p => DateTime.Now.Year - p.BirthYear)
                .Sum();

            var ageHansens = 
                from p in people
                where p.LastName == "Hansen"
                select DateTime.Now.Year - p.BirthYear;
            var sumAgeHansens = ageHansens.Sum();

            var people2 = people.Select(p => new Person2(p.FirstName + " " + p.LastName, p.GetAge()));
            
            
            var people3 = people.Select(p => new
            {
                FullName = p.FirstName + " " + p.LastName, 
                Age = p.GetAge()
            });

            foreach (var p in people3)
            {
                Console.WriteLine(p.FullName);
            }
        }

        static bool MyFilterFunction2(Person arg)
        {
            return true;
        }

        static int GetAge(Person p)
        {
            return p.GetAge();
        }
    }
}
