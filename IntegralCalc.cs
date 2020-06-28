namespace IntegralCalc
{
    class IntegralCalc
    {
        static public string RectangleMethod(string s, double ll, double ul, int knots)//Метод левых прямоугольников
        {
            double strand = (ul - ll) / (knots - 1);
            double pr = new double();
            for (int i = 1; i < knots; i++)
            {
                double a = ll + i * strand;
                string eqa = s.Replace("x", a.ToString());
                double resa = (Calculator.Calculate(eqa));
                pr += resa;
            }
            double result = strand * pr;
            return result.ToString();
        }
        static public string TrapetionMethod(string s, double ll, double ul, int knots)//Метод трапеций
        {
            double strand = (ul - ll) / (knots - 1);
            double result = new double();
            for (int i = 1; i < knots - 1; i++)
            {
                double a = ll + i * strand;
                double b = ll + (i + 1) * strand;
                string eqa = s.Replace("x", a.ToString());
                double resa = (Calculator.Calculate(eqa));
                string eqb = s.Replace("x", b.ToString());
                double resb = (Calculator.Calculate(eqb));
                result += (resb + resa) * (b - a) / 2;
            }
            return result.ToString();
        }
        static public string SimpsonMethod(string s, double ll, double ul, int knots)//Метод Симпсона
        {
            double strand = (ul - ll) / (knots - 1);
            double result = new double();
            for (int i = 1; i < knots - 1; i++)
            {
                double a = ll + i * strand;
                double b = ll + (i + 1) * strand;
                double m = (a+b) / 2;
                string eqa = s.Replace("x", a.ToString());
                double resa = Calculator.Calculate(eqa);
                string eqb = s.Replace("x", b.ToString());
                double resb = Calculator.Calculate(eqb);
                string eqm = s.Replace("x", m.ToString());
                double resm = Calculator.Calculate(eqm);
                result += (b - a) / 6 * (resa + 4 * resm + resb);
            }
            return result.ToString();
        }
    }
}
