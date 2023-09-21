using xUnit_exercise;

namespace TestExercise
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "#_Hawthorne, Nathaniel (HAWNAT)";
            string actual = Methods.Formatter("nathaniel","haWthorNe");
            Assert.Equal(expected, actual);
            
        }

        [Fact]
        public void Test2()
        {
            string expected = "#_George, Elisabeth (GEOELI)";
            string actual = Methods.Formatter("ELisabeth", "GEorge");
            Assert.Equal(expected, actual);

        }
    }
}