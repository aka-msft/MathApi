using MathApi.Interfaces;
using System;

namespace MathApi.Services
{
    public class MathService: IMathService
    {
		public int GetAdd(int x, int y)
		{
            return x + y;
		}

        public int GetSubtract(int x, int y)
        {
            return x - y;
        }

        public int GetMultiply(int x, int y)
        {
            return x * y;
        }

        public double GetDivide(double x, double y)
        {
            return Math.Round((x / y), 2);
        }
    }
}