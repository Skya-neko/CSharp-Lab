using System;

namespace CSharpPart2
{
    public class Calculator
    {
        //var calculator = new Calculator();
        //Console.WriteLine(calculator.Add("You are summing up the numbers", 1, 2, 3, 4, 5, 6));
        //Console.WriteLine(calculator.Add("You are summing up the numbers", new int[] { 1, 2, 3, 4, 5 }));
            
        public int Add(string reminder, params int[] numbers)
        {
            Console.WriteLine(reminder);
            var sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
