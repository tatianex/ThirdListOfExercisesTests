using System;

namespace Domain
{
    public class Exercises
    {
        public (int[] a, int[] b) Exercise1(int[] a, int[] b)
        {
            var c = new int[5];

            for (int i = 0; i < 5; i++) c[i] = a[i];
            for (int j = 0; j < 5; j++) a[j] = b[j];
            for (int k = 0; k < 5; k++) b[k] = c[k];

            return (a, b);
        }
    }
}