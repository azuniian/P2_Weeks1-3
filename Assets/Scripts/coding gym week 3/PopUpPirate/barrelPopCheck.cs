using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelPopCheck : MonoBehaviour
{
    public bool isPopped = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPopped == true)
        {
            gameLoss();
        }

        else
        {
            
        }
    }

    void gameLoss()
    {

    }

    void gameWin()
    {

    }
}
