using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.x >= 5 || pos.x<=-5) {
            speed *= -1;
            
        }

        pos.x += speed;
        transform.position = pos;
    }
}
