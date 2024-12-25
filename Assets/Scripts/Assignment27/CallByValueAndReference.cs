using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment27{
    public class CallByValueAndReference : MonoBehaviour
    {
        int a = 5;
        int b = 10;
        int c;
    
        void Start()
        {
            Debug.Log("a: " + a);

            CallByValue(a);
            Debug.Log("a: " + a);


            Debug.Log("b: " + b);

            CallByReference(ref b);
            Debug.Log("b: " + b);

            
            UsingOutKeyword(out c);
            Debug.Log("c: " + c);
        
        }

        void CallByValue(int v)
        {
            v += 10;
            Debug.Log("Call By Value : " + v);
        }

        void CallByReference(ref int v)
        {
            v += 10;
            Debug.Log("Call By Reference : " + v);
        }


        void UsingOutKeyword(out int v)
        {
            v = 20; 
            Debug.Log("Value inside UsingOutKeyword method: " + v);
        }

        void Update()
        {
        
        }
    }
}
