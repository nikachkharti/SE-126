namespace SE_126MainConsoleApp
{
    public class Client
    {
        private string pin;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pin
        {
            get { return pin; }
            set
            {
                if (value.Length == 11)
                {
                    pin = value;
                }
            }
        }

        public Account Account { get; set; }
    }
}
