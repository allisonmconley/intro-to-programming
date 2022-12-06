namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact] // Attributes
        public void TestingTheAdditionOperatorOnIntegers()
        {
            // Given (Arrange)
            int a = 10, b = 20, answer;
            // When (Act)
            answer = a + b;
            // Then (Assert)
            Assert.Equal(30, answer);
        }
    }
}