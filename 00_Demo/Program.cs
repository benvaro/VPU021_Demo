using System;

namespace _00_Demo
{
    delegate int Calc(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Demo();
            demo.calc += Add;
            demo.calc += Div;
            demo.calc += Multiply;

            //  demo.calc = Add;  // error. operation = is not allowed
            demo.Show();

            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Div(int a, int b)
        {
            return a / b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Demo
    {
        public event Calc calc;

        public void Show()
        {
            Console.WriteLine(calc?.Invoke(4, 6));
        }
    }

    class Animal
    {
        string name; // null
    }
}
