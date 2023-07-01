using SE_126MainConsoleApp;
using System.Text.Json;

namespace SE_126MainConsoleApp
{
    public delegate bool SearchDelegate(Car carObj);
    public static class Algorithms
    {
        public static Car[] Select(this string[] data)
        {
            Car[] parsedData = new Car[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                parsedData[i] = Car.Parse(data[i]);
            }

            return parsedData;
        }

        public static Car FirstOrDefault(this Car[] cars, SearchDelegate searchCondition)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (searchCondition(cars[i]))
                {
                    return cars[i];
                }
            }

            return default;
        }


        public static List<Car> Where(this Car[] cars, string name)
        {
            List<Car> result = new();

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Make.Contains(name))
                {
                    result.Add(cars[i]);
                }
            }

            return result;
        }
        public static Car[] Sort(this Car[] cars)
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
        public static Car[] Take(this Car[] cars, int quantity)
        {
            List<Car> result = new List<Car>();

            for (int i = 0; i < quantity; i++)
            {
                result.Add(cars[i]);
            }

            return result.ToArray();
        }




        public static int FindIndex<T>(this List<T> intList, T element)
        {
            for (int i = 0; i < intList.Count(); i++)
            {
                if (intList[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public static int FindLastIndex<T>(this T[] cars, T element)
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


        public static Car LastOrDefault(this Car[] cars, string name)
        {
            for (int i = cars.Length - 1; i >= 0; i--)
            {
                if (cars[i].Make.Contains(name))
                {
                    return cars[i];
                }
            }
            return default;
        }
        public static int[] Reverse(this int[] intArray)
        {
            Stack<int> result = new();
            for (int i = 0; i < intArray.Length; i++)
            {
                result.Push(intArray[i]);
            }

            return result.ToArray();
        }
        public static bool Any(this int[] intArray, int element)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All(this int[] intArray, int element)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] != element)
                {
                    return false;
                }
            }
            return true;
        }
        public static int Count(this int[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                count++;
            }

            return count;
        }
        public static bool IsEmpty(this int[] intArray)
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
        public static string ToJson(this Car[] cars, bool intended = true) => JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = intended });
        public static T FromJson<T>(this string source) => JsonSerializer.Deserialize<T>(source);

        public static List<int> Concat(this int[] intAr1, int[] intAr2)
        {
            List<int> result = new();

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
        public static List<int> Distinct(this int[] intCollection)
        {
            List<int> uniqueElements = new();

            for (int i = 0; i < intCollection.Length; i++)
            {
                bool notUnique = false;
                for (int j = 0; j < intCollection.Length; j++)
                {
                    if (i != j && intCollection[i] == intCollection[j])
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
        public static List<int> Distinct(this List<int> intList)
        {
            HashSet<int> result = new();
            for (int i = 0; i < intList.Count; i++)
            {
                result.Add(intList[i]);
            }

            return result.ToList();
        }
    }
}
