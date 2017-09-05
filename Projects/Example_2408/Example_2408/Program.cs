using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Example_2408
{
    class Program
    {
        static Mutex m;
        static Random random = new Random();
        static Thread[] threads = new Thread[10];
        static Semaphore semaphoreSlim = new Semaphore(2, 2,"SemaphoreExample");
        static Semaphore Semaphore = new Semaphore(3, 3);
        static bool chkInstances()
        {
            try
            {
                Mutex.OpenExisting("Instance");
            }
            catch
            {
                Program.m = new Mutex(true, "Instance");
                return true;
            }
            return false;
        }
        static bool chkNumberOfInstances()
        {
            if (semaphoreSlim.WaitOne(5000, false) == false)
                return false;
            else
                return true;
        }
        static void SemaphoreExample()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is waiting");
            Semaphore.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} is excuting");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.Name} is exiting");
            Semaphore.Release();
        }
        static void Main(string[] args)
        {
            //if (Program.chkNumberOfInstances()==true)
            //{
            //    Console.WriteLine("Instance created");
                
            //}

            //else
            //{
                Program p = new Program();
                Thread objThread1 = new Thread(ForeGround);
                Thread objThread2 = new Thread(BackGround);
                Thread objThread3 = new Thread(Divide);
                objThread2.IsBackground = true;
            Parallel.Invoke(() => BackGround());
                /*for (int i = 0; i < 10; i++)
                {
                    threads[i] = new Thread(SemaphoreExample);
                    threads[i].Name = "Thread " + (i + 1);
                    threads[i].Start();
                }*/
                //objThread3.Start();
                //Divide();
                //ThreadPool.QueueUserWorkItem(ThreadPoolExapmle);
                Console.WriteLine("Main Function Exited");
                //Console.WriteLine("Max Number Of Intances reached");
            //}
            Console.ReadLine();
        }
        static void ThreadPoolExapmle(object info)
        {
            Console.WriteLine("Inside Pool Of Threads");
        }
        static void ForeGround()
        {
            Console.WriteLine("Base Function Started");
            Console.ReadLine();
            Console.WriteLine("Base Function Continues");
            Console.ReadLine();
        }
        static void BackGround()
        {
            Console.WriteLine("Base Function Started");
            //Console.ReadLine();
            Console.WriteLine("Base Function Continues");
            Console.ReadLine();
        }
        static void Divide()
        {
            for (int i = 0; i <= 100000; i++)
            {
                try

                {
                    int num1 = random.Next(1, 5);
                    int num2 = random.Next(1, 5);
                    double ans = num1 / num2;
                    num1 = 0;
                    num2 = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
