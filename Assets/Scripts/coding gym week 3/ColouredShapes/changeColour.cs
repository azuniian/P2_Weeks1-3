using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    public SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 spriteDimensions = (Vector2)transform.localScale;

        Debug.Log(currentPos);


        if(currentPos.x < (spriteDimensions/2).x && currentPos.x > -(spriteDimensions/2).x && currentPos.y < (spriteDimensions/2).y && currentPos.y > -(spriteDimensions/2).y)
        {
            sprite.color = new Color(255, 0, 0);
        }

        else
        {
            sprite.color = new Color(255, 255, 255);
        }
    }
}
