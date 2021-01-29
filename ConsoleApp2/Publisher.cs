namespace ConsoleApp2
{
    using System;

    /// <summary>
    /// This class is for publicher of event.
    /// </summary>
    public class Publisher
    {
        /// <summary>
        /// Declare the event using EventHandler<T>.
        /// </summary>
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        /// <summary>
        /// This is method of event.
        /// </summary>
        public void EventMethod()
        {
            int firstNumber = GetRandom();
            int secondNumber = GetRandom();

            static int GetRandom()
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 100);
                return value;
            }

            this.OnRaiseCustomEvent(new CustomEventArgs("Summarize:", firstNumber, secondNumber));
        }

        /// <summary>
        /// Virtual event invocation method allow to owerride it.
        /// </summary>
        /// <param name="e">e for message text.</param>
        protected virtual void OnRaiseCustomEvent(CustomEventArgs e)
        {
            EventHandler<CustomEventArgs> raiseEvent = this.RaiseCustomEvent;

            if (raiseEvent != null)
            {
                raiseEvent(this, e);
            }
        }
    }
}
