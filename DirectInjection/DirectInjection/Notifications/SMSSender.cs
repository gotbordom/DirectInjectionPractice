using System;
using System.Collections.Generic;
using System.Text;

namespace DirectInjection.Notifications
{
    class SMSSender : INotifyAction
    {

        // Who to sms
        public List<string> contacts;

        public void ActOnNotification(string msg)
        {
            // Send an sms notification


        }

    }
}
