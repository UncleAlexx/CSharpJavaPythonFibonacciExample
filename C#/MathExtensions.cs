namespace Extensions;

public static class MathExtensions
{
    extension(Math)
    {
        public static ulong GetFibonacciNumber(ulong n, ulong rightTerm = 0, ulong leftTerm = 1, bool flag = true)
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThan(n, 94ul, nameof(n));
            if (n > 1)
                flag = false;
            if ((n & 0xFFFFFFFFFFFFFFFE) == 0)
                return flag ? n : rightTerm;
            return GetFibonacciNumber(n - 1, leftTerm + rightTerm, 
                rightTerm == 0 ? leftTerm : rightTerm, flag);
        }
    }
}