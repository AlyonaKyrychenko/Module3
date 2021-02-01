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

            pub.RaiseCustomEvent += this.HandleCustomEventAsync;
        }

        private async void HandleCustomEventAsync(object sender, CustomEventArgs e)
        {
            int result = await Task.Run(() => Summator.CalcSum(e.First, e.Second));
            Console.WriteLine($"{this.id} subscriber received this message: {e.Message} = {result}");
            this.Result = result;
        }
    }
}
