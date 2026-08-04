import java.util.logging.Logger;

import static java.lang.IO.*;
import java.io.IOException;

class Program
{
    static int GetFactorialTerm(int n)
    {
        if (n < 2)
            return n;
        return GetFactorialTerm(n - 1) + GetFactorialTerm(n - 2);
    }

    public static void main(String[] args) throws IOException
    {
        println(GetFactorialTerm(Integer.parseInt(args[0])));
    }
}
