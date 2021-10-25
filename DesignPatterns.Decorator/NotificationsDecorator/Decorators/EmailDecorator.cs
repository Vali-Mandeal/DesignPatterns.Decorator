using System;

namespace DesignPatterns.Decorator.NotificationsDecorator.Decorators
{
    public class EmailDecorator : BaseDecorator
    {
        public EmailDecorator(INotifier notifier)
            : base(notifier)
        {

        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine(" - via Email.");
        }
    }
}
