using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class ReflectionIsSlow
    {
        public int NumberOfIterations { get; private set; }

        public ReflectionIsSlow(int numberOfIterations)
        {
            NumberOfIterations = numberOfIterations;
        }

        public void RunTestAndPrint()
        {
            Console.WriteLine($"Creating {NumberOfIterations} lists Normally takes {CreateListNormal()} Milliseconds.");
            Console.WriteLine($"Creating {NumberOfIterations} lists Reflected takes {CreateListReflection()} Milliseconds.");
            Console.WriteLine($"Adding {NumberOfIterations} items to list Normally takes {AddListNormal()} Milliseconds.");
            Console.WriteLine($"Adding {NumberOfIterations} items to list Reflection takes {AddListReflection()} Milliseconds.");
        }

        private int CreateListNormal()
        {
            var startTime = DateTime.Now;

            for (int i = 0; i < NumberOfIterations; i++)
            {
                var list = new List<int>();
            }

            var endTime = DateTime.Now;
            return startTime.GetDurationInMilliSeconds(endTime);
        }

        private int CreateListReflection()
        {
            var startTime = DateTime.Now;

            Type listInt = typeof(List<int>);

            for (int i = 0; i < NumberOfIterations; i++)
            {
                var list = Activator.CreateInstance(listInt);
            }

            var endTime = DateTime.Now;
            return startTime.GetDurationInMilliSeconds(endTime);
        }

        private int AddListNormal()
        {
            var startTime = DateTime.Now;

            var list = new List<int>();
            for (int i = 0; i < NumberOfIterations; i++)
            {
                list.Add(i);
            }

            var endTime = DateTime.Now;
            return startTime.GetDurationInMilliSeconds(endTime);
        }

        private int AddListReflection()
        {
            var startTime = DateTime.Now;

            Type listType = typeof(List<int>);
            Type[] parameters = { typeof(int) };
            var method = listType.GetMethod("Add", parameters);
            var list = Activator.CreateInstance(listType);

            for (int i = 0; i < NumberOfIterations; i++)
            {
                method.Invoke(list, new object[] { i });
            }

            var endTime = DateTime.Now;
            return startTime.GetDurationInMilliSeconds(endTime);
        }

    }
}
