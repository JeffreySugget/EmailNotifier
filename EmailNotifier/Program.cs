using EmailNotifier.Interfaces;
using Unity;
using EmailNotifier.DependancyInjection;

namespace EmailNotifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: move DI code to own class
            var container = new UnityContainer();
            ContainerConfig.ConfigureContainer(container);

            var dataProcessor = container.Resolve<IDataProcessor>();

            dataProcessor.ProcessShows();
            dataProcessor.ProcessOtherShows();
        }
    }
}
