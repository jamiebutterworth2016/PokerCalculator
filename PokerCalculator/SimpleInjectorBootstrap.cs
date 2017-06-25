using SimpleInjector;

namespace PokerCalculator
{
    public class SimpleInjectorBootstrap
    {
        public static void Start(Container container)
        {
            container.Register<ICardConstructor, CardConstructor>();
            container.Verify();
        }
    }
}