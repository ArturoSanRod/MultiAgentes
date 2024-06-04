using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShots : MonoBehaviour
{

    public GameObject Shot;
    public Transform BulletSpawn;
    public float fireRate;
    private float nextFire;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shot, BulletSpawn.position, BulletSpawn.rotation);
        }
        
    }
}
