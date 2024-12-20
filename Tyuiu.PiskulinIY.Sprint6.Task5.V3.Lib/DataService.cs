﻿using System.Linq;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PiskulinIY.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line); 
                    index++;
                }

            }

            numsArray = numsArray.Where(var => var % 1 != 0).ToArray();

            return numsArray;

        }
    }
}
