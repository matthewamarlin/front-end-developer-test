using System;
using System.Linq;
using System.Collections.Generic;

namespace Question2
{
    public class Intersection
    {
        public static int[] FindIntersectionLinq(int[] arr1, int[] arr2)
        {
            return arr1.Intersect(arr2).ToArray();
        }

        public static int[] FindIntersection(int[] arr1, int[] arr2)
        {
            if (arr1 == null) throw new ArgumentNullException("first");
            if (arr2 == null) throw new ArgumentNullException("second");

            return Intersect(arr1, arr2, null).ToArray();
        }

        public static IEnumerable<TSource> Intersect<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            var set = new HashSet<TSource>(comparer);
            foreach (TSource element in second) set.Add(element);
            foreach (TSource element in first)
                if (set.Remove(element)) yield return element;
        }
    }
}
