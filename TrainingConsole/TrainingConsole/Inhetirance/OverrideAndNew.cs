using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingConsole.Inhetirance
{
    class OverrideAndNew
    {
        //In C#, a method in a derived class can have the same name as a method in the base class. 
        //You can specify how the methods interact by using the new and override keywords. 
        //The override modifier extends the base class virtual method, and the new modifier hides an accessible base class method. 
        public void Run()
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass(); //bcdc is of type BaseClass, and its value is of type DerivedClass. This is the variable to pay attention to.

            // The following two calls do what you would expect. They call  
            // the methods that are defined in BaseClass.  
            bc.Method1();
            bc.Method2();
            // Output:  
            // Base - Method1  
            // Base - Method2  

            // The following two calls do what you would expect. They call  
            // the methods that are defined in DerivedClass.  
            dc.Method1();
            dc.Method2();
            // Output:  
            // Derived - Method1  
            // Derived - Method2  

            // The following two calls produce different results, depending
            // on whether override (Method1) or new (Method2) is used.  
            bcdc.Method1();
            bcdc.Method2();
            // Output:  
            // Derived - Method1  
            // Base - Method2  
        }
    }

    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }

        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }
}
