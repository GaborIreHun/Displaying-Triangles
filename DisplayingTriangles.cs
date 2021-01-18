using System;


class DisplayingTriangles
{
    static void Main()
    {
        // first triangle outer loop
        for (int a = 0; a < 10; ++a) 
        {
            // first triangle inner loop       
            for (int b = 1; b <= a + 1; ++b)
            {
                Console.Write("*");
            }

            Console.WriteLine();
                       
        }
        Console.WriteLine();


        // second triangle outer loop
        for (int c = 10; c > 0; --c)
        {
            // second triangle inner loop
            for (int d = 1; d <= c; ++d)
            {
                Console.Write("*");
            }            
            Console.WriteLine();

        }
        Console.WriteLine();


        // integer for third triangle loops
        int f;
        // third triangle outer loop
        for (int e = 0; e < 10; ++e)
        {
            // third triangle inner loop for whitespace
            for (f = 2; f <= e + 1; ++f)
            {
                Console.Write(" ");
            }

            // third triangle inner loop for body
            for (int g = 11; g > f-1; --g)
            {
                Console.Write("*");   
            }
            Console.WriteLine();

        }
        Console.WriteLine();


        // integer for fourth triangle loops
        int i;
        // outer loop for fourth triangle
        for (int h = 10; h > 0; --h)
        {
            // inner loop for fourth triangle whitespace
            for (i = 2; i <= h; ++i)
            {
                Console.Write(" ");
            }

            // inner loop for fourth triangle body
            for (int g = 11; g > i - 1; --g)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();        
    }
}

