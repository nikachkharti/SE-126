namespace Algorithms.Tests
{
    public class FirstOrDefaultShould
    {
        [Fact]
        public void Find_First_Element_In_Integer_IEnumerable()
        {
            List<int> intList = new() { 1, 2, -3, 15 };

            var actualResult = intList.CustomFirstOrDefault(x => x < 0);
            var expectedResult = -3;

            Assert.Equal(expectedResult, actualResult);
        }


        [Fact]
        public void Find_First_Element_In_String_Array()
        {
            string[] names = { "Nika", "Irakli", "Elene", "Giorgi" };

            var expectedResult = "Irakli";
            var actualResult = names.CustomFirstOrDefault(x => x.EndsWith("i"));

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Find_First_Element_In_Client_List()
        {
            List<Client> clients = new()
            {
                new(){FirstName = "Nika",LastName= "Chkhartishvili"},
                new(){FirstName = "Giorgi",LastName= "Menteshashvili"},
                new(){FirstName = "Giorgi",LastName= "Jobava"}
            };

            var expected = new Client() { FirstName = "Nika", LastName = "Chkhartishvili" };
            var actual = clients.CustomFirstOrDefault(x => x.FirstName != "Giorgi");

            Assert.Equal(expected, actual, new ClientEquilityComparer());
        }


    }
}
