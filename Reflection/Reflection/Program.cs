using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            ReflectionIsSlow reflectionIsSlowDemo = new ReflectionIsSlow(int.MaxValue);
            reflectionIsSlowDemo.RunTestAndPrint();
        }
    }
}
