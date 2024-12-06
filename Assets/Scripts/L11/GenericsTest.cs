using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Part1{
    public class GenericsTest : MonoBehaviour
    {
        void Start()
        {
            GameContainer<string> container = new GameContainer<string>();
            container.SetItem("Healing Potion");

            string savedItem = container.GetItem();
            Debug.Log("Saved item: "+savedItem);
            
            Debug.Log(GameUtils.DescribeItem(savedItem));
        
        }   

        void Update()
        {
        
        }
    }
}
