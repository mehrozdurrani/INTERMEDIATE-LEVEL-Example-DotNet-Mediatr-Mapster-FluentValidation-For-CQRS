using MediatR;
using UsingMediatrCQRS.DataStore;
using UsingMediatrCQRS.Model;

namespace UsingMediatrCQRS.Notifications
{
    public class SmsHandler : INotificationHandler<PersonRegisterNotification>
    {
        private readonly DummyDataStore _dummyDataStore;

        public SmsHandler(DummyDataStore dummyDataStore)
        {
            _dummyDataStore = dummyDataStore;
        }

        public async Task Handle(
            PersonRegisterNotification notification,
            CancellationToken cancellationToken
        )
        {
            NotificationEvent ev = NotificationEvent.Create("SMS Event");
            await _dummyDataStore.PersonRegisterEventOccured(notification.person, ev);
            notification.events.Add(ev);
            await Task.CompletedTask;
        }
    }
}
