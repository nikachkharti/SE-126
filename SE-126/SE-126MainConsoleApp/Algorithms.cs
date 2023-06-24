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
    }
}
