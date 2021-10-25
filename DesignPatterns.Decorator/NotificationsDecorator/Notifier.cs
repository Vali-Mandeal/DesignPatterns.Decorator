using System;

namespace DesignPatterns.Decorator.NotificationsDecorator
{
    public class Notifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"\nPublishing '{message}' through following channels: \n");
        }
    }
}
