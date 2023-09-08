using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using UsingMediatrCQRS.DataStore;

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
            await _dummyDataStore.EventOccured(notification.person, "Sms Sent!");
            await Task.CompletedTask;
        }
    }
}
