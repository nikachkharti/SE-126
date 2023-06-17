
namespace SE_126MainConsoleApp
{
    public class Person
    {
        //Auto 
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Full
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }


        private string pin;
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


    }
}
