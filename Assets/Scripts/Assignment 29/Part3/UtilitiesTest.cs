using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{//Part3
    public class UtilitiesTest : MonoBehaviour
    {
        void Start()
        {
            int sum = Utilities.Add(1, 2, 3, 4, 5, 6);
            Debug.Log($"Sum: {sum}");

            string repeated = "Hello".RepeatString(3);
            Debug.Log(repeated);
        
        }

        void Update()
        {
            
        }
    }
}
