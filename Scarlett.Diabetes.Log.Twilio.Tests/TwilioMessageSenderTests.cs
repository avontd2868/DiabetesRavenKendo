using System;
using NUnit.Framework;

namespace Scarlett.Diabetes.Log.Twilio.Tests
{
    [TestFixture]
    public class TwilioMessageSenderTests
    {
        [Test]
        public void TestSendMessage()
        {
            AttemptToSendMessage("Hello", "7134691427");
        }
        [Test]
        public void TestSendMessageWithNullPhone()
        {
            //Arrange
            var message = string.Empty;
            string recievingPhone = null;

            //Act
            AttemptToSendMessage(message, recievingPhone);

            //Assert
            Assert.Throws<Exception>(() => AttemptToSendMessage(message, recievingPhone));
            //Expected Arugment Assertion Attribute
        }
            
        private void AttemptToSendMessage(string message, string toPhone)
        {
            TwilioMessageSender.SendMessage(message, toPhone);
        }
    }
}
