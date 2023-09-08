using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using UsingMediatrCQRS.DataStore;

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
            await _dummyDataStore.EventOccured(notification.person, "Email Sent!");
            await Task.CompletedTask;
        }
    }
}
