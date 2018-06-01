using System;
using System.Collections.Generic;
using System.Text;

namespace DirectInjection.Notifications
{
    interface INotifyAction
    {
        void ActOnNotification(string msg);
    }
}
