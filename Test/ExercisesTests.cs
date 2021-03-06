using System;
using Domain;
using Xunit;

namespace ThirdListOfExercisesTests
{
    public class ExercisesTests
    {
        [Theory]
        [InlineData(new double[5]{0, 12, 15.4, 17, -2.9}, new double[5]{8.9, 94, -30, 18, 10})]
        [InlineData(new double[5]{2, -24.2, 45, -11, 4.8}, new double[5]{14, 22.2, -7, -20.5, -3})]
        public void should_return_the_numbers_changed_from_array_a_to_array_b(double[] a, double[] b)
        {
            var exercises = new Exercises();

            var result = exercises.Exercise1(a, b);

            var expected = (new double[5]{8.9, 94, -30, 18, 10}, new double[5]{0, 12, 15.4, 17, -2.9});

            Assert.Equal(expected, result);
        }
    }
}
