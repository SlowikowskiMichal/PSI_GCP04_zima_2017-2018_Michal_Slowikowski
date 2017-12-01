﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen3
{
    class DataProvider
    {
        private const int NumberOfFields = 64;
        private const int NumberOfFieldsX = 8;
        private const int NumberOfFieldsY = 8;

        public static double[,,] Data = {
            {
                { 0,0,0.66,0.66,0.66,0.66,0,0 },
                { 0,0.66,0.33,0.33,0.33,0.33,0.66,0 },
                { 0.66,0.33,1,0.33,0.33,1,0.33,0.66 },
                { 0.66,0.33,0.33,0.33,0.33,0.33,0.33,0.66 },
                { 0.66,0.33,1,0.33,0.33,1,0.33,0.66 },
                { 0.66,0.33,0.33,1,1,0.33,0.33,0.66 },
                { 0,0.66,0.33,0.33,0.33,0.33,0.66,0 },
                { 0,0,0.66,0.66,0.66,0.66,0,0 }
            },

            {
                { 0,0,0.66,0.66,0.66,0.66,0,0 },
                { 0,0.66,0.33,0.33,0.33,0.33,0.66,0 },
                { 0.66,0.33,1,0.33,0.33,1,0.33,0.66 },
                { 0.66,0.33,0.66,0.33,0.33,0.66,0.33,0.66 },
                { 0.66,0.33,0.66,0.33,0.33,0.66,0.33,0.66 },
                { 0.66,0.33,0.33,1,1,0.33,0.33,0.66 },
                { 0,0.66,1,0.33,0.33,1,0.66,0 },
                { 0,0,0.66,0.66,0.66,0.66,0,0 }
            },

            {
                { 0,0,0.66,0.66,0.66,0.66,0,0 },
                { 0,0.66,0.33,0.33,1,1,0.66,0 },
                { 0.66,0.33,1,0.33,1,1,0.33,0.66 },
                { 0.66,0.33,1,0.33,1,1,0.33,0.66 },
                { 0.66,0.33,0.33,0.33,0.33,0.33,0.33,0.66 },
                { 0.66,0.33,1,1,1,1,0.33,0.66 },
                { 0,0.66,0.33,0.33,0.33,0.33,0.66,0 },
                { 0,0,0.66,0.66,0.66,0.66,0,0 }
            },

            {
                { 0,0.66,0.66,0.66,0.66,0.66,0,0 },
                { 0.66,0.33,0.33,1,0.33,0.33,0.66,0 },
                { 0.66,1,0.33,1,0.33,0.33,0.33,0.66 },
                { 0.66,1,0.33,0.33,0.33,1,0.33,0.66 },
                { 0.66,0.33,0.33,1,1,0.33,0.33,0.66 },
                { 0.66,0.33,1,0.33,0.33,0.33,0.33,0.66 },
                { 0.66,1,1,1,1,1,0.33,0.66 },
                { 0,0.66,0.66,0.66,0.66,0.66,0.66,0 }
            }
        };
        public static double[] GetData(int number, double[,,] data)
        {
            double[] result = new double[NumberOfFields];
            for (int i = 0; i < NumberOfFieldsY; i++)
            {
                for (int j = 0; j < NumberOfFieldsX; j++)
                {
                    result[i * NumberOfFieldsX + j] = data[number, i, j];
                }
            }

            return result;
        }
    }
}
