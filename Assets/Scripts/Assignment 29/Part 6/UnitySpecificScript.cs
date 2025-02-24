using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{//Part6
    public class UnitySpecificScript : MonoBehaviour
    {

        private GameObject targetObject;
        private GameObject joker;
        private Light pointLight;

        private void OnEnable(){
            Debug.Log("GameObject Enabled");
        } 

        private void OnDisable(){
            Debug.Log("GameObject Disabled");
        } 
        void Start(){
            Debug.Log("Game started!");

            targetObject = GameObject.Find("TargetObject");
            joker = GameObject.FindGameObjectWithTag("Joker");
            pointLight = GameObject.FindObjectOfType<Light>();

            Debug.Log(targetObject ? $"{targetObject.name}" : "No TargetObject found.");
            Debug.Log(joker ? $"{joker.name}" : "No Joker object found.");
            Debug.Log(pointLight ? $"{pointLight.name}" : "No Light object found.");

        }
       

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameObject targetObject = GameObject.Find("TargetObject");
                if (targetObject)
                {
                    targetObject.SetActive(false);
                    Debug.Log("TargetObject deactivated!");
                }
            }
        
        }
    }
}
