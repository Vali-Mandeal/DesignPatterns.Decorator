﻿namespace DesignPatterns.Decorator.NotificationsDecorator
{
    public class BaseDecorator : INotifier
    {
        private readonly INotifier _notifier;

        public BaseDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }   
    }
}
