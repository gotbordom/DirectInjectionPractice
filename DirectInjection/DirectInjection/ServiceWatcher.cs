using System;
using System.Collections.Generic;
using System.Text;
using DirectInjection.Notifications;

namespace DirectInjection
{
    class ServiceWatcher
    {
        INotifyAction action = null;

        public ServiceWatcher(INotifyAction concreteImplimentation)
        {
            this.action = concreteImplimentation;
        }

        public void Notify(string msg)
        {
            action.ActOnNotification(msg);
        }
    }
}
