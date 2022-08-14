using System;

namespace PickCardUI
{
    internal static class CardsPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            var pickedCards = new string[numberOfCards];
            for (var i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }


            return pickedCards;
        }



        private static string RandomSuit()
        {
            var value = random.Next(1, 5);

            if (value == 1)
            {
                return "Spades";
            }

            if (value == 2)
            {
                return "Hearts";
            }

            if (value == 3)
            {
                return "Spades";
            }


            return "Diamonds";

        }

        private static string RandomValue()
        {
            var value = random.Next(1, 14);
            if (value == 1)
            {
                return "Ace";
            }

            if (value == 11)
            {
                return "Jack";
            }

            if (value == 12)
            {
                return "Queen";
            }

            if (value == 13)
            {
                return "King";
            }

            if (value > 14)
            {
                return "Wrong number";
            }

            return value.ToString();
        }
    }
}
