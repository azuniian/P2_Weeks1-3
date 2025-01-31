using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingFlap : MonoBehaviour
{
    public float flapSpeed = 5f;
    public float flapDirection;
    public float flapLength = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (flapLength <= 5)
        {
            if (flapLength <= 5)
            {
                transform.Rotate(0, 0, (flapSpeed * flapDirection) * Time.deltaTime);
                flapLength += 1 * Time.deltaTime;
            }

            if (flapLength >= 5)
            {
                flapDirection *= -1;
                flapLength = 0;
            }
            
        }
        

        
    }
}
