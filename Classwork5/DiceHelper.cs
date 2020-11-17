using System;

namespace Classwork5
{
    public static class DiceHelper
    {
        /// <summary>
        /// Returns xdy summ result
        /// </summary>
        /// <param name="x">number of dices</param>
        /// <param name="y">number of sides</param>
        /// <returns></returns>
        public static int ThrowDices(int x, int y)
        {
            int result = 0;
            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                var diceValue = random.Next(y) + 1;
                result += diceValue;
                Console.WriteLine(diceValue);
            }

            return result;
        }
    }
}
