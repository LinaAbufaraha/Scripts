using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35{
    public class BoxingUnboxing : MonoBehaviour
    {
        int health = 100;
        void Start()
        {
            Debug.Log(health);

            object obj = health;
            Debug.Log($"Boxed value: {obj}");

            int modifiedValue = (int)obj;
            modifiedValue += 5;
            Debug.Log($"Unboxed and modified value: {modifiedValue}");
        
        }

        void Update()
        {
        
        }
    }


}
