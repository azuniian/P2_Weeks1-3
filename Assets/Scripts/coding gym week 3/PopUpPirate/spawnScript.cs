using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawnScript : MonoBehaviour
{
    public GameObject prefab;
    public barrelPopCheck barrel;
    public List<GameObject> barrelsOnScreen;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(barrel = null)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject barrelSpawn = Instantiate(prefab);

        barrel = barrelSpawn.GetComponent<barrelPopCheck>();
        
    }
}
