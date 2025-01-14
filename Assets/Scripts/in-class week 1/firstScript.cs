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
        

        //right size
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeInWorld = new Vector2();
        screenSizeInWorld = Camera.main.ScreenToWorldPoint(screenSize);

        //left side
        Vector2 screenZeroInWorld = Camera.main.ScreenToWorldPoint(Vector2.zero);
        
        if (pos.x >= screenSizeInWorld.x || pos.x <= screenZeroInWorld.x) {
            speed *= -1;
        }

        pos.x += speed;
        transform.position = pos;
    }
}
