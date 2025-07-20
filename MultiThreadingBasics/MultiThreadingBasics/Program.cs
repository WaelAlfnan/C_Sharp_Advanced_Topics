
namespace MultiThreadingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var th1 = new Thread(ProcessPatch1);//Thread take Delegate with one paramater his type is object or without any paramaters
            //var th1 = new Thread(new ThreadStart(ProcessPatch1)); it is the same
            th1.Priority = ThreadPriority.Highest;
            var th2 = new Thread(ProcessPatch2);
            th2.Priority = ThreadPriority.Lowest;

            // there are two types of threads : 1- ForeGroundThread like the Main Thread and the default of any thread created
            //                                  2- BackGroundThread which tell the sys if the ForeGround Threads finished stop the background Threads like when the sys is closed all processes must fishish with it, so to make this you must make any thread you created inBackGround thread
            th1.IsBackground = true;
            th2.IsBackground = true;
            th1.Start();
            th2.Start();
            // cpu try to excute the two threads together at the same time
            // what happened is Concurency process which meaning that the cpu switch between threads in the excution process
            //because that the excution time of multithreading is unexpected.
            */
            //-------------------------------------------------------------------
            var cts = new CancellationTokenSource();
            // any thread created by ThreadPool is in BackGround by default
            ThreadPool.QueueUserWorkItem(ProcessPatch1);
            ThreadPool.QueueUserWorkItem(ProcessPatch2);
            cts.Cancel();
            Console.ReadKey();//let the background threads work untill tap any butttom and that is in the ForeGround Thread

            //ProcessPatch1();
            //ProcessPatch2();
        }

        private static object _lock = new();

        private static void ProcessPatch1(object? state)
        {
            //var cancellationToken = (CancellationToken)state;
            for(int i = 1; i <= 1000; i++)
            {
                //if (cancellationToken.IsCancellationRequested)
                //    return;
                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine(i);
                //Console.ForegroundColor = ConsoleColor.White;
                //Console.ForegroundColor is a static resourse you mustn't call it when making multithreading

                lock (_lock) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        private static void ProcessPatch2(object? state)
        {
            //var cancellationToken = (CancellationToken)state;
            for (int i = 1001; i <= 2000; i++)
            {
                //if (cancellationToken.IsCancellationRequested)
                //    return;
                //Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine(i);
                //Console.ForegroundColor = ConsoleColor.White;

                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
