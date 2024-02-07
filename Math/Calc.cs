namespace Math;

public class Variable
{
    private double _coefficient { get; set; } = 1;
    private double _exponent { get; set; } = 0;
    private string _trig { get; set; } = "";

    public Variable(double coefficient, double exponent, string trig)
    {
        _coefficient = coefficient;
        _exponent = exponent;
        _trig = trig;
    }
}
public static class Calc
{

    public static List<Variable> parseEquation(string equation)
    {
        List<Variable> output = new List<Variable>();
        List<string> split = splitEquation(equation);
        for (int i = 0; i < split.Count; i++)
        {
            double exponent = 1;
            double coefficient = 1;

            string term = split[i];
            bool negative = false;
            if (term[0] == '-')
            {
                term = term.Substring(1);
                negative = true;
            }

            int indexOfX = findX(term);
            if (indexOfX == -1) 
            {
                coefficient = Convert.ToDouble(term);
            }
            else if (indexOfX == 0 && term.Length > 2)
            {
                exponent = Convert.ToDouble(term.Substring(2));
            }
            else if (indexOfX > 0 && term.Length - 1 > indexOfX)
            {
                coefficient = Convert.ToDouble(term.Substring(0, indexOfX));
                exponent = Convert.ToDouble(term.Substring(indexOfX + 2));
            }
            else if (indexOfX > 0)
            {
                coefficient = Convert.ToDouble(term.Substring(0, indexOfX));
            }

            if (negative)
            {
                coefficient = -coefficient;
            }
            Variable parsedTerm = new Variable(coefficient, exponent, "");
            output.Add(parsedTerm);
        }
        return output;
    }
    private static int findX(string term) {
        for (int i = 0; i < term.Length; i++) 
        {
            if (term[i] == 'x')
            {
                return i;
            }
        }
        return term.Length - 1;
    }

    public static List<string> splitEquation(string equation)
    {
        List<string> output = new List<string>();
        
        while (equation.Length > 0)
        {   
            if (equation[0] == '-') {
                equation = '-' + equation.Substring(1).Trim();
            }
            int right = findNextOpp(equation);
            if (right == equation.Length - 1) 
            {
                output.Add(equation);
                break;
            } 
            else 
            {
                output.Add(equation.Substring(0, right - 1));

                if (equation[right] == '+')
                {
                    equation = equation.Substring(right + 1).Trim();
                } 
                else
                {
                    equation = equation.Substring(right).Trim();
                }
            }
        }
        return output;
    }

    private static int findNextOpp(string equation) {
        for (int i = 1; i < equation.Length; i++) 
        {
            if (equation[i] == '+' || equation[i] == '-')
            {
                return i;
            }
        }
        return equation.Length - 1;
    }
}