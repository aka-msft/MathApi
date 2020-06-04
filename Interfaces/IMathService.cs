namespace MathApi.Interfaces
{
    public interface IMathService
    {
        public int GetAdd(int x, int y);

        public int GetSubtract(int x, int y);

        public int GetMultiply(int x, int y);

        public double GetDivide(double x, double y);
    }
}
