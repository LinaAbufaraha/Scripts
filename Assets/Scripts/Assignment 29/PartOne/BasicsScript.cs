using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assignment29{

    public class BasicsScript : MonoBehaviour
    {
        //PartOne
        void Start()
        {
            var num = 3;
            var boolean = num % 2 == 0 ? true : false;
            var message = boolean ? "even" : "odd";

            Debug.Log($"The number {num} is {message}.");

            Debug.Log("Current Date: " + System.DateTime.Now.Date);
            Debug.Log("Current Time: " + System.DateTime.Now.TimeOfDay);
            Debug.Log("Current Day: " + System.DateTime.Now.DayOfWeek);

        }

        void Update()
        {
        
        }
    }
}
