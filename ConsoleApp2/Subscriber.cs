namespace ConsoleApp2
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is for subscriber of event.
    /// </summary>
    public class Subscriber
    {
        /// <summary>
        /// This is for saving result of summing two numbers.
        /// </summary>
        public int Result;
        private readonly int id;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriber"/> class.
        /// </summary>
        /// <param name="id">Subscriber`s ID.</param>
        /// <param name="pub">Publisher.</param>
        public Subscriber(int id, Publisher pub)
        {
            this.id = id;

            pub.RaiseCustomEvent += this.HandleCustomEvent;
        }

        /// <summary>
        /// This is async for summing method.
        /// </summary>
        /// <returns>Async result.</returns>
        private static async Task<int> HandleCustomEventAsync(int value1, int value2)
        {
            int result = await Task.Run(() => Summator.CalcSum(value1, value2));
            return result;
        }

        private void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            this.Result = HandleCustomEventAsync(e.First, e.Second).GetAwaiter().GetResult();
            Console.WriteLine($"{this.id} subscriber received this message: {e.Message} = {this.Result}");
        }
    }
}
