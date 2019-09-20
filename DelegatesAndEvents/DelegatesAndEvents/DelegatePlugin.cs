using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    delegate int TrasformNumber(int number);
    public class DelegatePlugin : IExample
    {
        public void RunExample()
        {
            TrasformNumber delegateTrasform = Square;
            delegateTrasform += Cube;
            List<int> numList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var item in numList)
            {
                delegateTrasform(item);
            }
        }
        
        private int Power(int number, int exponent)
        {
            int result = number;
            for (int i = 1; i < exponent; i++)
            {
                result *= number;
            }
            
            return result;
        }
        private int Square(int i) 
        { 
            int result = Power(i, 2);
            Console.WriteLine($"Square of {i}: {result}");
            return result; 
        }

        private int Cube(int i)
        {
            int result = Power(i, 3);
            Console.WriteLine($"Cube of {i}: {result}");
            return result;
        }

    }
}
