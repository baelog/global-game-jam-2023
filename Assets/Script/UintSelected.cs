using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UintSelected : MonoBehaviour
{
    public GameObject stockedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setObject(GameObject objectToMove)
    {
        stockedObject = objectToMove;
    }

    public GameObject getObject()
    {
        return stockedObject;
    }
}
