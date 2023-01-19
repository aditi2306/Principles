using System;

namespace PrinciplesExamples
{
    public class Customer
    {
        private Loggers logger;
        public Customer(Loggers log)
        {
            //tightly coupled these two classes together
            this.logger = log;
        }

        public void Delivered()
        {
            logger.Log();
        }
    }
    public class Loggers 
    {
        public void Log()
        {
            Console.WriteLine("Package Delivered");
        }
    }
}
