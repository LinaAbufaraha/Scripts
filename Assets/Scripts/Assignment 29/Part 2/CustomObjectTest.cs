using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29{
    public class CustomObjectTest : MonoBehaviour
    {//Part2
        void Start()
        {

            CustomObject o1 = new CustomObject(1, "Lina");
            CustomObject o2 = new CustomObject(2, "Ramz");
            CustomObject o3 = new CustomObject(2, "Ramz");

            Debug.Log(o1.ToString());
            Debug.Log(o2.ToString());
            Debug.Log(o1.Equals(o2));
            Debug.Log(o3.Equals(o2));
           
        }

    }
}
