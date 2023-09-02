using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsole.Linq
{
    public class SelectManyDemo
    {
        public static void skipAndPrint() 
        {
            int[] numbers = { 13, 45, 74, 21, 46, 77 };

            var query = numbers.SelectMany((value, index) => numbers.Skip(index + 1));
            //Skip and print rest (Flattened by SelectMany)
            Console.WriteLine("SELECT MANY");
            foreach (var num in query)
            {
                Console.WriteLine("\t" + num.ToString());
            }

            Console.WriteLine("SELECT");
            //Burada selector olarak (value ve index) alan overloadi kullanildi
            //Her ne kadar value kullanmamis olsakta index almak icin Func<int, int, TResult> gerekliydi.

            //!!!Yanilgi :
            //Sadece index almak icin asagidaki gibi bir yanilgiya dusulebilir. 
            //var query2 = numbers.Select(index => numbers.Skip(index + 1));
            //!!!Burada index sadece lambda icin input parametresinin adi aslinda numbers icerisindeki elemanlardan birtanesini almis oluyoruz;
            //Ornegin index degeri yukaridaki numbers arrayina gore 13 olur. Skip(index+1) de ise 14. elemandan sonrasini almaya calisir ve hic sonuc donmez.

            var query2 = numbers.Select((value, index) => numbers.Skip(index + 1));
            foreach (var group in query2)
            {
                Console.WriteLine(" ");
                foreach (var num2 in group)
                    Console.WriteLine("\t" + num2.ToString());
            }

            Console.ReadKey();
        }

        public static void uniqueCombinations()
        {
            //https://stackoverflow.com/questions/3479980/select-all-unique-combinations-of-a-single-list-with-no-repeats-using-linq
            int[] numbers = { 13, 45, 74, 21, 46, 77 };

            var query = numbers.SelectMany((value, index) => numbers.Skip(index + 1),
                              (first, second) => new { first, second });
            //Skip and print rest (Flattened by SelectMany)
            Console.WriteLine("SELECT MANY");
            foreach (var num in query)
            {
                Console.WriteLine("\t" + num.ToString());
            }
            Console.ReadKey();
        }
    }
}
