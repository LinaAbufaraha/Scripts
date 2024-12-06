using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Part2
{

    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory potionsInventory = new Inventory();
            potionsInventory.AddItem("Healing Potion");
            potionsInventory.AddItem("Strength Potion");

            Inventory elixirsInventory = new Inventory();
            elixirsInventory.AddItem("Elixir");
            elixirsInventory.AddItem("Dark Elixir");

            Inventory combinedInventory = potionsInventory + elixirsInventory;

            Debug.Log("Combined Inventory Items:");
            combinedInventory.ShowItems();
        }
    }
}
