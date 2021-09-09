// C# program to find the
// largest number that can
// be formed from given sum
// of digits and number of digits
using System;

class GFG
{

    // Function to print the 
    // largest possible number
    // with digit sum 's' and
    // 'm' number of digits
    static void findLargest(int m, int s)
    {
        // If sum of digits is 0,
        // then a number is possible
        // only if number of digits is 1
        if (s == 0)
        {
            Console.Write(m == 1 ?
                   "Largest number is 0" :
                          "Not possible");

            return;
        }

        // Sum greater than the
        // maximum possible sum
        if (s > 2 * m)
        {
            Console.WriteLine("Not possible");
            return;
        }

        // Create an array to
        // store digits of result
        int[] res = new int[m];

        // Fill from most significant
        // digit to least significant digit
        for (int i = 0; i < m; i++)
        {
            // Fill 2 first to make
            // the number largest
            if (s >= 2)
            {
                res[i] = 2;
                s -= 2;
            }

            // If remaining sum becomes
            // less than 2, then
            // fill the remaining sum
            else
            {
                res[i] = s;
                s = 0;
            }
        }

        Console.Write("Largest number is ");
        for (int i = 0; i < m; i++)
            Console.Write(res[i]);
    }

    // Driver Code
    static public void Main()
    {
        int s = 2, m = 12;
        findLargest(m, s);
    }
}