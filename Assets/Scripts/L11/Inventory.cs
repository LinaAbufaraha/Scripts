using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Part2{
    public class Inventory 
    {
        private List<string> items;

        public Inventory(){
            items = new List<string>();
        }

        public void AddItem(string item){
            items.Add(item);
        }

        public void ShowItems(){
            
            foreach(string n in items){
                Debug.Log(n);
            }

        }

        public static Inventory operator +(Inventory inv1, Inventory inv2)
        {
            Inventory combinedInventory = new Inventory();

            foreach (string item in inv1.items){

                combinedInventory.AddItem(item);
            }

            foreach (string item in inv2.items){
                
                combinedInventory.AddItem(item);
            }

            return combinedInventory;
        }
       
    }

}

