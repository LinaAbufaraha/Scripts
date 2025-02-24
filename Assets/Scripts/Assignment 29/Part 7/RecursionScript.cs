using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{//Part7
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            Debug.Log($"FibonacciRecursive n=10 : {FibonacciRecursive(10)}");
            Debug.Log($"FibonacciIterative n=10 : {FibonacciIterative(10)}");
            Debug.Log($"FibonacciRecursive n=30 : {FibonacciRecursive(30)}");
            Debug.Log($"FibonacciIterative n=30 : {FibonacciIterative(30)}");
        
        }

        int FibonacciRecursive(int n)
        {
            if (n < 2) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

         int FibonacciIterative(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            int a = 0, b = 1, sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }



    }
}
