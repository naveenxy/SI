using System;
namespace PolymorphismDemo
{
    class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : Class1
    {
        public override void show()
        {
            // base.show();    
            Console.WriteLine("Sub class override show method");
        }
    }

    class Class3 : Class1
    {
        public override void show()
        {
            // base.show();    
            Console.WriteLine("Naveen");
        }
    }
}
   /* class Program
    {

        static void Main(string[] args) {
            ///  Class1 obj = new Class1();
            Class2 obj2 = new Class3();
            obj2.show();
           // obj.show();
           // Console.ReadKey();
        }
    }
}*/