namespace UnitTest;
using Math;
using Newtonsoft.Json;

public class CalcTest
{
    [Fact]
    public void splitEquation_OneVariable() {
        string test = "x";
        string[] equation = {"x"};
        List<string> expected = new List<string>(equation);
        List<string> actual = Calc.splitEquation(test);
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void splitEquation_SimpleTest() {
        string test = "x + 1";
        string[] equation = {"x", "1"};
        List<string> expected = new List<string>(equation);
        List<string> actual = Calc.splitEquation(test);
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void SplitEquation_EquationWithCoefficients()
    {
        string test = "3x + 4y - 2z";
        string[] equation = { "3x", "4y", "-2z" };
        List<string> expected = new List<string>(equation);
        List<string> actual = Calc.splitEquation(test);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SplitEquation_EquationWithTrigonometricFunctions()
    {
        string test = "-x^2 - 3x^3 - 2x - 3";;
        string[] equation = { "-x^2", "-3x^3", "-2x",  "-3"};
        List<string> expected = new List<string>(equation);
        List<string> actual = Calc.splitEquation(test);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SplitEquation_EquationWithMultipleTerms()
    {
        string test = "x^2 + 3x + 2";
        string[] equation = { "x^2", "3x", "2" };
        List<string> expected = new List<string>(equation);
        List<string> actual = Calc.splitEquation(test);
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void ParseEquation_OneVariable()
    {
        string test = "x";
        Variable a = new Variable(1, 1,"");
        Variable[] equation = { a };
        List<Variable> expected = new List<Variable>(equation);
        List<Variable> actual = Calc.parseEquation(test);
        var expectedStr = JsonConvert.SerializeObject(expected);
        var actualStr = JsonConvert.SerializeObject(actual);
        Assert.Equal(expectedStr, actualStr);
    }
    [Fact]
    public void ParseEquation_basic()
    {
        string test = "x^2 + 3x^3 + 2x + 3";
        Variable a = new Variable(1, 2,"");
        Variable b = new Variable(3, 3,"");
        Variable c = new Variable(2, 1,"");
        Variable d = new Variable(3, 0,"");
        Variable[] equation = { a, b, c, d };
        List<Variable> expected = new List<Variable>(equation);
        List<Variable> actual = Calc.parseEquation(test);
        var expectedStr = JsonConvert.SerializeObject(expected);
        var actualStr = JsonConvert.SerializeObject(actual);
        Assert.Equal(expectedStr, actualStr);
    }
    [Fact]
    public void ParseEquation_BasicWithNegatives()
    {
        string test = "-x^2 - 3x^3 - 2x - 3";
        Variable a = new Variable(-1, 2,"");
        Variable b = new Variable(-3, 3,"");
        Variable c = new Variable(-2, 1,"");
        Variable d = new Variable(-3, 0,"");
        Variable[] equation = { a, b, c, d };
        List<Variable> expected = new List<Variable>(equation);
        List<Variable> actual = Calc.parseEquation(test);
        var expectedStr = JsonConvert.SerializeObject(expected);
        var actualStr = JsonConvert.SerializeObject(actual);
        Assert.Equal(expectedStr, actualStr);
    }
}