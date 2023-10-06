using System.Reflection;
using System;
using System.Collections;
namespace AdvanceCollections
{
    internal class Bacon { }
    internal class Coffee { }
    internal class Egg { }
    internal class Juice { }
    internal class Toast { }
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    Program p = new();
        //    List<string> list = new List<string>() { "hello ", "world","how","are","you" };
        //    //printT<List<string>>(list);
        //    printMethod(list);
        //}
        //public static T MyFunc<T>(T a, T b)
        //{
        //    return a;
        //}

        //////////////////////////////////////Method for Generic of Generic
        public static void printT<T>(T a)
        {
            //Console.WriteLine(a.GetType());
            var enumerable = a as System.Collections.IEnumerable;
            if (enumerable != null)
            {
                foreach (var item in enumerable)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // OR

        public static void printMethod(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }


        public static async Task Main(string[] args)
        {
            //synchronous
            //Coffee cup = PourCoffee();
            //Console.WriteLine("Coffee is Ready");

            //Egg egg = FryEggs(2);
            //Console.WriteLine("Eggs are ready");

            //Bacon bacon = FryBacon(3);
            //Console.WriteLine("Bacon are ready");

            //Toast toast = ToastBread(2);
            //ApplyButter(toast);
            //ApplyJam(toast);
            //Console.WriteLine("toast is ready");

            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");
            //Console.WriteLine("BreakFast is ready");

            //asynchronous demo
            //fun();
            //await Task.Delay(4000);
            //fun();
            //Console.WriteLine("Hello World from main");


            await fun();
            var T = new Task( () =>  
            {
                Console.WriteLine("Simple Hello World");
                //await Console.Out.WriteLineAsync("Hello World From Async Writeline");
                //await Task.Delay(3000);
        //        var client = new HttpClient();
        //        Task<string> getStringTask =
        //client.GetStringAsync("https://learn.microsoft.com/dotnet");
        //        Console.WriteLine(getStringTask.Result);
                //Task.Delay(4000); // Will not run when ran it as synchronously becuase this is asynchronous method
                Console.WriteLine("Running Second fun()");
                //await fun();
                Console.WriteLine("Hello World from Synchronous");
            });
            T.Start();
            //await Task.Delay(6000);
            Console.WriteLine("Hello World from main1");
            Console.WriteLine("Hello World from main2");
            Console.WriteLine("Hello World from main3");
            Console.WriteLine("Hello World from main4");
            Console.WriteLine("Hello World from main5");
            //T.Wait();
            //T.Result.Wait();

            //Task t = fun();
            //Task.Delay(4000).Wait();
            //Console.WriteLine("Hello");
            //await t;
            //Console.WriteLine("Hello");

            //var t = new Task(() => TestTask());
            //t.Start();
            ////asynchronous

            //Coffee cup = PourCoffee();
            //Console.WriteLine("coffee is ready");

            //var eggsTask = FryEggsAsync(2);
            //var baconTask = FryBaconAsync(3);
            //var toastTask = MakeToastWithButterAndJamAsync(2);
            //var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            //while (breakfastTasks.Count > 0)// Task gets deleted once completed so its list gets shorter
            //{
            //    printList(breakfastTasks);
            //    Task finishedTask = await Task.WhenAny(breakfastTasks);
            //    if (finishedTask == eggsTask)
            //    {
            //        Console.WriteLine("eggs are ready");
            //    }
            //    else if (finishedTask == baconTask)
            //    {
            //        Console.WriteLine("bacon is ready");
            //    }
            //    else if (finishedTask == toastTask)
            //    {
            //        Console.WriteLine("toast is ready");
            //    }
            //    await finishedTask;
            //    breakfastTasks.Remove(finishedTask);
            //}

            //Juice oj = PourOJ();
            //Console.WriteLine("oj is ready");
            //Console.WriteLine("Breakfast is ready!");


            //////////////////////extra
            //Assembly info = typeof(int).Assembly;
            //Console.WriteLine(info);
        }
        private static async Task fun()
        {
            Console.WriteLine("First Hello World from fun()");
            await Task.Delay(2000);
            Console.WriteLine("Second Hello World from fun");
        }
        //private static void printList(List<Task> a)
        //{
        //    foreach (var s in a) Console.WriteLine(s);
        //}
        //private static void TestTask()
        //{
        //    Console.WriteLine("Hello");
        //    Task.Delay(4000);
        //    Console.WriteLine("Bye");
        //}
        //////////////////////////////////////synchronous
        //private static Juice PourOJ()
        //{ 
        //    Console.WriteLine("Pouring orange juice");
        //    return new Juice();
        //}

        //private static void ApplyJam(Toast toast) =>
        //    Console.WriteLine("Putting jam on the toast");

        //private static void ApplyButter(Toast toast) =>
        //    Console.WriteLine("Putting butter on the toast");

        //private static Toast ToastBread(int slices)
        //{
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("Putting a slice of bread in the toaster");
        //    }
        //    Console.WriteLine("Start toasting...");
        //    Task.Delay(3000).Wait();
        //    Console.WriteLine("Remove toast from toaster");

        //    return new Toast();
        //}

        //private static Bacon FryBacon(int slices)
        //{
        //    Console.WriteLine($"putting {slices} slices of bacon in the pan");
        //    Console.WriteLine("cooking first side of bacon...");
        //    Task.Delay(3000).Wait();
        //    for (int slice = 0; slice < slices; slice++)
        //    {
        //        Console.WriteLine("flipping a slice of bacon");
        //    }
        //    Console.WriteLine("cooking the second side of bacon...");
        //    Task.Delay(3000).Wait();
        //    Console.WriteLine("Put bacon on plate");

        //    return new Bacon();
        //}

        //private static Egg FryEggs(int howMany)
        //{
        //    Console.WriteLine("Warming the egg pan...");
        //    Task.Delay(3000).Wait();
        //    Console.WriteLine($"cracking {howMany} eggs");
        //    Console.WriteLine("cooking the eggs ...");
        //    Task.Delay(3000).Wait();
        //    Console.WriteLine("Put eggs on plate");

        //    return new Egg();
        //}

        //private static Coffee PourCoffee()
        //{
        //    Console.WriteLine("Pouring coffee");
        //    return new Coffee();
        //}

        /////////////////////////////////////////////////////////////// asynchronous

        static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            var toast = await ToastBreadAsync(number);
            ApplyButter(toast);
            ApplyJam(toast);

            return toast;
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static async Task<Toast> ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static async Task<Bacon> FryBaconAsync(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        private static async Task<Egg> FryEggsAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }

}