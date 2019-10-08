using System;

namespace CSharpIntermediate
{

    public class Class
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }
}

