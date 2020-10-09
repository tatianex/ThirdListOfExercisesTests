using System;

namespace ThirdListOfExercisesTests
{
    public class exercise One
    {
        const int arraysLenght = 10;

        var a = new double[arraysLenght];
        var b = new double[arraysLenght];
        var c = new double[arraysLenght];

        var isValidNumber = false;

        for (int i = 0; i < arraysLenght; i++) c[i] = a[i];
        for (int j = 0; j < arraysLenght; j++) a[j] = b[j];
        for (int k = 0; k < arraysLenght; k++) b[k] = c[k];
    }
}