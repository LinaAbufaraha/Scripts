using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35{

    public class BuiltInDelegatesExample : MonoBehaviour
    {
        private Action<string> logMessage;
        
        private Func<int, int> square;
        
        private Predicate<int> isEven;
        void Start()
        {
            logMessage = (string mess) => Debug.Log(mess);
            logMessage("Hello from Action delegate!");

            square = (int num) => 5 * 5;
            Debug.Log($"Square: {square(5)}");

            isEven = (num) => num % 2 == 0 ? true : false;
            Debug.Log($"Is 4 even? {isEven(4)}");
        
        }

   
    }
}
