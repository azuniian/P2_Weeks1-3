using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windmillRotate : MonoBehaviour
{
    public float rotationSpeed = 5f;
    float rotationDirection = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            rotationDirection *= -1;
        }

        transform.Rotate(0, 0, (rotationDirection * rotationSpeed) * Time.deltaTime);
    }
}
