using AbstractionInterface.ShapeAbstraction;
using System;

namespace AbstractionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle1 = new Rectangle(3,4);
            //Console.WriteLine(rectangle1.Area());
            //Console.WriteLine(rectangle1.Length());
            //Console.WriteLine(rectangle1.GetDioganal());

            //Circle circle1 = new Circle(5);
            //Console.WriteLine(circle1.Area());
            //Console.WriteLine(circle1.Length());
            //Console.WriteLine(circle1.GetDioganal());
            //circle1.ShowName();

            //Test test1 = new Test();
            //Test2 test2 = new Test2();
            //Test3 test3 = new Test3();

            //test1.ShowName();
            //Console.WriteLine("***********************");
            //test2.ShowName();

            //Console.WriteLine("***********************");
            //test3.ShowName();

            Notebook notebook = new Notebook
            {
                Name = "HP",
                Price = 1500,
                RAM = 16,
                HDD = "1TB"
            };

            WashMashine washMashine = new WashMashine()
            {
                Name = "Beko",
                Price = 800,
                DoorShape = "Circle",
                Capacity = 6
            };


            Console.WriteLine(notebook.Info());
            Console.WriteLine(washMashine.Info());
        }
    }
}
