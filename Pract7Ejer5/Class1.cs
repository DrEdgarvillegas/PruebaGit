using System;
using System.Collections.Generic;
using System.Text;

namespace Pract7Ejer5
{
    public class Email
    {
        public void SendEmail()
        {
            // code to send mail
        }
    }

    public class Notification
    {
        private Email _email;
        public Notification()
        {
            _email = new Email();
        }

        public void PromotionalNotification()
        {
            _email.SendEmail();
        }
    }


    //-------------------------------------------------------------------------------
    //Constructor Injection

    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification(Imessenger pMessenger)
        {
            _ iMessenger = pMessenger;
        }
        public void DoNotify()
        {
            _ iMessenger.SendMessage();
        }
    }

    //-----------------------------------------------------------------------------------
    //Property Injection

    public class Notification
    {
        private IMessenger _iMessenger;

        public Notification()
        {
        }
        public IMessenger MessageService
        {
            private get;
            set
            {
                _ iMessenger = value;
            }
        }

        public void DoNotify()
        {
            _ iMessenger.SendMessage();
        }
    }

    //----------------------------------------------------------------------------------
    //Method Injection

    public class Notification
    {
        public void DoNotify(IMessenger pMessenger)
        {
            pMessenger.SendMessage();
        }
    }
}
