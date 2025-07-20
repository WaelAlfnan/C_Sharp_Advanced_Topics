namespace Task_BasedAsynchronousPattern_TAP
{
    internal class Program
    {
        // async void : with event handler any thing else async Task
        static async Task Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            var x = await ProcessPatch1(cts.Token);//if delete the await it will return the task no the result
            Console.WriteLine($"Main thread id: {Environment.CurrentManagedThreadId}");
            //await ProcessPatch1(cts.Token);
            var task1 = ProcessPatch1(cts.Token);
            var task2 = ProcessPatch2(cts.Token);

            await Task.Delay(10);
            cts.Cancel();
            try
            {
                await task1;
            }
            catch (OperationCanceledException ex) { }
            await Task.Delay(1000);
            Console.WriteLine($"Task1 Status is: {task1.Status}" );
            
            //var task2 = await task1.ContinueWith(async t => await ProcessPatch2(cts.Token));

            //task1.Status = TaskStatus.Canceled;//any task has status

            //await task1;
            //await task2;
            //await Task.WhenAll(task1, task2);
            await Task.WhenAny(task1, task2);

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");
            Console.ReadKey();
        }

        private static object _lock = new();

        private static async Task<int> ProcessPatch1(CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Batch1 thread id: {Environment.CurrentManagedThreadId}");
            //await Task.Delay( 5000 );// await : it blocks the thread of the task(Batch1) and return the control to the caller thread(Main)
            Console.WriteLine($"Batch1(S2) thread id: {Environment.CurrentManagedThreadId}");
            for (int i = 1; i <= 100; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();
                //await Task.Delay(10, cancellationToken);
                //if (cancellationToken.IsCancellationRequested)
                //    //return Task.CompletedTask;
                //    return 0;
                //await Task.Delay(100);
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            //return Task.CompletedTask;
            return 10;
        }

        private static async Task ProcessPatch2(CancellationToken cancellationToken)
        {
            await Task.Delay(100);
            Console.WriteLine($"Batch2 thread id: {Environment.CurrentManagedThreadId}");
            //await Task.Delay(1);
            Console.WriteLine($"Batch2(S2) thread id: {Environment.CurrentManagedThreadId}");
            for (int i = 101; i <= 200; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                    //return Task.CompletedTask;
                    return;
                //await Task.Delay(100);
                lock (_lock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            //return Task.CompletedTask;
            return;
        }
    }
}
