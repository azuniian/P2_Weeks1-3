using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Bullet bullet;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if(bullet == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
        //constructor for a separate script
        GameObject bulletGo = Instantiate(prefab);

        //connect object in this script with another script
        bullet = bulletGo.GetComponent<Bullet>();
    }

    void Fire()
    {
        //change value in another script
        bullet.hasBeenFired = true;
        //local variable is null so another can be spawned
        bullet = null;
    }
}
