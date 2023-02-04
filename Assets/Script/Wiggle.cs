using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    public float maxSize = 6;
    public float minSize = 3;
    public float maxScaleSpeed = 1;
    public float minScaleSpeed = 1/4;
    
    private float desiredSize;
    private float desiredSpeed;

    // Start is called before the first frame update
    void Start()
    {
        GenerateNewSize();    
    }

    // Update is called once per frame
    void Update()
    {
        if (desiredSize < transform.localScale.x)
        {
            transform.localScale = new Vector3(transform.localScale.x - Time.deltaTime * desiredSpeed, transform.localScale.y - Time.deltaTime * desiredSpeed, transform.localScale.z - Time.deltaTime * desiredSpeed);

            if (transform.localScale.x <= desiredSize)
            {
                GenerateNewSize();
            }
        }
        else if (desiredSize > transform.localScale.x)
        {
            transform.localScale = new Vector3(transform.localScale.x + Time.deltaTime * desiredSpeed, transform.localScale.y + Time.deltaTime * desiredSpeed, transform.localScale.z + Time.deltaTime * desiredSpeed);
            
            if (transform.localScale.x <= desiredSize)
            {
                GenerateNewSize();
            }
        }
    }

    private void GenerateNewSize()
    {
        desiredSize = Random.Range(minSize, maxSize);
        desiredSpeed = Random.Range(minScaleSpeed, maxScaleSpeed);
    }
}
