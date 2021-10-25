using DesignPatterns.Decorator.NotificationsDecorator;
using DesignPatterns.Decorator.NotificationsDecorator.Decorators;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main()
        {
            NotifyTeams("Deadline was yesterday!");

            NotifyManagers("The budgets are just fine!");

            NotifyOutage("We have a decentralized surprise backup!");
        }

        private static void NotifyTeams(string message)    
        {
            INotifier notifier = new Notifier();

            INotifier teamsDecorator = new TeamsDecorator(notifier);
            INotifier slackDecorator = new SlackDecorator(teamsDecorator);

            slackDecorator.Send(message);
        }

        private static void NotifyManagers(string message)
        {
            INotifier notifier = new Notifier();

            INotifier emailDecorator = new EmailDecorator(notifier);
            INotifier smsDecorator = new SmsDecorator(emailDecorator);

            smsDecorator.Send(message);
        }

        private static void NotifyOutage(string message)
        {
            INotifier notifier = new Notifier();

            INotifier emailDecorator = new EmailDecorator(notifier);
            INotifier teamsDecorator = new TeamsDecorator(emailDecorator);
            INotifier slackDecorator = new SlackDecorator(teamsDecorator);
            INotifier smsDecorator = new SmsDecorator(slackDecorator);

            smsDecorator.Send(message);
        }
    }   
}
    