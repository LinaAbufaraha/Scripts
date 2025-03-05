using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35{

    public class ListMethodsExample : MonoBehaviour
    {
        private List<int> numbers1 = new List<int> {1,2,9,8,5,6,2,4};
        private List<int> numbers2 = new List<int> {3,5,4,6,1,2,8,9,1,0,3};
        void Start()
        {
            numbers1.Sort((x, y) => x.CompareTo(y));
            Debug.Log("Sorted List: " + string.Join(", ", numbers1));

            List<int> filteredNumbers = numbers2.FindAll((number) => number % 2 == 0);
            Debug.Log("even Numbers: " + string.Join(", ", filteredNumbers));

        }

        void Update()
        {
        
        }
    }
}
