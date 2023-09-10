using System;
using System.Net.NetworkInformation;
using System.Security.Policy;

namespace TrainingConsole.OOP
{
    public class Demo1
    {
        public static void PrivateAccess() 
        {
            //https://stackoverflow.com/questions/43524738/private-member-variable-is-accessed-by-another-object-of-same-class#:~:text=What%20you%20are%20doing%20is,value%20in%20that%20class.
            //private is per class not per object.

            Person ahmet = new Person("Ahmet");
            Person mehmet = new Person("Mehmet");
            ahmet.Friend = mehmet;
            string friendName = ahmet.AskFriendName();
            Console.WriteLine(friendName);

            //https://stackoverflow.com/questions/12355372/private-member-accessible-from-other-instances-of-the-same-class
            //There would be no other decent way to make copy/ clone methods.You could make it protected internal if you were concerned about it somehow being accessed outside the assembly or something.
            //It's also necessary for implementing equals()
            //private fieldlere erisemeden 2 nesnenin ayni olup olmadigini bilmek? Class Equal implementation 

            //Reflection kullanarak private field degerleri alinabiliyor.(Belli bir c# versionuna kadar)
        }

        public static void ConstructorDemo() 
        {
            //Eger parametreli constructor tanimlanirsa default constructor olusturulmaz ve compiler hata verir.
            //Animal cat = new Animal(); 
            //Error CS7036  There is no argument given that corresponds to the required parameter 'name' of 'Animal.Animal(string)'
        }
        public class Person
        {
            private string name;
            public Person(string name)
            {
                this.name = name;
            }
            public Person Friend { get; set; }
            public string AskFriendName()
            {
                return Friend.name;
            }
        }

        public class Animal
        {
            private string name;
            public Animal(string name)
            {
                this.name = name;
            }
        }
    }
}
