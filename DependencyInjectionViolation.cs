//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PrinciplesExamples
//{
   
//    public class Customer
//    {
//        private EmailNotificaton notify;
//        public Customer(EmailNotificaton notification)
//        {
//            //tightly coupled these two classes together
//            this.notify = notification;
//        }

//        public void Delivered()
//        {
//            notify.Alert();
//        }
//    }


//    public class EmailNotificaton
//    {
//        public void Alert()
//        {
//            Console.WriteLine("Package Delivered");
//        }
//    }
//}
