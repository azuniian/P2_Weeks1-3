using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birbMovement : MonoBehaviour
{
    
    
    [Range(0,1)]
    public float speed = 0f;
    public AnimationCurve animationCurve;
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.Lerp(start.position, end.position, animationCurve.Evaluate(speed));

        if (speed >= 1)
        {
            speed = 0;
        }

        if (speed < 1)
        {
            speed += (float)(0.0275 * (Time.deltaTime));
        }

    }
}
