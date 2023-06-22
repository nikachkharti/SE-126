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

    }
}
