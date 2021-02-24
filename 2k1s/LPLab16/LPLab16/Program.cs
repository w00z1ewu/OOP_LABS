using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Collections.Concurrent;

namespace LPLab16
{
    class Program
    {
        static void Main(string[] args)
        {   // ============= T A S K 1 ==============
            Task t1 = new Task(new Action(SieveEratosthenes));
            Stopwatch checkTime = new Stopwatch();
            checkTime.Start();
            t1.Start();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Current Task Id:" + t1.Id.ToString() + ", status: " + t1.Status.ToString());
            Console.ResetColor();
            t1.Wait();
            checkTime.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTime spent: " + checkTime.Elapsed.ToString() + '\n');
            Console.ResetColor();


            // ============= T A S K 2 ==============
            CancellationTokenSource canceltoken = new CancellationTokenSource();
            Task t2 = new Task(SieveEratosthenes, canceltoken.Token);
            t2.Start();
            canceltoken.Cancel();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(t2.Status.ToString()+" thread.");
            Console.ResetColor();

            // ============= T A S K 3 ==============
            int sum = 0;
            Task<int> t3_1 = new Task<int>(() => SieveEratosthenes_2(2000));
            t3_1.Start();
            sum += t3_1.Result;
            Task<int> t3_2 = new Task<int>(() => SieveEratosthenes_2(4000));
            t3_2.Start();
            sum += t3_2.Result;
            Task<int> t3_3 = new Task<int>(() => SieveEratosthenes_2(6000));
            t3_3.Start();
            sum += t3_3.Result;
            Console.WriteLine("Result of three tasks = " + sum);

            // ============= T A S K 4 ==============
            Task t4 = t3_2.ContinueWith((a) => Console.WriteLine("Continuing task3_2..."));
            t3_2.Wait();
            var awaiter = t3_3.GetAwaiter();
            awaiter.OnCompleted(() => Console.WriteLine(awaiter.GetResult()+" is result of t3_3.."));

            // ============= T A S K 5 ==============

            int fact(int x)
            {
                int result = 1;

                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }


            int[][] arr_1 = new int[10][];
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.For(0, arr_1.Length, (int i) => { arr_1[i] = new int[100000]; });
            Parallel.ForEach(list, (a) => Console.WriteLine("factorial of number " + a + " is " + fact(a)));

            // ============= T A S K 6 ==============
            Parallel.Invoke(
                () => SieveEratosthenes(),
                () => SieveEratosthenes_2(2000),
                () => Console.WriteLine("Текущий таск: " + Task.CurrentId.ToString()),
                () => Console.WriteLine("Текущий таск: " + Task.CurrentId.ToString()),
                () => Console.WriteLine("Текущий таск: " + Task.CurrentId.ToString()),
                () => Console.WriteLine("Текущий таск: " + Task.CurrentId.ToString())
                );


            // ============= T A S K 8 ==============

            async void MethodAsync()
            {
                Console.WriteLine("started");
                await Task.Run(() => SieveEratosthenes_2(1000));
                Console.WriteLine("finished");
            }
            Console.WriteLine();
            MethodAsync();
            Console.WriteLine("Main continues its work...");

            Thread.Sleep(5000);
            // ============= T A S K 7 ==============

            Console.WriteLine();
            BlockingCollection<string> bc = new BlockingCollection<string>(5);
            CancellationTokenSource ts = new CancellationTokenSource();

            Task[] sellers = new Task[5]
            {
                new Task(() => { while(true){Thread.Sleep(300); bc.Add("Dishwasher"); } }),
                new Task(() => { while(true){Thread.Sleep(700); bc.Add("TV_set"); } }),
                new Task(() => { while(true){Thread.Sleep(300); bc.Add("PlayStation");  } }),
                new Task(() => { while(true){Thread.Sleep(750); bc.Add("ShowerCabine");  } }),
                new Task(() => { while(true){Thread.Sleep(700); bc.Add("PC_set"); } })
            };

            Task[] consumers = new Task[10]
            {
                new Task(() => { while(true){ Thread.Sleep(200);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(800);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(320);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(900);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(3500);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(275);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(3000);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(5000);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(900);   bc.Take(); } }),
                new Task(() => { while(true){ Thread.Sleep(750);   bc.Take(); } })
            };

            foreach (var i in sellers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            foreach (var i in consumers)
                if (i.Status != TaskStatus.Running)
                    i.Start();
            int count = 0;
            while (true)
            {
                if (bc.Count != count && bc.Count != 0)
                {
                    count = bc.Count;
                    Console.WriteLine("----------Склад----------");

                    foreach (var item in bc)
                        Console.WriteLine(item);

                    Console.WriteLine("-------------------------");
                }

            }
            Console.ReadKey();
        }
        public static void SieveEratosthenes()
        {
            uint n = 10000;
            var numbers = new List<uint>();
            //заполнение списка числами от 2 до n-1
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    //удаляем кратные числа из списка
                    numbers.Remove(numbers[i] * j);
                }
            }

            Console.WriteLine($"All the primes in [2, {n}]:");
            foreach (uint el in numbers)
            {
                Console.Write(el.ToString() + ' ');
            }
        }
        public static int SieveEratosthenes_2(uint n)
        {
            var numbers = new List<uint>();
            //заполнение списка числами от 2 до n-1
            for (var i = 2u; i < n; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2u; j < n; j++)
                {
                    //удаляем кратные числа из списка
                    numbers.Remove(numbers[i] * j);
                }
            }
            return numbers.Count;
        }
    }
}
