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
            //decoupled and communicate through the Notifier abstraction
            this.notify = notification;
        }

        public void Delivered()
        {
            notify.Alert();
        }
    }
    // dependency injection pattern to facilitate adding the Notifier dependency
    public interface Notifier
    {
        void Alert();
    }

    public class EmailNotificaton : Notifier
    {
        public void Alert()
        {
            Console.WriteLine("Package Delivered");
        }
    }
}
