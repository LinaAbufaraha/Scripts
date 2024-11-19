using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
    public class CharacterTest : MonoBehaviour
    {
    
        void Start()
        {
            Character[] characters = new Character[2];
                characters[0] = new Soldier("Lina", 100, new Position(3, 3, 3));
                characters[1] = new Officer("Zarifeh", 90, new Position(2, 2, 2));

            
                for(int i=0;i<characters.Length;i++){
                    characters[i].DisplayInfo();
                }
            
                Officer officer = (Officer)characters[1];
                Soldier soldier = (Soldier)characters[0];

                Debug.Log("Soldier's Health before attack:" +soldier.Health);
                officer.Attack(20, soldier, "kicking");
                Debug.Log($"Soldier's Health after attack:"+soldier.Health);
        
        }

    }

}
