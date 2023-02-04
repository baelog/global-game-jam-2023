using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectMouse : MonoBehaviour
{
    // public Camera mainCamera;
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
        render.material.color = Color.red;
    }

    void OnMouseExit()
    {
        render.material.color = Color.white;
    }

    void OnMouseDown()
    {
        if (!Input.GetMouseButtonDown(0))
            return;
        Debug.Log("going to the camera");
        UintSelected component = Camera.main.GetComponent<UintSelected>();
        component.setObject(this.gameObject);
    }
}
