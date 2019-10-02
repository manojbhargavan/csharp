using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionIsSlow reflectionIsSlowDemo = new ReflectionIsSlow(50000000);
            reflectionIsSlowDemo.RunTestAndPrint();
        }
    }
} 
