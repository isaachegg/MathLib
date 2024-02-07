namespace UnitTest;
using Math;
public class ArithTest
{
    //add method tests
    [Fact]
    public void Add_TwoPositiveIntegers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 7;
        int expectedResult = 12;

        // Act
        int result = Arith.add(a, b);

        // Assert
        Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Add_TwoPositiveDoubles_ReturnsCorrectSum()
    {
        // Arrange
        double a = 5.5;
        double b = 3.7;
        double expectedResult = 9.2;

        // Act
        double result = Arith.add(a, b);

        // Assert
        Assert.Equal(expectedResult, result, precision: 10); // Adjust precision as needed
    }
    [Fact]
    public void Add_PositiveAndNegativeDoubles_ReturnsCorrectSum()
    {
        // Arrange
        double a = 10.3;
        double b = -3.8;
        double expectedResult = 6.5;

        // Act
        double result = Arith.add(a, b);

        // Assert
        Assert.Equal(expectedResult, result, precision: 10); // Adjust precision as needed
    }
    [Fact]
    public void Add_TwoNegativeDoubles_ReturnsCorrectSum()
    {
        // Arrange
        double a = -8.6;
        double b = -5.2;
        double expectedResult = -13.8;

        // Act
        double result = Arith.add(a, b);

        // Assert
        Assert.Equal(expectedResult, result, precision: 10); // Adjust precision as needed
    }

    //exp method tests

    [Fact]
    public void Exp_PositiveBaseAndPositiveExponent_ReturnsCorrectResult()
    {
        // Arrange
        double baseValue = 2;
        int exponent = 3;
        double expectedResult = 8;

        // Act
        double result = Arith.exp(baseValue, exponent);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Exp_PositiveBaseAndZeroExponent_ReturnsCorrectResult()
    {
        // Arrange
        double baseValue = 5;
        int exponent = 0;
        double expectedResult = 1;

        // Act
        double result = Arith.exp(baseValue, exponent);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Exp_NegativeBaseAndPositiveExponent_ReturnsCorrectResult()
    {
        // Arrange
        double baseValue = -2;
        int exponent = 2;
        double expectedResult = 4;

        // Act
        double result = Arith.exp(baseValue, exponent);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Exp_ZeroBaseAndPositiveExponent_ReturnsCorrectResult()
    {
        // Arrange
        double baseValue = 0;
        int exponent = 5;
        double expectedResult = 0;

        // Act
        double result = Arith.exp(baseValue, exponent);

        // Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Exp_ZeroBaseAndNegativeExponent_ReturnsInfinity()
    {
        // Arrange
        double baseValue = 0;
        int exponent = -3;
        double expectedResult = double.PositiveInfinity;

        // Act
        double result = Arith.exp(baseValue, exponent);

        // Assert
        Assert.Equal(expectedResult, result);
    }

}