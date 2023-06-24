namespace SE_126MainConsoleApp
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public byte Cylinder { get; set; }
        public float Engine { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public byte City { get; set; }
        public byte Combined { get; set; }
        public byte Highway { get; set; }

        public static Car Parse(string input)
        {
            string[] splitedInout = input.Split(',');

            Car result = new Car()
            {
                Make = splitedInout[0],
                Model = splitedInout[1],
                Cylinder = byte.Parse(splitedInout[2]),
                Engine = float.Parse(splitedInout[3]),
                Drive = splitedInout[4],
                Transmission = splitedInout[5],
                City = byte.Parse(splitedInout[6]),
                Combined = byte.Parse(splitedInout[7]),
                Highway = byte.Parse(splitedInout[8])
            };

            return result;
        }


        //public override string ToString()
        //{
        //    return $"{Make}-{Model}-{Cylinder}-{Engine}";
        //}
    }
}
