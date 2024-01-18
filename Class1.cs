﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission1Assignment
{
    public class DiceSimulator
    {
        private List<int> results;

        public DiceSimulator()
        {
            results = new List<int>(new int[13]); // Indices 2 to 12 represent possible dice combinations
        }

        public List<int> SimulateRolls(int numberOfRolls)
        {
            Random random = new Random();

            for (int i = 0; i < numberOfRolls; i++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int sum = dice1 + dice2;

                results[sum]++;
            }

            return results;
        }
    }
}
