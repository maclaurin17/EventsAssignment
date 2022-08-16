namespace EventsAssignment
{/// <summary>
/// This is the Subscriber class
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage); // Event gets binded with delegates
            a.Add();
            Console.Read();
        }

        static void EventMessage() //Delegate calls this method when event raised.
        {
            Console.WriteLine("Event Executed : This is an Odd Number");
        }
    }
    /// <summary>
    /// This is the publisher class
    /// </summary>
    public class AddTwoNumbers 
    {
        public delegate void dg_OddNumber(); //Declared a Delegate
        public event dg_OddNumber ev_OddNumber; //Declared an Event

        public void Add()
        {
            int result;
            result = 8 + 9;
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 !=0) && (ev_OddNumber != null))
            {
                ev_OddNumber();//Raise event
            }
        }
    }
}