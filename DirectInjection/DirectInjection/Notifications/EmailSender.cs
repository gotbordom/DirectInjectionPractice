using System;
using System.Collections.Generic;
using System.Text;

namespace DirectInjection.Notifications
{
    class EmailSender : INotifyAction
    {
        // Who to email
        public List<string> emails;

        public void ActOnNotification(string msg)
        {
            // Semd email notificaiton

        }

    }
}
