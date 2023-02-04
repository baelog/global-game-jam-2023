using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHider : MonoBehaviour
{

    public GameObject mapObj;
    public float desiredDistance = 20;
    public float maxDistance = 100;
    public bool doShow = true;
    public bool doScale = false;
    private GameObject[] childlist;

    // Update is called once per frame
    void Update()
    {
        dissapearCheck();    
    }

    private void dissapearCheck() 
    {

        childlist = GameObject.FindGameObjectsWithTag("Cloud");

        foreach(GameObject child in childlist)
        {
            float distance = Vector3.Distance(child.transform.position, transform.position);

            if (distance < desiredDistance)
            {
                if (!doShow) 
                {
                    if (!child.transform.gameObject.activeInHierarchy)
                    {
                        child.transform.gameObject.SetActive(false);
                    }
                }
                else
                {
                    if (child.transform.gameObject.activeInHierarchy && !doScale)
                    {
                        child.transform.gameObject.SetActive(false);
                    }
                    else if (child.transform.gameObject.activeInHierarchy && doScale)
                    {
                        child.transform.GetComponent<Scaler>().ToggleScale(false);
                    }
                }
            }
            // else
            // {
            //     if (!doShow) 
            //     {
            //         if (child.transform.gameObject.activeInHierarchy)
            //         {
            //             child.transform.gameObject.SetActive(false);
            //         }
            //     }
            //     else 
            //     {
            //         if (distance < maxDistance) 
            //         {
            //             if (!child.transform.gameObject.activeInHierarchy && !doScale) 
            //             {
            //                 child.transform.gameObject.SetActive(true);
            //             }
            //             else if (!child.transform.gameObject.activeInHierarchy && doScale) 
            //             {
            //                 child.transform.gameObject.SetActive(true);
            //                 child.transform.GetComponent<Scaler>().ToggleScale(true);
            //             }
            //         }
            //         else
            //         {
            //             child.transform.gameObject.SetActive(false);
            //         }
            //     }
            // }
        }
    }
}
