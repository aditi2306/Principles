using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesExamples
{
    public class Customer
    {
        private EmailNotificaton notify;
        public Customer(EmailNotificaton notification)
        {
            this.notify = notification;
        }

        public void Job()
        {
            notify.Alert();
        }
    }


    public class EmailNotificaton
    {
        public void Alert()
        {
            Console.WriteLine("Alert for Job fail");
        }
    }
}
