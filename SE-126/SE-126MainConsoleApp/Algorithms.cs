using System.Text.Json;

//დელეგატი
public delegate bool CompareDelegate<T>(T parameter);
public delegate void DisplayDelegate<T>(T text); //action
public delegate TResult Transformer<TSource, TResult>(TSource source, TResult result);

namespace SE_126MainConsoleApp
{
    public static class Algorithms
    {
        public static void PrintInformation<T>(DisplayDelegate<T> displayDelegate, T text)
        {
            displayDelegate(text);
        }

        public static TResult[] Select<TSource, TResult>(TSource[] data, Transformer<TSource, TResult> selector)
        {
            TResult[] parsedData = new TResult[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                selector(data[i], parsedData[i]);
            }

            return parsedData;
        }

        public static Car[] Sort(Car[] cars)
        {
            for (int i = 0; i < cars.Length - 1; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[j].Combined > cars[i].Combined)
                    {
                        Car tempCar = cars[j];
                        cars[j] = cars[i];
                        cars[i] = tempCar;
                    }
                }
            }

            return cars;
        }

        public static T FirstOrDefault<T>(T[] collection, CompareDelegate<T> comparerDelegate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerDelegate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static List<T> Where<T>(T[] collection, CompareDelegate<T> comparerDelegate)
        {
            List<T> result = new();
            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerDelegate(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static T[] Take<T>(T[] collection, int quantity)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < quantity; i++)
            {
                result.Add(collection[i]);
            }

            return result.ToArray();
        }


        public static T[] Take<T>(T[] collection, CompareDelegate<T> comparerDelegate, int quantity)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < quantity; i++)
            {
                if (comparerDelegate(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
        }

        public static int FindIndex<T>(List<T> intList, CompareDelegate<T> comparer)
        {
            for (int i = 0; i < intList.Count(); i++)
            {
                if (comparer(intList[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public static int FindLastIndex<T>(T[] cars, T element)
        {
            for (int i = cars.Length - 1; i >= 0; i--)
            {
                if (cars[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public static T LastOrDefault<T>(T[] cars, T model)
        {
            for (int i = cars.Length - 1; i >= 0; i--)
            {
                if (cars[i].Equals(model))
                {
                    return cars[i];
                }
            }
            return default;
        }
        public static T[] Reverse<T>(T[] intArray)
        {
            Stack<T> result = new();
            for (int i = 0; i < intArray.Length; i++)
            {
                result.Push(intArray[i]);
            }

            return result.ToArray();
        }
        public static bool Any<T>(T[] intArray, T element)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All<T>(T[] intArray, T element)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (!intArray[i].Equals(element))
                {
                    return false;
                }
            }
            return true;
        }
        public static int Count<T>(T[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                count++;
            }

            return count;
        }
        public static bool IsEmpty<T>(T[] intArray)
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

        //TODO გასატესტი
        public static string ToJson<T>(T[] cars, bool intended = true) => JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = intended });
        //TODO გასატესტი
        public static T FromJson<T>(string data) => JsonSerializer.Deserialize<T>(data);
        //TODO გასატესტი
        public static List<T> FromJsonMany<T>(string data) => JsonSerializer.Deserialize<List<T>>(data);


        public static List<T> Concat<T>(T[] intAr1, T[] intAr2)
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
        public static List<T> Distinct<T>(T[] intCollection)
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
        public static List<T> Distinct<T>(List<T> intList)
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
