using DependencyInjection.Service;

namespace DependencyInjection.Implementation
{
    public class DoSomethingWorker
    {
        private readonly IDoSomethingService _doSomething;

        public DoSomethingWorker(IDoSomethingService doSomething)
        {
            _doSomething = doSomething;
        }

        public string DoSomething(string thing)
        {
            return _doSomething.DoSomething(thing);
        }

    }
}
