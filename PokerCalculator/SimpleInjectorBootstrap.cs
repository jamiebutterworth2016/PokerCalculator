using SimpleInjector;

namespace PokerCalculator
{
    public class SimpleInjectorBootstrap
    {
        public static void Start(Container container)
        {
            container.Register<ICacher, Cacher>();

            container.Register<ICardRetriever, CardRetriever>();

            container.Verify();
        }
    }
}