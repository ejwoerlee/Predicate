using System;
using System.Collections.Generic;

namespace PredicateTest
{
    public static class extensions
    {
        static public int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            int count = 0;
            foreach(TSource element in source) {
                if (predicate(element)) {
                    count++;
                }
            }
            return count;
        }
    }
}