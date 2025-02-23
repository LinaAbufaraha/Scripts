using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{//Part3
    public static class Utilities 
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static string RepeatString(this string str, int times)
        {
            string result = "";

            for (int i = 0; i < times; i++){
                result += str;
            }
            return result;
        }
        
    }
}
