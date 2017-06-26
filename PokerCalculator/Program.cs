using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace PokerCalculator
{
    static class Program
    {
        private static readonly ICacher _cacher;
        private static readonly ICardRetriever _cardRetriever;

        static Program()
        {
            var container = new Container();
            SimpleInjectorBootstrap.Start(container);
            _cacher = container.GetInstance<ICacher>();
            _cardRetriever = container.GetInstance<ICardRetriever>();
        }

        static void Main(string[] args)
        {
            _cacher.CacheDeck();

            Console.WriteLine("Enter your first hole card:");
            var inputtedFirstHoleCard = Console.ReadLine();

            var firstHoleCard = _cardRetriever.RetrieveCard(inputtedFirstHoleCard);

            _cacher.RemoveCard(firstHoleCard);
            
            Console.WriteLine("Enter your second hole card:");
            var inputtedSecondHoleCard = Console.ReadLine();

            var secondHoleCard = _cardRetriever.RetrieveCard(inputtedSecondHoleCard);

            _cacher.RemoveCard(secondHoleCard);

            _cacher.Dispose();
        }
    }
}