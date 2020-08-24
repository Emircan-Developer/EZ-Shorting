using System;
using System.Collections.Generic;
using System.Text;

namespace EzSorter
{
    public class Bubble : ISorter
    {
        public int[] Sort(int[] Array)
        {
            int temp;
            for (int j = 0; j < Array.Length; j++)
            {
                for (int i = 1; i < Array.Length; i++)
                {
                    temp = Array[i - 1];
                    if (Array[i] < Array[i - 1])
                    {
                        Array[i - 1] = Array[i];
                        Array[i] = temp;

                    }
                }
            }
            return Array;
        }

        public float[] Sort(float[] Array)
        {
            float temp;
            for (int j = 0; j < Array.Length; j++)
            {

                for (int i = 1; i < Array.Length; i++)
                {
                    temp = Array[i - 1];
                    if (Array[i] > Array[i - 1])
                    {
                        Array[i - 1] = Array[i];
                        Array[i] = temp;

                    }
                }
            }

            return Array;
        }

        public double[] Sort(double[] Array)
        {
            double temp;
            for (int j = 0; j < Array.Length; j++)
            {

                for (int i = 1; i < Array.Length; i++)
                {
                    temp = Array[i - 1];
                    if (Array[i] < Array[i - 1])
                    {
                        Array[i - 1] = Array[i];
                        Array[i] = temp;

                    }
                }
            }

            return Array;
        }

        /*  public string Sort(string[] Array)
          {
              for(int i = 0;i < Array.Length; i++)
              {
                  string
              }
          }*/
    }
}
