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
        private static readonly ICardConstructor _cardConstructor;

        static Program()
        {
            var container = new Container();
            SimpleInjectorBootstrap.Start(container);
            _cardConstructor = container.GetInstance<ICardConstructor>();
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first hole card:");

            var inputtedFirstHoleCard = Console.ReadLine();

            Console.WriteLine("Enter your second hole card:");

            var inputtedSecondHoleCard = Console.ReadLine();

            var firstHoleCard = _cardConstructor.ConstructCard(inputtedFirstHoleCard);

            var secondHoleCard = _cardConstructor.ConstructCard(inputtedSecondHoleCard);
        }
    }
}