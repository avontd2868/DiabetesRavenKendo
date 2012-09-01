using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace Scarlett.Diabetes.Log.Twilio
{
    public class TwilioMessageSender
    {

        private const string _accountSid = "AC654fe8d243f96cb77397f0f280ab504f";
        private const string _authToken = "f86acec80f8bea5ff10db08837804f80";
        private const string _sendingPhone = "(832) 431-4732";

        public static void SendMessage(string message, string recievingPhoneNumber)
        {
            if (null == message )
                throw new ArgumentNullException("message","expected a non-null message at most 140 characters");
            if (null == recievingPhoneNumber)
                throw new ArgumentNullException("message","cannot send message to null phone number");
            if (140 < message.Length)
                throw new ArgumentOutOfRangeException("message",String.Format("Message should be less than 140 characters.\r\nMessage is {0} characters long",message.Length));
            //to do check for valid phone number format
                        
            var twilio = new TwilioRestClient(_accountSid, _authToken);
            twilio.SendSmsMessage(_sendingPhone,recievingPhoneNumber,message);


        }
    }
}
