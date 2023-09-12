using MediatR;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Notifications
{
    public class EmailHandler : INotificationHandler<PersonRegisterNotification>
    {
        private readonly DummyDataStore _dummyDataStore;

        public EmailHandler(DummyDataStore dummyDataStore)
        {
            _dummyDataStore = dummyDataStore;
        }

        public async Task Handle(
            PersonRegisterNotification notification,
            CancellationToken cancellationToken
        )
        {
            NotificationEvent ev = NotificationEvent.Create("Email Event");
            await _dummyDataStore.PersonRegisterEventOccured(notification.person, ev);
            notification.events.Add(ev);
            await Task.CompletedTask;
        }
    }
}
