using System;

namespace FizzBuzz
{
    public class Program
    {
        private const char Nl = '\n';

        private const int NumberLimit = 30;
        private const int FizzStep = 3;
        private const int BuzzStep = 5;
        private const int MaxTextLength = 8; 

        public static void Main()
        {
            int maxNumberLength = CountDigits(NumberLimit);
            int maxLineLength = Math.Max(maxNumberLength, MaxTextLength) + 1; 

            char[] buffer = new char[maxLineLength * NumberLimit];

            int pos = 0;
            int nextFizz = FizzStep;
            int nextBuzz = BuzzStep;

            for (int i = 1; i <= NumberLimit; i++)
            {
                bool fizz = i == nextFizz;
                bool buzz = i == nextBuzz;

                if (fizz)
                {
                    buffer[pos++] = 'F';
                    buffer[pos++] = 'i';
                    buffer[pos++] = 'z';
                    buffer[pos++] = 'z';

                    nextFizz += FizzStep;
                }

                if (buzz)
                {
                    buffer[pos++] = 'B';
                    buffer[pos++] = 'u';
                    buffer[pos++] = 'z';
                    buffer[pos++] = 'z';

                    nextBuzz += BuzzStep;
                }

                if (!fizz && !buzz)
                {
                    pos = WriteNumber(buffer, pos, i);
                }

                buffer[pos++] = Nl;
            }

            Console.Out.Write(buffer, 0, pos);
        }

        private static int WriteNumber(char[] buffer, int pos, int value)
        {
            int start = pos;

            do
            {
                buffer[pos++] = (char)('0' + value % 10);
                value /= 10;
            }
            while (value > 0);

            for (int left = start, right = pos - 1; left < right; left++, right--)
            {
                char temp = buffer[left];
                buffer[left] = buffer[right];
                buffer[right] = temp;
            }

            return pos;
        }

        private static int CountDigits(int value)
        {
            int digits = 1;

            while ((value /= 10) > 0)
            {
                digits++;
            }

            return digits;
        }
    }
}
