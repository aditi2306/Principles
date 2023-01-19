using System;

namespace PrinciplesExamples
{
    public class BestCustomer
    {
        private ILogger logger;
        public BestCustomer(ILogger log)
        {
            //decoupled and communicate through the Notifier abstraction
            this.logger = log;
        }

        public void Delivered()
        {
            logger.Log();
        }
    }
    // dependency injection pattern to facilitate adding the Notifier dependency
    public interface ILogger
    {
        void Log();
    }

    public class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Package Delivered");
        }
    }
}
