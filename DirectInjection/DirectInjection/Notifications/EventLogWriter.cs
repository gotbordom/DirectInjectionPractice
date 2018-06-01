using System;
using System.Collections.Generic;
using System.Text;

namespace DirectInjection.Notifications
{
    class EventLogWriter : INotifyAction
    {

        public void ActOnNotification(string msg)
        {
            // Do some notifying - write to a log

        }

    }
}
