using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourcesInteraction : MonoBehaviour
{
    public int state = 2;
    public int id;
    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        render.material.color = Color.blue;
    }

    void OnMouseExit()
    {
        render.material.color = Color.white;
    }

    void OnMouseDown()
    {
        GameObject unit = Camera.main.GetComponent<UintSelected>().getObject();
        if (!unit)
            return;

        if ((Vector3.Distance(unit.transform.position, transform.position) > 2.0) || !Input.GetMouseButtonDown(0))
            return;

        if (state == 2) {
            WorkerInventory inventory = unit.GetComponent<WorkerInventory>();
            inventory.addItem(id, 1);
            // Destroy(this.gameObject);
            state = 1;
            this.gameObject.SetActive(false);
        }

        if (state == 1) {
            
        }
    }
}
