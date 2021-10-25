using System;

namespace DesignPatterns.Decorator.NotificationsDecorator.Decorators
{
    public class TeamsDecorator : BaseDecorator
    {
        public TeamsDecorator(INotifier notifier)
            : base(notifier)
        {

        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine(" - via Teams.");
        }
    }
}
