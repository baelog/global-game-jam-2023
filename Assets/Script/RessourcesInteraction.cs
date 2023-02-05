using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourcesInteraction : MonoBehaviour
{
    public int state = 2;
    public int id;
    float timeToReappear;
    Collider objectColider;
    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        timeToReappear = Random.Range(5, 16);
        render = GetComponent<Renderer>();
        objectColider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (state != 1)
            return;
        if (timeToReappear > 0) {
            timeToReappear -= Time.deltaTime;
        } else {
            state = 2;
            timeToReappear = Random.Range(5, 16);
            objectColider.enabled = !objectColider.enabled;
            render.enabled = !render.enabled;
            // this.gameObject.SetActive(true);
        }
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

        if (state != 2)
            return;

        WorkerInventory inventory = unit.GetComponent<WorkerInventory>();
        inventory.addItem(id, 1);
        // Destroy(this.gameObject);
        state = 1;
        objectColider.enabled = !objectColider.enabled;
        render.enabled = !render.enabled;
        // this.gameObject.SetActive(false);
    }
}
