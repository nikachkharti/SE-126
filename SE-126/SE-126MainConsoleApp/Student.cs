namespace SE_126MainConsoleApp
{
    public class Student
    {
        public string firstName;
        public string lastName;

        private string pin;
        private int age; // ენკაფსულაცია

        public void SetPin(string value)
        {
            if (value.Length == 11)
            {
                pin = value;
            }
        }

        public string GetPin()
        {
            return pin;
        }
        public void SetAge(int value)
        {
            if (value > 0)
            {
                age = value;
            }
        }

        public int GetAge()
        {
            return age;
        }
    }
}
