﻿namespace VsLiveRedmond.Api
{
    public class Calculator
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Divide(int value1, int value2)
        {
            // This is an example of exercise both successful paths
            // and failure paths.
            if (value2 == 0)
            {
                throw new InvalidOperationException();
            }

            return value1 / value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}