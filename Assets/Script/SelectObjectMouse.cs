using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectMouse : MonoBehaviour
{
    public GameObject mainCamera;
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

    void OnMouseClick()
    {
        UintSelected component = mainCamera.GetComponent<UintSelected>();
    }
}
