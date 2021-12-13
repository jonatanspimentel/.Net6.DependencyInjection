using DependencyInjection.Repository;

namespace DependencyInjection.Service
{
    public class DoSomethingService : IDoSomethingService
    {
        private readonly IDoSomethingRepository _doSomethingRepository;

        public DoSomethingService(IDoSomethingRepository doSomethingRepository)
        {
            _doSomethingRepository = doSomethingRepository;
        }

        public string DoSomething(string thing)
        {
            bool thingIsDone = _doSomethingRepository.RegisterSomething(thing);

            if (thingIsDone)
                return $"The {thing} is Done!";
            else
                return "Something wrong!";
        }
    }
}