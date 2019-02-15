using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    static class RevealCardsInIncreasingOrder
    {
        public static int[] Solve(int[] deck)
        {
            if (deck.Length <= 1)
            {
                return deck;
            }

            var sortedDeck = deck.OrderByDescending(x => x).ToList();

            var resultDeck = new List<int>(deck.Length);
            foreach (var card in sortedDeck)
            {
                if (resultDeck.Count > 0)
                {
                    var lastCard = resultDeck[resultDeck.Count - 1];
                    resultDeck.RemoveAt(resultDeck.Count - 1);
                    resultDeck.Insert(0, lastCard);
                }
                resultDeck.Insert(0, card);
            }
            return resultDeck.ToArray();
        }



    }
}
