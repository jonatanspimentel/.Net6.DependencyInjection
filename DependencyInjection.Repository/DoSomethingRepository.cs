namespace DependencyInjection.Repository
{
    public class DoSomethingRepository : IDoSomethingRepository
    {
        public bool RegisterSomething(string thing)
        {
            return !string.IsNullOrEmpty(thing);
        }
    }
}