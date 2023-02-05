using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorkerInventory : MonoBehaviour
{
    int[] inventory = new int[12];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i != inventory.Length; ++i)
            inventory[i] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(int id, int number)
    {
        inventory[id] += number;
    }

    public int[] getInventory()
    {
        return inventory;
    }
}
