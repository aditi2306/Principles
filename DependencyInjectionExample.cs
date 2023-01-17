using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesExamples
{
    public class Customer
    {
        private Notifier notify;
        public Customer(Notifier notification)
        {
            this.notify = notification;
        }

        public void Job()
        {
            notify.Alert();
        }
    }

    public interface Notifier
    {
        void Alert();
    }

    public class EmailNotificaton : Notifier
    {
        public void Alert()
        {
            Console.WriteLine("Alert for Job fail");
        }
    }
}
