using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            a.event_OddNumber += new AddTwoNumbers.delegate_OddNumber(EventMessage);
            a.Add();
            Console.Read();
        }
        static void EventMessage()
        {
            Console.WriteLine("Event Executed : This is Odd Number");
        }
        class AddTwoNumbers
        {
            public delegate void delegate_OddNumber();
            public event delegate_OddNumber event_OddNumber;

            public void Add()
            {
                int result;
                result = 5 + 4;
                Console.WriteLine(result.ToString());
                if ((result % 2 != 0) && (event_OddNumber != null))
                {
                    event_OddNumber();
                }
            }
        }
    }
}
