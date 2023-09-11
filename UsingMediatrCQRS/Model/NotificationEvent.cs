using System.Runtime.InteropServices;
using UsingMediatrCQRS.Queries;

namespace UsingMediatrCQRS.Model
{
    public class NotificationEvent
    {
        public string? Name { get; private set; }
        public bool EventIsCompleted { get; private set; }

        private NotificationEvent(string name, bool eventIsCompleted)
        {
            Name = name;
            EventIsCompleted = eventIsCompleted;
        }

        public static NotificationEvent Create(string name)
        {
            return new(name, false);
        }

        public void MarkEventAsCompelete()
        {
            EventIsCompleted = true;
        }
    }
}
