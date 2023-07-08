using SE_126MainConsoleApp;
using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace SE_126MainConsoleApp
{
    //ჩაშენებული დელეგატები
    //Action --- მუშაობს void ტიპის მეთოდებთან
    //Func --- მუშაობს ისეთ მეთოდენთაბ რომელსაც აქვს დასაბრუნებელი ტიპი
    //Predicate --- მუშაობს ისეთ მეთოდენთაბ რომელიც აბრუნებს bool -ს


    public static class Algorithms
    {
        public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
            {
                yield return selector(item);
            }
        }
        public static T FirstOrDefault<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }

        public static List<T> Where<T>(this T[] cars, Predicate<T> searchCondition)
        {
            List<T> result = new();

            for (int i = 0; i < cars.Length; i++)
            {
                if (searchCondition(cars[i]))
                {
                    result.Add(cars[i]);
                }
            }

            return result;
        }
        public static T[] Sort<T>(this T[] collection, Func<T, T, bool> comparer)
        {
            for (int i = 0; i < collection.Length - 1; i++)
            {
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (comparer(collection[j], collection[i]))
                    {
                        T temp = collection[j];
                        collection[j] = collection[i];
                        collection[i] = temp;
                    }
                }
            }

            return collection;
        }
        public static T[] Take<T>(this T[] cars, int quantity)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < quantity; i++)
            {
                result.Add(cars[i]);
            }

            return result.ToArray();
        }

        public static IEnumerable<T> NikasForeach<T>(this IEnumerable<T> source)
        {
            IEnumerator<T> sourceEnumerator = source.GetEnumerator();
            while (sourceEnumerator.MoveNext())
            {
                //if (sourceEnumerator.Current.Equals(-20))
                //{
                //    yield break;
                //}

                yield return sourceEnumerator.Current;
            }
        }
        public static int FindIndex<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            int index = 0;
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return index;
                }
                ++index;
            }
            return -1;
        }

        public static int FindLastIndex<T>(this T[] collection, Func<T, bool> predicate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public static T LastOrDefault<T>(this T[] collection, Func<T, bool> predicate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }
            return default;
        }
        public static T[] Reverse<T>(this T[] collection)
        {
            Stack<T> result = new();
            for (int i = 0; i < collection.Length; i++)
            {
                result.Push(collection[i]);
            }

            return result.ToArray();
        }
        public static bool Any<T>(this T[] collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All<T>(this T[] collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static int Count<T>(this T[] collection)
        {
            int count = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                count++;
            }

            return count;
        }
        public static int Count<T>(this T[] collection, Func<T, bool> predicate)
        {
            int count = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    count++;
                }
            }

            return count;
        }
        public static bool IsEmpty<T>(this T[] intArray)
        {
            //if (Count(intArray) == 0)
            //{
            //    return true;
            //}
            //return false;


            //ტერნარი
            //return Count(intArray) == 0 ? true : false;

            return Count(intArray) == 0;
        }
        public static string ToJson<T>(this T[] cars, bool intended = true) => JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = intended });
        public static T FromJson<T>(this string source) => JsonSerializer.Deserialize<T>(source);
        public static List<T> Concat<T>(this T[] intAr1, T[] intAr2)
        {
            List<T> result = new();

            for (int i = 0; i < intAr1.Length; i++)
            {
                result.Add(intAr1[i]);
            }

            for (int i = 0; i < intAr2.Length; i++)
            {
                result.Add(intAr2[i]);
            }

            return result;
        }
        public static List<T> Distinct<T>(this T[] intCollection)
        {
            List<T> uniqueElements = new();

            for (int i = 0; i < intCollection.Length; i++)
            {
                bool notUnique = false;
                for (int j = 0; j < intCollection.Length; j++)
                {
                    if (i != j && intCollection[i].Equals(intCollection[j]))
                    {
                        notUnique = true;
                        break;
                    }
                }

                if (!notUnique)
                {
                    uniqueElements.Add(intCollection[i]);
                }
            }

            return uniqueElements;
        }
        public static List<T> Distinct<T>(this List<T> intList)
        {
            HashSet<T> result = new();
            for (int i = 0; i < intList.Count; i++)
            {
                result.Add(intList[i]);
            }

            return result.ToList();
        }
    }
}
