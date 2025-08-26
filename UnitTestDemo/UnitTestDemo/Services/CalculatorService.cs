namespace UnitTestDemo.Services
{
    public class CalculatorService
    {
        public int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public double AddTwoDoubles(double x, double y)
        {
            return x + y;
        }

        public List<int> GetListOfNumbers()
        {
            List<int> numbers = new List<int>() { 1, 5, 87, 54, 65, 74, 32, 5, 6 };

            return numbers;
        }
    }
}
