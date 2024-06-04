namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ExecuteAsyncFunctions();
        }

        public static async Task ExecuteAsyncFunctions()
        {
            var firstAsync = FirstAsync();
            var secondAsync = SecondAsync();
            var thirdAsync = ThirdAsync();
            await Task.WhenAll(firstAsync, secondAsync, thirdAsync);

            Console.WriteLine("asdada");
        }

        public static async Task FirstAsync()
        {
            Console.WriteLine("First Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("First Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
        public static async Task SecondAsync()
        {
            Console.WriteLine("Second Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("Second Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
        public static async Task ThirdAsync()
        {
            Console.WriteLine("Third Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("Third Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}