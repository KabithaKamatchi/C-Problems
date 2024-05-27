using Practice_ProblemsLogic;

namespace Practice_ProblemsLogic.Test;

[TestClass]
public class SayingHelloTest
{
    #region Tests
    [TestMethod]
    public void Test_SayingHello()
    {
        // Arrange
        const string AUTHOR_NAME = "Brian";

        // Act
        string strMessage = SayingHello.Solution(AUTHOR_NAME);

        // Assert
        Assert.AreEqual("Hello Brian, nice to meet you!", strMessage);
     }
    #endregion
}