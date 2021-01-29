namespace ConsoleApp2
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// This is class, that starts programm implementation.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// This is method for starting programm implementation.
        /// </summary>
        public static void Run()
        {
            Publisher pub = new Publisher();

            Subscriber sub1 = new Subscriber(1, pub);
            Subscriber sub2 = new Subscriber(2, pub);

            pub.EventMethod();

            int sum = sub1.Result + sub2.Result;
            Console.WriteLine($"Total sum: {sum}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
