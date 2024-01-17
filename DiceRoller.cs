using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    public class DiceRoller
    {
        public Random random = new Random();

        public int[] SimulateRolls(int numberOfRolls)
        {
            int[] results = new int[13];

            // simulate each roll
            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = random.Next(1, 7); //6 sides on a die
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                // add the sum to results
                results[sum]++;
            }

            return results;
        }
    }
}
