using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Scarlett.Diabetes.Log.Twilio.TwilioMessageSender.SendMessage("Hello World", "7134691427");
            Console.WriteLine("Sent Message");
        }
    }
}
