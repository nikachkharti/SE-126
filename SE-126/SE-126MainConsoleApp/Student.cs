namespace SE_126MainConsoleApp
{
    public class Student
    {
        public string firstName;
        public string lastName;

        public string pin;

        private int age; // ენკაფსულაცია
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
