namespace ConsoleApp2
{
    using System;

    /// <summary>
    /// This class customize EventArgs Class.
    /// </summary>
    public class CustomEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEventArgs"/> class.
        /// </summary>
        /// <param name="message">Some message in event.</param>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        public CustomEventArgs(string message, int first, int second)
        {
            this.Message = message;
            this.First = first;
            this.Second = second;
        }

        /// <summary>
        /// Gets or sets for some message in event.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets for first number in event.
        /// </summary>
        public int First { get; set; }

        /// <summary>
        /// Gets or sets for second number in event.
        /// </summary>
        public int Second { get; set; }
    }
}
