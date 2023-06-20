namespace SE_126MainConsoleApp
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public int City { get; set; }
        public int Combined { get; set; }
        public int Highway { get; set; }

        public static Car Parse(string input)
        {
            string[] splitedInput = input.Split(',');

            if (splitedInput.Length != 9)
                throw new FormatException("Input is in incorrect format");

            Car result = new Car();
            result.Make = splitedInput[0];
            result.Model = splitedInput[1];
            result.Cylinder = int.Parse(splitedInput[2]);
            result.Engine = float.Parse(splitedInput[3]);
            result.Drive = splitedInput[4];
            result.Transmission = splitedInput[5];
            result.City = int.Parse(splitedInput[6]);
            result.Combined = int.Parse(splitedInput[7]);
            result.Highway = int.Parse(splitedInput[8]);

            return result;
        }

    }
}
