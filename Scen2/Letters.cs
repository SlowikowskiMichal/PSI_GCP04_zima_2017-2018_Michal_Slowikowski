﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen2
{
    class Letters
    {
        public static int NumberOfFields = 6;
        public static int[] Expected = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //1 = Big letter, 0 - Small letter 

        public static int[,,,] LettersData = new int[,,,] {
            {
                {
                    {0,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1}
                },                  //A
                {
                    {0,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {0,1,1,1,1}
                },                  //C
                {
                    {1,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0}
                },                  //F
                {
                    {0,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {1,0,1,1,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {0,1,1,1,1}
                },                  //G
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },                  //I
                {
                    {1,0,0,0,1},
                    {1,1,0,0,1},
                    {1,1,1,0,1},
                    {1,0,1,0,1},
                    {1,0,0,1,1},
                    {1,0,0,1,1},
                    {1,0,0,0,1}
                },                  //N
                {
                    {0,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {0,1,1,1,0}
                },                  //O
                {
                    {1,1,1,1,0},
                    {1,0,0,0,1},
                    {1,0,0,0,1},
                    {1,1,1,1,0},
                    {1,0,1,0,0},
                    {1,0,0,1,0},
                    {1,0,0,0,1}
                },                  //R
                {
                    {0,1,1,1,1},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {0,1,1,1,0},
                    {0,0,0,0,1},
                    {0,0,0,0,1},
                    {1,1,1,1,0}
                },                  //S
                {
                    {1,1,1,1,1},
                    {0,0,0,0,1},
                    {0,0,0,1,0},
                    {0,0,1,0,0},
                    {0,1,0,0,0},
                    {1,0,0,0,0},
                    {1,1,1,1,1}
                },                  //Z
            },                      //Big Letters
            {
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {1,0,0,1,0},
                    {1,0,0,1,0},
                    {1,0,0,0,1}
                },                  //a
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {1,0,0,0,0},
                    {1,0,0,0,0},
                    {0,1,1,1,0}
                },                  //c
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,0,0,0},
                    {0,1,1,0,0},
                    {0,1,0,0,0},
                    {0,1,0,0,0}
                },                  //f
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {1,0,0,1,0},
                    {0,1,1,1,0},
                    {0,0,0,1,0},
                    {0,1,1,1,0}
                },                  //g
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },                  //i
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,1,0,1,0},
                    {0,1,0,1,0}
                },                  //n
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,0,1,0},
                    {0,0,1,0,0}
                },                  //o
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,0,1,1},
                    {0,0,1,0,0},
                    {0,0,1,0,0}
                },                  //r
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,1,0,1,0},
                    {0,0,0,1,0},
                    {0,1,1,1,0}
                },                  //s
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,1,1,0},
                    {0,0,0,1,0},
                    {0,0,1,0,0},
                    {0,1,0,0,0},
                    {0,1,1,1,0}
                },                  //z
            }                       //Small Letters
        };
        public static int[] GetLetter(int size,int letter)
        {
            int[] result = new int[6];

            result[0] = GetResult(size, letter, 0, 0, 2, 3);
            result[1] = GetResult(size, letter, 2, 0, 3, 3);
            result[2] = GetResult(size, letter, 3, 0, 5, 3);
            result[3] = GetResult(size, letter, 0, 3, 2, 7);
            result[4] = GetResult(size, letter, 2, 3, 3, 7);
            result[5] = GetResult(size, letter, 3, 3, 5, 7);

            return result;
        }
        private static int GetResult(int size, int letter, int startX, int startY, int endX, int endY)
        {
            for (int i = startY; i < endY; i++)
            {
                for (int j = startX; j < endX; j++)
                {
                    if (LettersData[size, letter, i, j] == 1)
                    {
                        return 1;
                    }
                }
            }

            return 0;
        }
        private Letters()
        {

        }
    }
}