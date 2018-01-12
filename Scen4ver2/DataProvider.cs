﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scen4ver2
{
    class DataProvider
    {
        public static char[] Character = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T' };
        public static double[,] input = new double[,]{
            {
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//A
			{
                1.0, 1.0, 1.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//B
			{
                0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 0.0
            },	//C
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0
            },	//D
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//E
			{
                1.0, 1.0, 0.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
            },	//F
			{
                0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//G
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//H
			{
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0
            },	//I
			{
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0
            },	//J
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0
            },	//K
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//L
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 1.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 1.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//M
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//N
			{
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0
            },	//O
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
            },	//P
			{
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 1.0, 1.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//Q
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0
            },	//R
			{
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0
            },	//S
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0
            }	//T
	    };
        public static double[,] testInput = new double[,]{
             {
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//A
			{
                1.0, 1.0, 1.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//B
			{
                0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 0.0
            },	//C
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0
            },	//D
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//E
			{
                1.0, 1.0, 0.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
            },	//F
			{
                0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//G
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//H
			{
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0
            },	//I
			{
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                0.0, 0.0, 0.0, 0.0, 1.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0
            },	//J
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0
            },	//K
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
            },	//L
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 1.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 1.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//M
			{
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//N
			{
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0
            },	//O
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
            },	//P
			{
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 1.0, 1.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
            },	//Q
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0
            },	//R
			{
                0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0
            },	//S
			{
                1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0
            }	//T
	    };

        public static double[] GetInput(int number, double[,] data)
        {
            double[] result = new double[data.GetLength(1)];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = data[number, i];
            }

            return result;
        }
        public static void RestoreInputToCorrectOrder()
        {
            double[,] input = new double[,]{
            {
                    0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                },	//A
			    {
                    1.0, 1.0, 1.0, 1.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
                },	//B
			    {
                    0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 1.0, 1.0, 1.0, 0.0
                },	//C
			    {
                    1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0
                },	//D
			    {
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
                },	//E
			    {
                    1.0, 1.0, 0.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
                },	//F
			    {
                    0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
                },	//G
			    {
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                },	//H
			    {
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0
                },	//I
			    {
                    0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 0.0, 1.0, 1.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 1.0, 0.0, 0.0,
                    0.0, 0.0, 1.0, 0.0, 1.0, 0.0, 0.0,
                    0.0, 1.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    0.0, 1.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0
                },	//J
			    {
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0
                },	//K
			    {
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0
                },	//L
			    {
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 0.0, 0.0, 0.0, 1.0, 1.0,
                    1.0, 0.0, 1.0, 0.0, 1.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                },	//M
			    {
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                },	//N
			    {
                    0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0
                },	//O
			    {
                    1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
                },	//P
			    {
                    0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    0.0, 1.0, 1.0, 1.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0
                },	//Q
			    {
                    1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0
                },	//R
			    {
                    0.0, 0.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    0.0, 1.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0,
                    1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0,
                    0.0, 1.0, 1.0, 1.0, 1.0, 0.0, 0.0
                },	//S
			    {
                    1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0
                }	//T
	        };
            Array.Copy(input, DataProvider.input, DataProvider.input.Length);
        }
        public static void ShuffleInputData()
        {
            int inputDataCount = input.GetLength(0);
            int inputDataAttributionsCount = input.GetLength(1);
            Random r = new Random();
            int place;

            double[] tmp = new double[inputDataAttributionsCount];
            for (int i = 0; i < inputDataCount; i++)
            {

                for (int j = 0; j < inputDataAttributionsCount; j++)
                {
                    tmp[j] = input[i, j];
                }

                place = r.Next(i, inputDataCount);

                for (int j = 0; j < inputDataAttributionsCount; j++)
                {
                    input[i, j] = input[place, j];
                }

                for (int j = 0; j < inputDataAttributionsCount; j++)
                {
                    input[place, j] = tmp[j];
                }
            }
        }
    }
}
