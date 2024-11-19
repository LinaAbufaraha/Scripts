using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        Player player = new Player("Subhi", 80);
        Enemy enemy = new Enemy("Zarifeh", 70);

        Debug.Log("Player name: "+ player.Name+ " player Health: "+player.Health);
        Debug.Log("Enemy name: "+ enemy.Name+ " enemy Health: "+enemy.Health);

        player.Heal(10);

        enemy.Attack(player, 20);
        
    }

    void Update()
    {
        
    }
}
