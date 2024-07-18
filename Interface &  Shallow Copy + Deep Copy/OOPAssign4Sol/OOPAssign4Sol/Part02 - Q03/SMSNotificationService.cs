using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign4Sol.Part02___Q03
{
    class SMSNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Hello {recipient}! \nThis is a SMS Message: {message}");
        }
    }
}
