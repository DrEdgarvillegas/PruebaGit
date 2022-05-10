using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7Ejer5
{
    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }
    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification()
        {
            _ iMessenger = new Email();
        }
        public void DoNotify()
        {
            _ iMessenger.SendMessage();
        }
    }
}
