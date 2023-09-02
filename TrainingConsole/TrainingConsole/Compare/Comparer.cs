using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsole.Compare
{
    public class Comparer
    {
        public static void compareIntersectDemo()
        {
            //var source = new List<string>() { "a", "b", "a", "c", "a" };
            //var compare = new List<string>() { "a", "c", "d" };
            //var result2 = source.Intersect(compare);

            var source = new List<Person>() { new Person("Luke11", "Skywalker"), new Person("Luke22", "Skywalker") };
            var compare = new List<Person>() { new Person("Luke33", "Skywalker"), new Person("Luke44", "Skywalker") };
            var result = source.Intersect(compare);
            //Comparer sadece soyada baktigi icin bu ornekte adin bir onemi kalmadi.
            var result1 = source.Intersect(compare, new PersonComparer()).ToList();
            Console.ReadLine();
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.LastName == y.LastName;
        }

        public int GetHashCode(Person x)
        {
            int hashCode = x.LastName.GetHashCode();
            Console.WriteLine(hashCode);
            return hashCode;
        }
    }
}
