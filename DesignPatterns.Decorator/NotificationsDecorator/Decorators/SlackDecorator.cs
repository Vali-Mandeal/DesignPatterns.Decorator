using System;

namespace DesignPatterns.Decorator.NotificationsDecorator.Decorators
{
    public class SlackDecorator : BaseDecorator
    {
        public SlackDecorator(INotifier notifier)
            : base(notifier)
        {

        }   

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine(" - via Slack.");
        }
    }
}
