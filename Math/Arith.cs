namespace Math;

public static class Arith
{
    /// <summary>
    /// Add two numbers
    /// </summary>
    /// <param name="one"></param>
    /// <param name="two"></param>
    /// <returns></returns>
    public static int add(int one, int two) => (one + two);
    public static double add(double one, double two) => (one + two);
    public static double exp(double baseNum, int exponent) {
        double output = 1;
        if (baseNum == 0 && exponent < 0) {return Double.PositiveInfinity;}
        for (int i = 0; i < exponent; i++) {
            output *= baseNum;
        }
        return output;
    }
}
