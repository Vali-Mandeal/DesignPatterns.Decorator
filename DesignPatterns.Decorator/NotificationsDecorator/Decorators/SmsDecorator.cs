using System;

namespace DesignPatterns.Decorator.NotificationsDecorator.Decorators
{
    public class SmsDecorator : BaseDecorator
    {
        public SmsDecorator(INotifier notifier)
            : base(notifier)
        {
                
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine(" - via SMS.");
        }
    }
}
