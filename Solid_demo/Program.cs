using Solid_demo.Utils;
using System;
using Autofac;

namespace Solid_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var player = new Player(Armory.GetWeapon());

            // Get IoC container
            var container = AutofacConfiguration.GetContainer();
            // Resolve() - виріши залежності
            var player = new Player(container.Resolve<IWeapon>());

            player.Fight();
            var rect = new Rect() { A = 3, B = 4 };
            //   rect.Print();
            var sq = new Square { A = 4 };
            Print(sq);
            //  sq.Print();
            Console.ReadLine();
        }

        static void Print(IFigure f)
        {
            Console.WriteLine(f.S());
        }

        class Rect : IFigure
        {
            public int A { get; set; }
            public int B { get; set; }

            public int S()
            {
                return A * B;
            }
        }

        class Square : IFigure
        {
            public int A { get; set; }

            public int S()
            {
                return A * A;
            }
        }

        interface IFigure
        {
            int S();
        }

        interface IMessage
        {
            string From { get; set; }
            string To { get; set; }
        }

        interface ISubject
        {
            string Subject { get; set; }
        }

        interface ITextContent
        {
            string Body { get; set; }
        }

        interface IAttachment
        {
            string Attachment { get; set; }
        }


        class Email : IMessage, ISubject, ITextContent, IAttachment
        {
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Attachment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class Sms : IMessage, ITextContent
        {
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        class Mms : IMessage, IAttachment, ITextContent
        {
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Attachment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

    }
}
