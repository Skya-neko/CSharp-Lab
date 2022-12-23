using System;
using System.Threading;
using System.Windows.Input;

namespace CSharpPart2
{
    public class StopWatch
    {
        private TimeSpan AccumulatedTime = TimeSpan.Parse("00:00:00");
        //public TimeSpan AccumulatedTime { get; set; }
        bool Switch = true;
        
        public void Stop()
        {
            Console.WriteLine("You stop the timer.");
            Console.WriteLine(AccumulatedTime);


        }

        public void Start()
        {
            while (Switch)
            {
                Thread.Sleep(1000);
                AccumulatedTime = AccumulatedTime.Add(TimeSpan.Parse("00:00:01"));
                Console.WriteLine(AccumulatedTime);
            }


        }

        public void MainFun()
        {
            while (true)
            {
                var key = Console.ReadKey(true);

                
                switch (key.Key)
                {
                    case ConsoleKey.O:
                        Switch = true;
                        Thread t = new Thread(Start);
                        t.Start();
                        break;

                    case ConsoleKey.P:
                        Switch = false;
                        Stop();
                        break;

                    case ConsoleKey.Spacebar:
                        Console.WriteLine("quit.");
                        return;

                }





            }
            
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            var stopWatch = new StopWatch();
            stopWatch.MainFun();




        }
    }
}
