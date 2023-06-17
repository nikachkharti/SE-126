
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



        //public void SetAge(int value)
        //{
        //    if (value > 0)
        //    {
        //        age = value; 
        //    }
        //}

        //public int GetAge()
        //{
        //    return age;
        //}

    }
}
