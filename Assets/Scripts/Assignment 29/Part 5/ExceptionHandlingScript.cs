using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{//Part5
    public class ExceptionHandlingScript : MonoBehaviour
    {

        int playerScore = 100;    
        int divisor = 0;  //intentionally set to 0 to simulate division by zero

        void Start()
        {
            
            try{
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / divisor;
            }
            catch (System.DivideByZeroException e){
                Debug.Log(e.Message);
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally{
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        
        }

        void Update()
        {
        
        }
    }
}
