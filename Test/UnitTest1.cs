using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1;

public class Tests {
    [SetUp]
    public void Setup() {
    }
    
    // Test 1
    [Test]
    public void TestOne() {
        // Arrange
        var array = new int[1] { 1 };
        // Act
        var result = Tools.Solution(array);
        // Assert
        Assert.AreEqual(result, new int[] { 0, 1 });
    }

    [Test]
    public void TestArrayIndividuals() {
        // Arrange
        int[] array = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Act
        int[] result = Tools.Solution(array);
        // Assert
        CollectionAssert.AreEqual(result, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
    }
    
    
}