using System;
using System.Collections.Generic;

namespace kort.domain.extensions
{
    public static class IListExtensions
    {
        public static IList<T> Shuffle<T>(this IList<T> deck)
        {
            deck.Shuffle<T>(new Random());
            return deck;
        }

        /// <summary>
        /// Fisher-Yates shuffle
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="rnd"></param>
        private static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            for (int i = 0; i < list.Count - 1; i++)
                list.Swap(i, rnd.Next(i, list.Count));
        }

        private static void Swap<T>(this IList<T> list, int i, int j)
        {
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}