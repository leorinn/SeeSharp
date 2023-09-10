using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsole.OOP
{
    public class CoContraEtc
    {
        public static void CoContraEtcDemo() 
        {
            //https://stackoverflow.com/a/46793178
            //Dog d = new Animal(); //Compile time error
            //Dog d = (Dog)new Animal(); //Runtime error

            Animal a = new Dog();
            Dog d = (Dog)a;

            int test = d.b + d.a;
        }


        public class Animal
        {
            public int a = 4;
        }

        public class Dog : Animal
        {
            public int b = 5;
        }
    }
}
