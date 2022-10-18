using System;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            TransformToElephant();
            //Можно просто закомментировать строку Console.WriteLine("Муха") :)
            Console.WriteLine("Муха");
            //... custom application code
            
        }

        static void TransformToElephant()
        {
            Console.WriteLine("Слон");
            Console.SetOut(new MyWriter());
        }
    }

    class MyWriter : StringWriter
    {
        private TextWriter skipOne = Console.Out;

        public override void WriteLine(string? value)
        {
            Console.SetOut(skipOne);
        }
    }
}
