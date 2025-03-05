using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35{

    //Define a Delegate
    public delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {   
    
        MathOperation operation = null;
    
        void Start()
        {
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            //operation -= DoubleNumber;

            operation?.Invoke(3);
        
        }

        void DoubleNumber(int number){
            Debug.Log("Double: "+number * 2);
        }

        void SquareNumber(int number){
            Debug.Log("Square: "+number * number);
        }

        void CubeNumber(int number){
            Debug.Log("Cube: "+number * number * number);
        }

        void Update(){
        
        }
    }
}
