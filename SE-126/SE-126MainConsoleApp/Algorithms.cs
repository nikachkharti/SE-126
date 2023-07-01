using System.Text.Json;

namespace SE_126MainConsoleApp
{
    public static class Algorithms
    {
        public static Car[] Select(string[] data)
        {
            Car[] parsedData = new Car[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                parsedData[i] = Car.Parse(data[i]);
            }

            return parsedData;
        }
        public static Car FirstOrDefault(Car[] cars, string name)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Make.Contains(name))
                {
                    return cars[i];
                }
            }

            return default;
        }
        public static List<Car> Where(Car[] cars, string name)
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
        public static Car[] Take(Car[] cars, int quantity)
        {
            List<Car> result = new List<Car>();

            for (int i = 0; i < quantity; i++)
            {
                result.Add(cars[i]);
            }

            return result.ToArray();
        }




        public static int FindIndex<T>(List<T> intList, T element)
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


        public static Car LastOrDefault(Car[] cars, string name)
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
        public static int[] Reverse(int[] intArray)
        {
            Stack<int> result = new();
            for (int i = 0; i < intArray.Length; i++)
            {
                result.Push(intArray[i]);
            }

            return result.ToArray();
        }
        public static bool Any(int[] intArray, int element)
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
        public static bool All(int[] intArray, int element)
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
        public static int Count(int[] intArray)
        {
            int count = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                count++;
            }

            return count;
        }
        public static bool IsEmpty(int[] intArray)
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
        public static string ToJson(Car[] cars, bool intended = true) => JsonSerializer.Serialize(cars, new JsonSerializerOptions { WriteIndented = intended });

        //TODO -- დაწერეთ FromJson მეთოდი
        public static List<int> Concat(int[] intAr1, int[] intAr2)
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
        public static List<int> Distinct(int[] intCollection)
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
        public static List<int> Distinct(List<int> intList)
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
